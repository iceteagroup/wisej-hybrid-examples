"""Build each iOS example against the local feed with ad hoc simulator signing.

Usage: python3 build/Test-LocalHybrid.Apple.py VERSION [EXAMPLE ...]
Uses the iOS simulator on Apple Silicon; no device provisioning is required.
"""
import json
from pathlib import Path
import subprocess
import sys
import xml.etree.ElementTree as ET

root = Path(__file__).resolve().parent.parent
local = root / '.local-nuget'
version = sys.argv[1]
examples = sys.argv[2:] or ['Authentication', 'DocumentScanner', 'DynamicUpdates', 'ExternalApps',
                           'Flashlight', 'LocalDatabase', 'Navigation', 'NetworkEvents', 'PlatformCode',
                           'RemoteWebApi', 'Shortcuts', 'Showcase']
results = []
for example in examples:
    project = root / ('Showcase/App/HybridApp.csproj' if example == 'Showcase' else f'{example}/HybridClient/HybridClient.csproj')
    if not any('net9.0-ios' in (n.text or '') for n in ET.parse(project).iter('TargetFrameworks')):
        results.append(dict(example=example, status='skipped', reason='Android-only example'))
        continue
    log = local / 'logs' / (example + '-iOS-test.log')
    properties = ['-p:UseLocalHybridPackages=true', '-p:TargetFrameworks=net9.0-ios',
                  '-p:RuntimeIdentifier=iossimulator-arm64', '-p:EnableCodeSigning=true', '-p:CodesignKey=-',
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
        build = subprocess.run(['dotnet', 'build', str(project), '-f', 'net9.0-ios', '--no-restore', '-m:1',
                                '--verbosity', 'quiet'] + properties, cwd=root, stdout=output, stderr=subprocess.STDOUT)
        status = 'passed' if build.returncode == 0 else 'build-failed'
        results.append(dict(example=example, status=status, dependencies=list(dependencies), log=str(log)))
        print(f'{example}: {status}', flush=True)
report = local / 'results-iOS.json'
report.write_text(json.dumps(dict(version=version, framework='net9.0-ios', results=results), indent=2))
print(report, flush=True)
sys.exit(1 if any(r['status'] not in ('passed', 'skipped') for r in results) else 0)
