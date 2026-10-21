#requires -Version 7.0
param(
    [Parameter(Mandatory)][string]$HybridRoot,
    [Parameter(Mandatory)][string]$ExtensionsRoot,
    [string]$Version = ('4.2.0-local.' + (Get-Date -Format 'yyyyMMddHHmmss')),
    [string]$WisejVersion = '4.2.*-*',
    [string]$MSBuild = 'MSBuild.exe',
    [string]$NuGet = 'nuget.exe',
    [string]$PackageRoot,
    [string]$FrameworkFeed
)

$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$HybridRoot = (Resolve-Path -LiteralPath $HybridRoot).Path
$ExtensionsRoot = (Resolve-Path -LiteralPath $ExtensionsRoot).Path
$local = Join-Path $root '.local-nuget'
$feed = Join-Path $local 'feed'
$logs = Join-Path $local 'logs'
New-Item -ItemType Directory -Force -Path $feed, $logs | Out-Null
$config = Join-Path $local 'NuGet.Config'
@'
<configuration><packageSources><clear />
  <add key="Local Hybrid" value="feed" />
  <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
</packageSources></configuration>
'@ | Set-Content -LiteralPath $config -Encoding utf8
if ($FrameworkFeed) {
    [xml]$settings = Get-Content -Raw $config
    $source = $settings.CreateElement('add')
    $source.SetAttribute('key', 'Local Wisej framework')
    $source.SetAttribute('value', (Resolve-Path -LiteralPath $FrameworkFeed).Path)
    [void]$settings.configuration.packageSources.AppendChild($source)
    $settings.Save($config)
}

$properties = @('-restore', '-m:1', '-v:minimal', '-p:Configuration=Release',
    '-p:BuildInParallel=false', "-p:RestoreConfigFile=$config")
if ($PackageRoot) { $properties += "-p:RestorePackagesPath=$PackageRoot" }

# Use the same staged assets, manifests and pack entry points as release builds.
# Runtime and Scanning remain payloads of the existing Native/MLKit packages.
& $MSBuild (Join-Path $HybridRoot 'Wisej.Hybrid.sln') @properties "-p:WisejVersion=$WisejVersion" *> (Join-Path $logs 'Hybrid-build.log')
if ($LASTEXITCODE) { throw "Hybrid build failed. See $logs/Hybrid-build.log" }
& (Join-Path $HybridRoot 'build/Pack.ps1') -Version $Version -WisejVersion $WisejVersion -OutputDirectory $feed -NuGet $NuGet *> (Join-Path $logs 'Hybrid-pack.log')

& $MSBuild (Join-Path $ExtensionsRoot 'Wisej.Hybrid.Extensions.sln') @properties "-p:WisejVersion=$WisejVersion" "-p:HybridPackageVersion=$Version" `
    "-p:HybridScanningProject=$(Join-Path $HybridRoot 'Wisej.Hybrid.Scanning/Wisej.Hybrid.Scanning.csproj')" *> (Join-Path $logs 'Extensions-build.log')
if ($LASTEXITCODE) { throw "Extensions build failed. See $logs/Extensions-build.log" }
& (Join-Path $ExtensionsRoot 'build/Pack.ps1') -Version $Version -OutputDirectory $feed -NuGet $NuGet *> (Join-Path $logs 'Extensions-pack.log')

function Get-Revision([string]$path) {
    if (Test-Path (Join-Path $path '.git')) { & git -C $path rev-parse HEAD }
}
$manifest = [ordered]@{
    version = $Version
    wisejVersion = $WisejVersion
    hybridCommit = Get-Revision $HybridRoot
    extensionsCommit = Get-Revision $ExtensionsRoot
    packageLayout = 'release-nuspec'
    packages = @(Get-ChildItem -LiteralPath $feed -Filter "*.$Version.nupkg" | ForEach-Object {
        @{ file = $_.Name; sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash }
    })
}
$manifest | ConvertTo-Json -Depth 5 | Set-Content (Join-Path $local 'manifest.json') -Encoding utf8
"<Project><PropertyGroup><LocalHybridPackageVersion>$Version</LocalHybridPackageVersion></PropertyGroup></Project>" |
    Set-Content (Join-Path $local 'LocalHybrid.props') -Encoding utf8
Write-Host "Local release-layout feed ready: $feed ($Version)"
