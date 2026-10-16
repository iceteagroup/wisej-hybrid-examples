# Wisej.NET Hybrid 4.1 examples

These examples use Wisej.NET and Hybrid 4.1.4, .NET 9, and MAUI 9.0.120.
Existing .NET Framework 4.8 targets remain available for the shared and web projects.
The repository's `global.json` selects a .NET 9 SDK. Showcase's Android app
targets `net10.0-android36.0` with MAUI 10.0.20; run its build from `Showcase`
to select the scoped .NET 10 SDK. Its other platform targets retain .NET 9
and MAUI 9.0.120.

Install the .NET 9 SDK and the workloads needed for your target platforms.
Open an example's solution to restore and build it. iOS builds require a Mac
with the matching Apple tools and signing configuration.

For the Android-only Showcase release build, install a stable .NET 10 SDK and
Android workload with API 36 support, then use `build/Build-ShowcaseAndroid.ps1`
with isolated `-HybridRoot` and `-ExtensionsRoot` source directories. This script
prunes restore to Android, uses short per-project intermediate paths, and keeps
the dependencies' existing .NET 9 targets and Wisej package IDs. See
[Android release validation](build/ANDROID-COMPLIANCE.md) for prerequisites,
artifact checks, and outstanding release gates.

## Local source dependencies

Authentication uses the 4.1 Authentication extension projects because the
Authentication NuGet packages have no published 4.1 release. Keep the sibling
checkout at `../../Hybrid Extensions/4.1` relative to this repository.
Its project references explicitly select Wisej 4.1.4 dependencies.

Showcase also uses the sibling `../../Hybrid/4.1` and
`../../Hybrid Extensions/4.1` source checkouts. Its paths can be overridden with
the `HybridSourceRoot` and `HybridExtensionsSourceRoot` MSBuild properties, as
defined in `Showcase/Directory.Build.props`.

For example, from this repository:

```powershell
dotnet restore Authentication/Wisej.Hybrid.Authentication.sln
dotnet build Authentication/HybridClient/HybridClient.csproj -f net9.0-android -m:1 -p:BuildInParallel=false
```

## Test source-built Hybrid packages

Use a Windows Visual Studio developer shell with .NET 9, the Hybrid workloads,
and `nuget.exe` available. Build from the matching Hybrid and Extensions checkouts:

```powershell
./build/Build-LocalHybrid.ps1 -HybridRoot 'PATH/Hybrid/4.1' -ExtensionsRoot 'PATH/Hybrid Extensions/4.1'
./build/Test-LocalHybrid.ps1 -Examples Showcase -Platform Windows
```

The builder calls each repository's release pack script and original NuSpec files.
It produces a local feed with the existing package IDs and records package hashes
in `.local-nuget/manifest.json`. Runtime and Scanning stay inside Native/MLKit.
Missing platform assets fail the build; partial feeds and separate Runtime/Scanning
packages are not created. Nothing is published.

The test helpers replace source references with these packages and check the
resolved versions. Logs are under `.local-nuget/logs`. Restore again when switching
between source and package builds. Use a short checkout path to avoid Android
toolchain path limits.

For Apple tests, copy `.local-nuget/feed`, `NuGet.Config`, `LocalHybrid.props` and
`manifest.json` to the same relative locations on the Mac. Use .NET SDK/workload
set 9.0.311 and Xcode 26.0:

```sh
python3 build/Test-LocalHybrid.Apple.py VERSION Showcase
python3 build/Test-LocalHybrid.Apple.py VERSION Showcase --platform MacCatalyst
```

These are build checks. Camera recognition, permissions, navigation and other
device features still require runtime tests.

See [the compatibility report](build/COMPATIBILITY.md) for the `.10` package audit
and tests of unchanged 4.0 sample source. The [validation history](build/VALIDATION.md)
records earlier Showcase/platform checks. The corrected `.10` portable feed
supersedes the invalid merged `.9` archive.

## Showcase integrations

Showcase creates demos when opened and releases their native subscriptions when
they close or become inactive. Its media handlers call `Device.Media` async
methods directly. Images are disposed with their preview; video previews support
HTTP byte ranges for playback and seeking.

The existing host is retained. Screen recording uses native Android, Windows,
and Apple APIs. The Screen demo checks availability, records without microphone
audio, and previews completed MP4 files. Windows microphone recording is currently
unsupported; the Hybrid API reports that explicitly. See the Hybrid repository's
README for recording limits, cancellation behavior, and image ownership.
