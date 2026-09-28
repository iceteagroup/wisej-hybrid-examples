"""Build each Apple example against the local feed with ad hoc signing.

Usage: python3 build/Test-LocalHybrid.Apple.py VERSION [EXAMPLE ...] [--platform iOS|MacCatalyst]
Uses the iOS simulator or native Mac on Apple Silicon; no provisioning is required.
"""
import argparse
import json
from pathlib import Path
import subprocess
import sys
import xml.etree.ElementTree as ET

root = Path(__file__).resolve().parent.parent
local = root / '.local-nuget'
parser = argparse.ArgumentParser(description=__doc__)
parser.add_argument('version')
parser.add_argument('examples', nargs='*')
parser.add_argument('--platform', choices=['iOS', 'MacCatalyst'], default='iOS')
args = parser.parse_args()
version = args.version
framework = 'net9.0-ios' if args.platform == 'iOS' else 'net9.0-maccatalyst'
runtime = 'iossimulator-arm64' if args.platform == 'iOS' else 'maccatalyst-arm64'
examples = args.examples or ['Authentication', 'DocumentScanner', 'ExternalApps',
                           'Flashlight', 'LocalDatabase', 'Navigation', 'NetworkEvents', 'PlatformCode',
                           'RemoteWebApi', 'Shortcuts', 'Showcase']
results = []
for example in examples:
    project = root / ('Showcase/App/HybridApp.csproj' if example == 'Showcase' else f'{example}/HybridClient/HybridClient.csproj')
    if not any(framework in (n.text or '') for n in ET.parse(project).iter('TargetFrameworks')):
        results.append(dict(example=example, status='skipped', reason=f'No {args.platform} target'))
        continue
    log = local / 'logs' / (example + '-' + args.platform + '-test.log')
    properties = ['-p:UseLocalHybridPackages=true', '-p:TargetFrameworks=' + framework,
                  '-p:RuntimeIdentifier=' + runtime, '-p:EnableCodeSigning=true', '-p:CodesignKey=-',
                  '-p:CodesignRequireProvisioningProfile=false', '-p:BuildInParallel=false']
    print('Testing ' + example, flush=True)
    with log.open('w') as output:
        restore = subprocess.run(['dotnet', 'restore', str(project), '--configfile', str(local / 'NuGet.Config'),
                                  '--verbosity', 'quiet'] + properties, cwd=root, stdout=output, stderr=subprocess.STDOUT)
        if restore.returncode:
            results.append(dict(example=example, status='restore-failed', log=str(log)))
            continue
        assets = json.loads((project.parent / 'obj/project.assets.json').read_text())
        dependencies = {name: data for name, data in assets['libraries'].items()
                        if name.startswith(('Wisej-4-Hybrid', 'Wisej.Hybrid'))}
        if not dependencies or any(data['type'] != 'package' or not name.endswith('/' + version)
                                   for name, data in dependencies.items()):
            results.append(dict(example=example, status='wrong-dependencies', dependencies=list(dependencies)))
            continue
        build = subprocess.run(['dotnet', 'build', str(project), '-f', framework, '--no-restore', '-m:1',
                                '--verbosity', 'quiet'] + properties, cwd=root, stdout=output, stderr=subprocess.STDOUT)
        status = 'passed' if build.returncode == 0 else 'build-failed'
        results.append(dict(example=example, status=status, dependencies=list(dependencies), log=str(log)))
        print(f'{example}: {status}', flush=True)
report = local / ('results-' + args.platform + '.json')
report.write_text(json.dumps(dict(version=version, framework=framework, results=results), indent=2))
print(report, flush=True)
sys.exit(1 if any(r['status'] not in ('passed', 'skipped') for r in results) else 0)
