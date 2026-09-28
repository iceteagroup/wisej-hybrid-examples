param(
    [string]$HybridRoot,
    [string]$ExtensionsRoot,
    [string]$Version = ('4.1.4-local.' + (Get-Date -Format 'yyyyMMddHHmmss')),
    [ValidateSet('Android', 'Windows')][string[]]$Platforms = @('Android', 'Windows')
)

$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
if (!$HybridRoot) { $HybridRoot = Join-Path $root '../../Hybrid/4.1' }
if (!$ExtensionsRoot) { $ExtensionsRoot = Join-Path $root '../../Hybrid Extensions/4.1' }
$HybridRoot = (Resolve-Path -LiteralPath $HybridRoot).Path
$ExtensionsRoot = (Resolve-Path -LiteralPath $ExtensionsRoot).Path
$local = Join-Path $root '.local-nuget'
$feed = Join-Path $local 'feed'
$logs = Join-Path $local 'logs'
New-Item -ItemType Directory -Force -Path $feed, $logs | Out-Null
$config = Join-Path $local 'NuGet.Config'
$escapedFeed = [System.Security.SecurityElement]::Escape($feed)
@"
<configuration>
  <packageSources>
    <clear />
    <add key="Local Hybrid" value="$escapedFeed" />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
  </packageSources>
</configuration>
"@ | Set-Content -LiteralPath $config -Encoding utf8

$projects = @(
    (Join-Path $HybridRoot 'Wisej.Hybrid.Runtime/Wisej.Hybrid.Runtime.csproj'),
    (Join-Path $HybridRoot 'Wisej.Hybrid.Scanning/Wisej.Hybrid.Scanning.csproj'),
    (Join-Path $HybridRoot 'Wisej.Hybrid/Wisej.Hybrid.csproj'),
    (Join-Path $HybridRoot 'Wisej.Hybrid.Native/Wisej.Hybrid.Native.csproj')
)
foreach ($extension in @('Authentication', 'DocumentScanner', 'MLKit')) {
    foreach ($suffix in @('', '.Native')) {
        $name = "Wisej.Hybrid.$extension$suffix"
        $projects += Join-Path $ExtensionsRoot "$extension/$name/$name.csproj"
    }
}

Push-Location $root
try {
    foreach ($project in $projects) {
        $name = [IO.Path]::GetFileNameWithoutExtension($project)
        $frameworkOutput = & dotnet msbuild $project -getProperty:TargetFrameworks -verbosity:quiet
        if ($LASTEXITCODE -ne 0) { throw "Cannot evaluate $project" }
        $frameworks = @($frameworkOutput.Trim().Split(';') | Where-Object {
            $_ -eq 'net48' -or $_ -eq 'net9.0' -or
            ($Platforms -contains 'Android' -and $_ -eq 'net9.0-android') -or
            ($Platforms -contains 'Windows' -and $_ -like 'net9.0-windows*')
        })
        if (!$frameworks.Count) { continue }
        $wrapper = Join-Path $local "$name.targets"
        $originalTargets = if ($project.StartsWith($ExtensionsRoot)) { Join-Path $ExtensionsRoot 'Directory.Build.targets' } else { '' }
        $originalImport = if ($originalTargets -and (Test-Path -LiteralPath $originalTargets)) {
            '<Import Project="' + [Security.SecurityElement]::Escape($originalTargets) + '" />'
        } else { '' }
        $packTargets = [Security.SecurityElement]::Escape((Join-Path $PSScriptRoot 'LocalHybrid.Pack.targets'))
        ('<Project>{0}<PropertyGroup><TargetFrameworks>{1}</TargetFrameworks></PropertyGroup><Import Project="{2}" /></Project>' -f $originalImport, ($frameworks -join ';'), $packTargets) |
            Set-Content -LiteralPath $wrapper -Encoding utf8
        $properties = @(
            "-p:LocalHybridPackageVersion=$Version",
            "-p:WisejVersion=$Version", '-p:SdmVersion=4.1.4',
            "-p:DirectoryBuildTargetsPath=$wrapper",
            "-p:RestoreConfigFile=$config", '-p:BuildInParallel=false'
        )
        $log = Join-Path $logs "$name-pack.log"
        Write-Host "Packing $name ($($frameworks -join ', '))"
        & dotnet pack $project -c Release -o $feed -m:1 --verbosity quiet @properties *> $log
        if ($LASTEXITCODE -ne 0) {
            Get-Content -LiteralPath $log -Tail 30 | Write-Host
            throw "Package build failed: $name. See $log"
        }
    }
    $manifest = [ordered]@{
        version = $Version
        platforms = $Platforms
        hybridCommit = (& git -C $HybridRoot rev-parse HEAD)
        extensionsCommit = (& git -C $ExtensionsRoot rev-parse HEAD)
        hybridDirty = [bool](& git -C $HybridRoot status --porcelain)
        extensionsDirty = [bool](& git -C $ExtensionsRoot status --porcelain)
        packages = @(Get-ChildItem -LiteralPath $feed -Filter "*.$Version.nupkg" | ForEach-Object {
            @{ file = $_.Name; sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash }
        })
    }
    $manifest | ConvertTo-Json -Depth 5 | Set-Content (Join-Path $local 'manifest.json') -Encoding utf8
    "<Project><PropertyGroup><LocalHybridPackageVersion>$Version</LocalHybridPackageVersion></PropertyGroup></Project>" |
        Set-Content (Join-Path $local 'LocalHybrid.props') -Encoding utf8
    Write-Host "Local feed ready: $feed ($Version)"
}
finally { Pop-Location }
