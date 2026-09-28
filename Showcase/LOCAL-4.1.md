# Showcase with local Hybrid 4.1 sources

This checkout builds against the local `Hybrid/4.1` and `Hybrid Extensions/4.1` source projects. `Directory.Build.props` assumes this examples repository is at `Wisej/Wisej/wisej-hybrid-examples`. If the repositories are elsewhere, pass `-p:HybridSourceRoot=...` and `-p:HybridExtensionsSourceRoot=...` with absolute paths ending in a directory separator.

The source project references replace the 4.0 Hybrid package binaries. The old transitive Hybrid packages are explicitly excluded from the app's compile and runtime assets, and `Directory.Build.targets` imports the source build targets that embed offline assets and MAUI resources.

For Windows, build the app and register its development layout once from PowerShell:

```powershell
dotnet restore Showcase/App/HybridApp.csproj
dotnet build Showcase/App/HybridApp.csproj -f net9.0-windows10.0.19041.0 -c Debug -p:AppxPackageSigningEnabled=false
Add-AppxPackage -Register Showcase/App/bin/Debug/net9.0-windows10.0.19041.0/win10-x64/AppxManifest.xml
$pkg = Get-AppxPackage -Name '949865ae-c5be-4b08-b7b9-9d524800ddd4'
Start-Process explorer.exe -ArgumentList ('shell:AppsFolder\' + $pkg.PackageFamilyName + '!App') -WindowStyle Hidden
```

Once registered, subsequent builds can launch the existing package registration without repeating `Add-AppxPackage`. The Windows app must be launched through the package identity; starting `HybridApp.exe` directly leaves the embedded server without its storage folder.

For Android, a standalone debug APK can be built with:

```powershell
dotnet build Showcase/App/HybridApp.csproj -f net9.0-android -c Debug -p:EmbedAssembliesIntoApk=true
```

The signed APK is emitted as `Showcase/App/bin/Debug/net9.0-android/com.iceteagroup.hybrid-Signed.apk`.