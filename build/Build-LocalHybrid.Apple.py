"""Build the Apple slice of the local Hybrid feed on a Mac with .NET 9/Xcode.

Usage: python3 build/Build-LocalHybrid.Apple.py HYBRID_ROOT EXTENSIONS_ROOT VERSION
The Windows and Apple feeds must use the same version and source commits.
"""
import json
from pathlib import Path
import subprocess
import sys
from xml.sax.saxutils import escape

root = Path(__file__).resolve().parent.parent
hybrid, extensions = (Path(p).resolve() for p in sys.argv[1:3])
version = sys.argv[3]
local = root / '.local-nuget'
feed, logs = local / 'feed', local / 'logs'
feed.mkdir(parents=True, exist_ok=True)
logs.mkdir(exist_ok=True)
config = local / 'NuGet.Config'
config.write_text(f'''<configuration><packageSources><clear />
<add key="Local Hybrid" value="{escape(str(feed))}" />
<add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
</packageSources></configuration>''')
projects = [hybrid / name / (name + '.csproj') for name in
            ('Wisej.Hybrid.Runtime', 'Wisej.Hybrid.Scanning', 'Wisej.Hybrid', 'Wisej.Hybrid.Native')]
for extension in ('Authentication', 'DocumentScanner', 'MLKit'):
    for suffix in ('', '.Native'):
        name = f'Wisej.Hybrid.{extension}{suffix}'
        projects.append(extensions / extension / name / (name + '.csproj'))
for project in projects:
    frameworks = subprocess.check_output(
        ['dotnet', 'msbuild', str(project), '-getProperty:TargetFrameworks', '-verbosity:quiet'],
        cwd=root, text=True).strip().split(';')
    frameworks = [f for f in frameworks if f in ('net9.0-ios', 'net9.0-maccatalyst')]
    if not frameworks:
        continue
    name = project.stem
    wrapper = local / (name + '.targets')
    original = extensions / 'Directory.Build.targets'
    original_import = f'<Import Project="{escape(str(original))}" />' if extensions in project.parents else ''
    wrapper.write_text(f'''<Project>{original_import}
<PropertyGroup><TargetFrameworks>{';'.join(frameworks)}</TargetFrameworks></PropertyGroup>
<Import Project="{escape(str(root / 'build/LocalHybrid.Pack.targets'))}" />
<!-- The extension staging targets use Windows xcopy; SDK pack uses TargetPath directly. -->
<Target Name="PostBuild" />
</Project>''')
    command = ['dotnet', 'pack', str(project), '-c', 'Release', '-o', str(feed), '-m:1',
               '--verbosity', 'quiet', f'-p:DirectoryBuildTargetsPath={wrapper}',
               f'-p:MSBuildProjectExtensionsPath={local / "pack-obj-apple" / name}/',
               f'-p:RestoreConfigFile={config}', f'-p:LocalHybridPackageVersion={version}',
               f'-p:WisejVersion={version}', '-p:SdmVersion=4.1.4', '-p:BuildInParallel=false']
    print(f'Packing {name}: {", ".join(frameworks)}', flush=True)
    log = logs / (name + '-apple-pack.log')
    with log.open('w') as output:
        result = subprocess.run(command, cwd=root, stdout=output, stderr=subprocess.STDOUT)
    if result.returncode:
        print('\n'.join(log.read_text().splitlines()[-30:]), flush=True)
        sys.exit(result.returncode)
(local / 'LocalHybrid.props').write_text(f'<Project><PropertyGroup><LocalHybridPackageVersion>{version}</LocalHybridPackageVersion></PropertyGroup></Project>')
print(f'Apple feed ready: {feed}', flush=True)
