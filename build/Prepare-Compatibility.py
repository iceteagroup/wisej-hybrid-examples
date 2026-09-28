"""Prepare committed 4.0 samples for a package-only 4.1 migration test.

Only project/build settings change. Application sources are hashed before and
after preparation; later platform-specific accommodations must be reported.
"""
import argparse
import hashlib
import io
import json
import pathlib
import subprocess
import uuid
import zipfile
import xml.etree.ElementTree as ET

p = argparse.ArgumentParser(description=__doc__)
p.add_argument("source", type=pathlib.Path)
p.add_argument("output", type=pathlib.Path)
p.add_argument("--version", required=True)
p.add_argument("--feed", type=pathlib.Path, required=True)
p.add_argument("--ref", default="HEAD")
p.add_argument("--exclude", nargs="*", default=["DynamicUpdates"],
               help="Samples no longer shipped in 4.1.")
a = p.parse_args()
source, output = a.source.resolve(), a.output.resolve()
if output.exists():
    raise SystemExit("Use a new output directory to preserve previous evidence.")
revision = subprocess.check_output(["git", "-C", str(source), "rev-parse", a.ref], text=True).strip()
archive = subprocess.check_output(["git", "-C", str(source), "archive", "--format=zip", revision])
output.mkdir(parents=True)
with zipfile.ZipFile(io.BytesIO(archive)) as z:
    z.extractall(output, members=[n for n in z.namelist() if n.split("/", 1)[0] not in a.exclude])

def sources():
    return {str(f.relative_to(output)).replace("\\", "/"): hashlib.sha256(f.read_bytes()).hexdigest()
            for f in output.rglob("*.cs")}

original = sources()
changes, apps = [], []
for project in sorted(output.rglob("*.csproj")):
    relative = project.relative_to(output).as_posix()
    if relative.startswith("ShowcaseTests/"):
        continue  # Existing browser test harness is not a distributable sample.
    text = project.read_text(encoding="utf-8-sig")
    text = text.replace("net8.0", "net9.0")
    doc = ET.fromstring(text)
    for item in doc.iter("PackageReference"):
        package = item.get("Include", "")
        if package.startswith("Wisej-4-Hybrid"):
            item.set("Version", a.version)
        elif package == "Wisej-4" or package.startswith("Wisej-4-") or package == "Managed.System.Drawing":
            item.set("Version", "4.1.4")
        elif package == "Microsoft.Maui.Controls":
            item.set("Version", "9.0.120")
    host = any(x.text == "true" for x in doc.iter("UseMaui"))
    if host:
        if not any(x.get("Include") == "Microsoft.Maui.Controls" for x in doc.iter("PackageReference")):
            ET.SubElement(ET.SubElement(doc, "ItemGroup"), "PackageReference",
                          {"Include": "Microsoft.Maui.Controls", "Version": "9.0.120"})
        example = project.relative_to(output).parts[0]
        identity = "com.iceteagroup.compat40." + example.lower()
        for x in doc.iter("ApplicationId"):
            x.text = identity
        for x in doc.iter("ApplicationIdGuid"):
            x.text = str(uuid.uuid5(uuid.NAMESPACE_URL, identity))
        for x in doc.iter("ApplicationVersion"):
            x.text = "401"
        if any((x.text or "").lower() == "exe" for x in doc.iter("OutputType")):
            apps.append({"example": example, "project": relative, "identity": identity,
                         "frameworks": ";".join(x.text or "" for x in doc.iter("TargetFrameworks"))})
    ET.indent(doc, space="  ")
    project.write_text(ET.tostring(doc, encoding="unicode") + "\n", encoding="utf-8")
    changes.append(relative)

config = ET.Element("configuration")
feeds = ET.SubElement(config, "packageSources")
ET.SubElement(feeds, "clear")
ET.SubElement(feeds, "add", {"key": "candidate", "value": str(a.feed.resolve())})
ET.SubElement(feeds, "add", {"key": "nuget.org", "value": "https://api.nuget.org/v3/index.json"})
ET.ElementTree(config).write(output / "NuGet.Config", encoding="utf-8", xml_declaration=True)
(output / "global.json").write_text(json.dumps({"sdk": {"version": "9.0.311", "rollForward": "disable"}}, indent=2))
assert sources() == original, "Application source changed during migration preparation."
report = {"baselineCommit": revision, "candidateVersion": a.version,
          "excludedExamples": a.exclude,
          "changes": ["Wisej packages 4.1.4; Hybrid candidate packages", "net8.0 to net9.0 including conditions",
                      "Explicit MAUI Controls 9.0.120", "Isolated test app identities/version"],
          "projectFiles": changes, "apps": apps, "applicationSourceHashes": original,
          "applicationSourceUnchanged": True}
(output / "compatibility-preparation.json").write_text(json.dumps(report, indent=2), encoding="utf-8")
print(json.dumps({"output": str(output), "baseline": revision, "apps": apps}, indent=2))
