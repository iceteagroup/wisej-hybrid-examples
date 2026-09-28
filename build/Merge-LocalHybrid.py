"""Merge matching Windows/Android and Apple NuGet slices into a portable feed.

Usage: python3 build/Merge-LocalHybrid.py WINDOWS_FEED APPLE_FEED OUTPUT_FEED
Only packages with identical IDs/versions and disjoint framework assets may merge.
"""
from copy import deepcopy
from pathlib import Path
import sys
import xml.etree.ElementTree as ET
from zipfile import ZipFile, ZIP_DEFLATED

windows, apple, output = (Path(p).resolve() for p in sys.argv[1:4])
if output in (windows, apple):
    raise SystemExit('Output must be separate from both input feeds.')
output.mkdir(parents=True, exist_ok=True)
def local_name(element):
    return element.tag.rsplit('}', 1)[-1]
def metadata_key(element):
    # NuGet metadata is unordered; pack can emit the same dependencies in a
    # different order on Windows and macOS. Ignore formatting, not values.
    return (element.tag, tuple(sorted(element.attrib.items())),
            (element.text or '').strip(),
            tuple(sorted(metadata_key(child) for child in element)))

def merge_xml(a, b):
    base, other = ET.fromstring(a), ET.fromstring(b)
    if local_name(base) == 'package':
        base_metadata, other_metadata = list(base)[0], list(other)[0]
        for key in ('id', 'version'):
            values = [next(n.text for n in parent if local_name(n) == key)
                      for parent in (base_metadata, other_metadata)]
            if values[0] != values[1]:
                raise ValueError(f'Package {key} differs: {values}')
        for section in other_metadata:
            if local_name(section) not in ('dependencies', 'frameworkReferences', 'frameworkAssemblies', 'references', 'contentFiles'):
                continue
            target = next((n for n in base_metadata if n.tag == section.tag), None)
            if target is None:
                base_metadata.append(deepcopy(section))
            else:
                for child in section:
                    identical = any(metadata_key(child) == metadata_key(existing) for existing in target)
                    if not identical:
                        tfm = child.get('targetFramework')
                        if tfm and any(existing.get('targetFramework') == tfm for existing in target):
                            raise ValueError(f'Conflicting metadata for {tfm}')
                        target.append(deepcopy(child))
    else:
        for child in other:
            if not any(child.attrib == existing.attrib for existing in base):
                base.append(deepcopy(child))
    # NuGet's nuspec reader expects an unprefixed package/metadata tree. Preserve
    # the default namespace instead of ElementTree's generated ns0 prefix.
    if base.tag.startswith('{'):
        ET.register_namespace('', base.tag[1:].split('}', 1)[0])
    return ET.tostring(base, encoding='utf-8', xml_declaration=True)

packages = list(windows.glob('*.nupkg'))
if not packages:
    raise SystemExit('Windows feed is empty.')
for package in packages:
    counterpart = apple / package.name
    if not counterpart.exists():
        raise FileNotFoundError(f'Missing Apple slice: {counterpart}')
    with ZipFile(package) as a, ZipFile(counterpart) as b:
        files = {n: a.read(n) for n in a.namelist()}
        for name in b.namelist():
            data = b.read(name)
            if name in files and files[name] != data:
                if name.endswith('.nuspec') or name == '[Content_Types].xml':
                    files[name] = merge_xml(files[name], data)
                elif name.startswith(('lib/', 'build/', 'runtimes/')):
                    raise ValueError(f'Conflicting asset: {package.name}: {name}')
            else:
                files[name] = data
        with ZipFile(output / package.name, 'w', ZIP_DEFLATED) as merged:
            for name, data in files.items():
                merged.writestr(name, data)
    print(package.name)
