#requires -Version 7.0
param(
    [Parameter(Mandatory)][string]$HybridRoot,
    [Parameter(Mandatory)][string]$ExtensionsRoot,
    [string]$AndroidSdkDirectory,
    [string]$JavaSdkDirectory,
    [string]$NuGetConfig,
    [string]$PackageRoot
)

$ErrorActionPreference = 'Stop'
$repo = Split-Path $PSScriptRoot -Parent
$showcase = Join-Path $repo 'Showcase'
$HybridRoot = (Resolve-Path -LiteralPath $HybridRoot).Path.TrimEnd('\', '/') + [IO.Path]::DirectorySeparatorChar
$ExtensionsRoot = (Resolve-Path -LiteralPath $ExtensionsRoot).Path.TrimEnd('\', '/') + [IO.Path]::DirectorySeparatorChar
$local = Join-Path $repo '.local-nuget/android'
New-Item -ItemType Directory -Force -Path $local | Out-Null
if (!$PackageRoot) { $PackageRoot = Join-Path $local 'packages' }
# Short per-project intermediates avoid Windows aapt2 path limits. Existing obj/bin
# directories must stay excluded when changing BaseIntermediateOutputPath.
$hash = [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData([Text.Encoding]::UTF8.GetBytes($repo))).Substring(0, 8)
$intermediates = Join-Path ([IO.Path]::GetTempPath()) "wisej-a36-$hash"
$escape = { param($value) [Security.SecurityElement]::Escape($value) }
$props = Join-Path $local 'Android.props'
$targets = Join-Path $local 'Android.targets'
$showcaseProps = & $escape (Join-Path $showcase 'Directory.Build.props')
$showcaseTargets = & $escape (Join-Path $showcase 'Directory.Build.targets')
$extensionProps = & $escape (Join-Path $ExtensionsRoot 'Directory.Build.props')
$extensionTargets = & $escape (Join-Path $ExtensionsRoot 'Directory.Build.targets')
$extensionPrefix = & $escape $ExtensionsRoot.TrimEnd('\', '/')
$shortRoot = & $escape $intermediates
@"
<Project>
  <Import Project="$showcaseProps" Condition="'`$(MSBuildProjectName)' == 'HybridApp' Or '`$(MSBuildProjectName)' == 'FeaturesOffline' Or '`$(MSBuildProjectName)' == 'FeaturesShared'" />
  <Import Project="$extensionProps" Condition="`$(MSBuildProjectDirectory.StartsWith('$extensionPrefix')) And Exists('$extensionProps')" />
  <PropertyGroup>
    <BaseIntermediateOutputPath>$shortRoot/`$(MSBuildProjectName)/</BaseIntermediateOutputPath>
    <DefaultItemExcludes>`$(DefaultItemExcludes);bin/**;obj/**;.obj/**</DefaultItemExcludes>
  </PropertyGroup>
</Project>
"@ | Set-Content -LiteralPath $props -Encoding utf8
@"
<Project>
  <Import Project="$showcaseTargets" Condition="'`$(MSBuildProjectName)' == 'HybridApp' Or '`$(MSBuildProjectName)' == 'FeaturesOffline' Or '`$(MSBuildProjectName)' == 'FeaturesShared'" />
  <Import Project="$extensionTargets" Condition="`$(MSBuildProjectDirectory.StartsWith('$extensionPrefix')) And Exists('$extensionTargets')" />
  <PropertyGroup>
    <!-- Prune restore to Android while retaining each dependency's existing TFM. -->
    <TargetFrameworks Condition="'`$(MSBuildProjectName)' == 'HybridApp'">net10.0-android36.0</TargetFrameworks>
    <TargetFrameworks Condition="'`$(MSBuildProjectName)' != 'HybridApp'">net9.0-android</TargetFrameworks>
  </PropertyGroup>
</Project>
"@ | Set-Content -LiteralPath $targets -Encoding utf8
$properties = @(
    "-p:HybridSourceRoot=$HybridRoot", "-p:HybridExtensionsSourceRoot=$ExtensionsRoot",
    "-p:DirectoryBuildPropsPath=$props", "-p:DirectoryBuildTargetsPath=$targets",
    "-p:RestorePackagesPath=$PackageRoot",
    '-p:MauiVersion=9.0.120', '-p:BuildInParallel=false'
)
if ($AndroidSdkDirectory) { $properties += "-p:AndroidSdkDirectory=$AndroidSdkDirectory" }
if ($JavaSdkDirectory) { $properties += "-p:JavaSdkDirectory=$JavaSdkDirectory" }
$restoreArgs = @()
if ($NuGetConfig) { $restoreArgs += @('--configfile', (Resolve-Path -LiteralPath $NuGetConfig).Path) }
Push-Location $showcase
try {
    & dotnet restore 'App/HybridApp.csproj' @properties @restoreArgs --verbosity minimal *> (Join-Path $local 'restore.log')
    if ($LASTEXITCODE) { throw "Restore failed. See $local/restore.log" }
    & dotnet publish 'App/HybridApp.csproj' -c Release -f net10.0-android36.0 --no-restore -m:1 @properties --verbosity minimal *> (Join-Path $local 'publish.log')
    if ($LASTEXITCODE) { throw "Publish failed. See $local/publish.log" }
    Write-Host "Release artifacts: $showcase/App/bin/Release/net10.0-android36.0/publish"
    Write-Host 'Validate the unsigned AAB and generated APKs before selecting release signing or uploading.'
}
finally { Pop-Location }
