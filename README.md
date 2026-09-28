# Wisej.NET Hybrid 4.1 examples

These examples use Wisej.NET and Hybrid 4.1.4, .NET 9, and MAUI 9.0.120.
Existing .NET Framework 4.8 targets remain available for the shared and web projects.
The repository's `global.json` selects a .NET 9 SDK.

Install the .NET 9 SDK and the workloads needed for your target platforms.
Open an example's solution to restore and build it. iOS builds require a Mac
with the matching Apple tools and signing configuration.

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

Build DynamicUpdates through its solution when producing its distribution
folder; the shared project's distribution step uses `SolutionDir`.

## Test source-built Hybrid packages

From this repository on Windows:

```powershell
./build/Build-LocalHybrid.ps1
./build/Test-LocalHybrid.ps1
./build/Test-LocalHybrid.ps1 -Platform Windows
```

The builder produces ten packages from the sibling Hybrid and Hybrid Extensions
4.1 checkouts in `.local-nuget/feed`, with a unique `4.1.4-local.<timestamp>`
version. It records source commits and package hashes in `.local-nuget/manifest.json`.
The generated `.local-nuget/NuGet.Config` adds this feed alongside nuget.org.
No packages are published to nuget.org or GitHub Packages.

`Test-LocalHybrid.ps1` opts into `UseLocalHybridPackages=true`, replaces Hybrid
project references with package references, verifies resolved versions, and builds
each supported example. Results and logs are under `.local-nuget`. Use
`-Examples Authentication,Showcase` to select examples or `-CompileOnly` for a
Android compilation check without app packaging. Normal builds retain their regular
references. Restore again when switching between normal and local-package builds.

On a Mac, use .NET SDK/workload set 9.0.311 with Xcode 26.0 for the current
camera APIs. Copy the same source revisions and use the Windows feed's version:

```sh
python3 build/Build-LocalHybrid.Apple.py '../../Hybrid/4.1' '../../Hybrid Extensions/4.1' VERSION
python3 build/Test-LocalHybrid.Apple.py VERSION
python3 build/Test-LocalHybrid.Apple.py VERSION Showcase --platform MacCatalyst
```

The Apple builder creates iOS and Mac Catalyst package assets. The test script
builds ad hoc signed iOS simulator apps or the native Mac Catalyst Showcase on
Apple Silicon; RemoteWebApi is Android-only.
It does not exercise camera, authentication, or other device features automatically.
The local packaging overlay raises the Mac Catalyst minimum to 15.0 for the MAUI 9
toolchain and bypasses the extensions' Windows-only artifact staging commands.

To combine separately built Windows and Apple feeds, use a new output directory:

```sh
python3 build/Merge-LocalHybrid.py WINDOWS_FEED APPLE_FEED COMBINED_FEED
```

Both inputs must contain only the matching package version from the same source
revisions; copy the selected version to separate staging folders when a feed
contains older builds. Package restores use isolated intermediate folders to
avoid interference from IDE restores of the source projects. If you
already restored that version before merging, clear only those local-version
Hybrid packages from the NuGet cache before restoring the combined packages.

See [the validation record](build/VALIDATION.md) for the tested source revisions,
platform results, and runtime coverage.

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
