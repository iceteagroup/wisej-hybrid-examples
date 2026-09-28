# Local Hybrid validation — 2026-09-28

## Showcase and native integration cleanup

Final source package version: `4.1.4-local.20260928.9`.

- Hybrid: `4ed4427f4344e59a477cae6dd5a9e38e92a5e466`
- Hybrid Extensions: `587cb2b0e43cd6ee0b4d769ac87e9f8a17016ff9`
- Showcase implementation: `3690cf8`; isolated package restore scripts: `5c92caf`.

Both package source checkouts were clean. All ten merged packages were audited:
Wisej.NET dependencies resolve to 4.1.4, Hybrid dependencies to the local version,
and merged binary assets match the original Windows/Android and Apple slices.
The default Hybrid source project now also references Wisej.NET 4.1.4.
Separate restore directories prevent background IDE restores from changing the
package dependency metadata.
Extensions commit `f0f36704` subsequently aligns its normal build defaults with
Wisej.NET/Managed.System.Drawing 4.1.4. This changes only defaults: the tested
package build already supplied explicit version overrides, so its effective
dependencies and binaries are unchanged. The default properties were checked
with MSBuild evaluation; the package manifest retains its original source revision.

| Final candidate check | Result |
| --- | --- |
| Showcase full Android build | Passed |
| Other eleven Android examples, compilation and dependency audit | Passed |
| Showcase full Windows MSIX build and UI startup | Passed |
| Showcase full iOS simulator build and rendered Integrations | Passed |
| Showcase full Mac Catalyst build, native window and local server | Passed |
| Mac visual interaction | Awaiting manual confirmation; macOS denied remote accessibility and screenshots |
| Final Mesa scanner-to-recording regression | Passed |
| Final Android emulator startup and forced-busy scanner cancellation | Passed |
| Final Android emulator recording playback | Blocked by emulator host process exiting on stop/preview |

The Android emulator passed the final candidate's forced-busy barcode cancellation:
the native scanner closed, the result status updated, the loader cleared, and the
event queue emptied. Earlier candidate testing also exercised media cancellation,
screen recording, MP4 playback and HTTP byte ranges, and confirmed the native
accelerometer listener disappears after leaving its demo. Mesa testing reproduced
an embedded-server lifetime bug after native scanning: a short resume health probe
could cancel the listening server while an existing WebSocket remained alive.
The final candidate keeps the owned server alive until explicit stop or disposal.

On the final candidate, Mesa passed that scanner/resume/resize/recording sequence:
the forced loader cleared, fresh HTTP requests returned 200 throughout, and the
800×1280 recording played to completion (4.63 seconds). Video byte ranges returned
206 with the requested length. Photo/video picker cancellation, accelerometer
listener cleanup, and a 320px viewport without horizontal overflow also passed.
Physical barcode recognition was confirmed during the earlier loader fix; final
candidate testing used scanner cancellation. Successful camera capture and
microphone audio were not repeated in this final pass.

The final emulator recording reached the recording state, but the Windows
emulator host process exited on stop/preview. This reproduced with installed
emulators 33.1.23 and 35.3.11, including software graphics with Vulkan and hardware
decoding disabled. The latter cold boot also showed an application-not-responding
dialog, which recovered after selecting Wait. Final emulator playback is therefore
unverified; the earlier `.7` emulator playback pass and final `.9` physical Mesa
playback pass do not replace that missing check.

Windows final-candidate UI checks verified full WebView content in the native PNG
screenshot preview, closing the preview, and recording-picker cancellation with
restored controls. The unchanged recording backend also passed a nine-second
Showcase recording/playback flow on candidate `.7`. Focused native tests exercised
static-frame duration, native window-close notification, discard cleanup, delayed
encoder cleanup, and nonblank screenshot pixels. Windows runs as its normal MSIX
package; an unpackaged diagnostic launch cannot use Wisej.EmbedIO's package storage.

The Mac's duplicate JavaScript bridge registration crash was fixed by giving each
Apple WebView its own native configuration and removing handlers on detach. The
final Mac application remains open. iOS simulator and native Mac startup checks
ran separately because their embedded servers share host loopback port 5000.

Regression checks passed for eight JavaScript bridge cases, C# pending-request
tracking on .NET 9 and .NET Framework 4.8, 38 native dispatch cases, detached-image
ownership on both runtimes, 18 media-handler cases, 16 document-sizing cases,
20 video HTTP-handler cases plus empty-range parsing, and embedded-host lifetime
scenarios using an actual loopback HTTP server.

Coverage is limited to the checks above; authentication providers, every hardware
integration, and narrow native Windows resizing were not exhaustively exercised.
Windows microphone recording reports unsupported; resizing its capture source
ends recording. Apple system stops report `RecordingFailed`. Exported recordings
are limited to 32 MiB. Existing platform/obsolete-API build warnings remain.

Local deliverables are under `.local-nuget`:

- `combined-feed-4.1.4-local.20260928.9`: ten merged NuGet packages.
- `CombinedFeed-4.1.4-local.20260928.9.zip`: portable feed, manifest and configuration.
- `combined-manifest-review9.json`: provenance, per-platform assets and SHA-256 hashes.
- `Combined.NuGet.Config`: points to the final merged feed.
- `results-Android-Showcase-review9.json`, `results-Android-other-examples-review9.json`,
  `results-Mesa-review9.json`, `results-Windows-v9.json`, `results-Windows-runtime-v9.json`, and
  `apple-feed-review9/validation`: build and runtime evidence.

## Initial upgrade and busy-loader regression

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

The final APK was also installed and launched on the Mesa MS3A tablet. A fresh
physical barcode scan through `ScanBarcodeAsync` returned its value successfully,
confirmed by the user and by the WebView state: `Added 1 code(s). 1 total.`,
`busy=false`, and an empty event queue. Evidence is saved locally in
`logs/mesa-async-after.json` and `logs/mesa-final.png`. The tablet's USB debugging
connection remains intermittent, but reconnected for the post-scan capture.

These checks do not constitute exhaustive hardware, authentication-provider,
remote-server, or UI testing. Builds retain existing platform and obsolete-API
warnings. Mac Catalyst package assets were built; example apps do not target it.

Generated packages, manifests, build logs, screenshots, and JSON reports are kept
under the ignored `.local-nuget` directory. The merged `combined-feed` contains
Windows, Android, iOS, and Mac Catalyst assets; `CombinedFeed.zip` is a portable
copy of the initial packages. The final candidate feed is `combined-feed-final`
and its portable archive is `CombinedFeedFinal.zip`. See the repository README
for commands to reproduce the packages and builds.
