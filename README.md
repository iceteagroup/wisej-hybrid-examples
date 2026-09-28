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
