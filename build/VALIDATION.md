# Local Hybrid validation — 2026-09-28

Initial upgrade validation package version: `4.1.4-local.20260928.1`.

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
Releasing that callback recovered the scanned value. This led to a Hybrid bridge
fix in `16b9644faa1cc0c0821b2955bb3d47000ee68534`, with no changes to Wisej.NET
source. Hybrid now correlates asynchronous responses itself and delivers native
completion events through the existing event transport even while UI events wait
behind the loader. Modal completion also preserves preceding Hybrid notifications
so startup device information arrives before initialization resumes. Showcase uses
`ScanBarcodeAsync` again; the temporary synchronous workaround is removed.

The final candidate packages use version `4.1.4-local.20260928.4`, built from that
Hybrid commit and the same Extensions revision listed above. Eight JavaScript
regression tests passed, including busy completion, concurrent requests, camel-case
serialization, reconnect/replay, errors, and modal notification ordering. The C#
request tracker checks passed on both .NET 9 and .NET Framework 4.8.

Against the final candidate, Showcase passed full Android, Windows, and iOS
simulator builds. All eleven other Android examples passed compilation and local
dependency checks. Showcase launched on the iOS simulator and rendered its
integration list. The complete example build/startup matrix above records the
initial upgrade validation, not a repeat of every platform on the final candidate.

The final Android APK was installed on a test emulator without any live bridge
patches. Startup completed, then `ScanBarcodeAsync` opened the native scanner.
With its request pending (`-1`), the busy loader was explicitly activated. Closing
the scanner completed the async call, re-enabled the page, and left `busy=false`
with an empty event queue. Evidence is saved in `logs/async-final-before.json`,
`logs/async-final-after.json`, and `logs/Hybrid-async-final.png` under `.local-nuget`.

Reinstallation on the tablet remains pending because its USB debugging connection
is offline; a fresh physical barcode scan must still be checked.

These checks do not constitute exhaustive hardware, authentication-provider,
remote-server, or UI testing. Builds retain existing platform and obsolete-API
warnings. Mac Catalyst package assets were built; example apps do not target it.

Generated packages, manifests, build logs, screenshots, and JSON reports are kept
under the ignored `.local-nuget` directory. The merged `combined-feed` contains
Windows, Android, iOS, and Mac Catalyst assets; `CombinedFeed.zip` is a portable
copy of the initial packages. The final candidate feed is `combined-feed-final`
and its portable archive is `CombinedFeedFinal.zip`. See the repository README
for commands to reproduce the packages and builds.
