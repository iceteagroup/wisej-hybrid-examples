# Local Hybrid validation — 2026-09-28

Package version: `4.1.4-local.20260928.1`.

The ten local packages were built from these source revisions:

- Hybrid: `588666ae443ce749d4c3607949ccb9ddf7621c73`
- Hybrid Extensions: `70b331a0b340a2daa91960b4fcb2c767397fb959`

Both source checkouts were clean. The packaging overlay selects Wisej.NET and
Managed.System.Drawing 4.1.4, replaces Hybrid source references with the local
packages, and includes the Hybrid MSBuild asset targets. NuGet asset files were
checked to ensure that every Hybrid dependency resolved to the local package
version, rather than a published package or project reference.

| Example | Android build | iOS simulator build/startup | Windows build |
| --- | --- | --- | --- |
| Authentication | Passed | Passed | Passed |
| DocumentScanner | Passed | Passed | Not targeted |
| DynamicUpdates | Passed | Passed | Passed |
| ExternalApps | Passed | Passed | Not targeted |
| Flashlight | Passed | Passed | Not targeted |
| LocalDatabase | Passed | Passed | Passed |
| Navigation | Passed | Passed | Passed |
| NetworkEvents | Passed | Passed | Not targeted |
| PlatformCode | Passed | Passed | Not targeted |
| RemoteWebApi | Passed | Not targeted | Not targeted |
| Shortcuts | Passed | Passed | Not targeted |
| Showcase | Passed | Passed | Passed |

Android and Windows were built on Windows with .NET SDK 9.0.311. iOS and Mac
Catalyst packages were built on Apple Silicon with SDK/workload set 9.0.311 and
Xcode 26.0. iOS apps used ad hoc signing and an isolated iOS 26.0 simulator.
Startup checks installed each app and confirmed its process remained alive.
Windows checks were full builds; they did not launch each Windows app.

Build validation found two compatibility changes included in this repository:
DocumentScanner requires Android API 23 for its current AndroidX dependencies,
and Navigation needs designer serialization metadata for .NET 9.

Showcase was installed on a Mesa MS3A Android tablet. A physical barcode scan
exposed a queued asynchronous callback while the page's busy loader was active.
Releasing that callback recovered the scanned value. The example now uses the
modal barcode API so scanner completion participates in the server's modal loop.
The revised Android app opened the native scanner and returned from cancellation
with the page responsive, no busy loader, and an empty event queue in an emulator.
Reinstallation on the tablet remains pending because its USB debugging connection
dropped repeatedly during deployment; a fresh physical scan must still be checked.

These checks do not constitute exhaustive hardware, authentication-provider,
remote-server, or UI testing. Builds retain existing platform and obsolete-API
warnings. Mac Catalyst package assets were built; example apps do not target it.

Generated packages, manifests, build logs, screenshots, and JSON reports are kept
under the ignored `.local-nuget` directory. The merged `combined-feed` contains
Windows, Android, iOS, and Mac Catalyst assets; `CombinedFeed.zip` is a portable
copy. See the repository README for commands to reproduce the packages and builds.
