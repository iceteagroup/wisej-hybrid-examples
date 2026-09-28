# Hybrid 4.1 compatibility validation — 2026-09-28

The full migration matrix below uses **`4.1.4-local.20260928.10`**.
The final follow-up candidate is **`4.1.4-local.20260928.11`**; its focused
checks are reported separately below.
The migration checks use committed
4.0 examples at `14c74938787ff3bed6ef8d35b79ff7a89e34c95a`, with original C#
source hashes verified unchanged. Project settings, package versions and test
identities were adjusted. DynamicUpdates was removed from the 4.1 branch and
excluded from the retained sample matrix; that removal is pushed to GitHub.

A subsequent user check found a Navigation return-path exception on Windows.
The build/startup matrix below does not imply every interaction passed. The
4.1 sample correction and its separate round-trip tests are described below.

The candidate preserves the matched public 4.1 assembly APIs. This is evidence
for the tested upgrade paths, not a guarantee that every customer application,
hardware integration or OS version is unaffected.

## Results

| Check | Candidate and result |
| --- | --- |
| Public assembly API comparison against 4.1 | `.10`: **40/40 passed**, no omitted assemblies. Authentication uses its published 4.0.11 baseline. |
| Public assembly API comparison against 4.0 | `.10`: **33/40 passed**; the remaining seven server assets expose the already-published `AppActions.Get()` return-type change described below. |
| Assembly identities | `.10`: all **80** matched name/version/public-key comparisons across both baselines passed. |
| Original server/shared projects | `.10`: **19/19** net48/plain-net9 builds passed with the settings below. |
| Original iOS samples | `.10`: **10/10** built, installed, remained running, returned HTTP 200 and displayed their original UI. |
| Original Windows targets | `.10`: **3/3** builds passed: Authentication, LocalDatabase and Navigation. |
| Original Windows runtime interactions | `.10`: all three rendered. Authentication returned `True`; the original database dialog saved a row and refreshed the grid. Navigation restored preferences and reached Home, but the user then encountered an exception returning to Login. The corrected 4.1 sample passes repeated round trips separately. Earlier `.9` additionally passed database deletion/restart persistence. |
| Original Android sample builds | `.10`: **11/11** full APK builds passed; all resolved Hybrid dependencies match `.10`. |
| Original Android emulator runtime | `.10`: **11/11** original UIs rendered, with selected authentication, navigation/preferences, native dialog/model, shortcuts and Showcase navigation interactions passing. No ANR occurred in the final clean emulator run. |
| Original Android Mesa runtime | Five sample checks passed; exact `.9`/`.10` coverage is listed below. |
| Current 4.1 Showcase on Mac Catalyst | `.10`: build, native process/window and local HTTP 200 passed. Visible interaction remains unverified because remote screen/accessibility access was unavailable. |
| Fresh-cache package-only server consumers | `.10`: net48 and net9 builds passed. The local net48 metadata warnings are explained below. |

RemoteWebApi has no original iOS target. None of the original 4.0 samples targets
Mac Catalyst; the Mac check uses the current 4.1 Showcase and is separate from
the unchanged-source migration matrix.

Retained application build coverage (`—` means no target in the original sample):

| Sample | Android | iOS | Windows |
| --- | --- | --- | --- |
| Authentication | Passed | Passed | Passed |
| DocumentScanner | Passed | Passed | — |
| ExternalApps | Passed | Passed | — |
| Flashlight | Passed | Passed | — |
| LocalDatabase | Passed | Passed | Passed |
| Navigation | Passed | Passed | Passed |
| NetworkEvents | Passed | Passed | — |
| PlatformCode | Passed | Passed | — |
| RemoteWebApi | Passed | — | — |
| Shortcuts | Passed | Passed | — |
| Showcase | Passed | Passed | — |

On iOS, original Showcase also opened App Info and returned to Integrations
through native simulator taps without a stuck loader. Simulator startup checks
do not certify camera/scanner/torch hardware, OAuth providers, external apps,
every integration action, or installed-app data/keychain migration.

RemoteWebApi's original hardcoded development-tunnel endpoint returned HTTP 404
during validation. Its remote save/get workflow requires a running backend and
an updated endpoint; startup alone cannot establish that workflow works. This
configuration was left unchanged in the pristine-source compatibility copy.

Physical Mesa coverage is deliberately identified by tested package version:

- `.9`: Authentication completed with a native `true` response; Navigation
  signed in and retained preferences after restart; NetworkEvents displayed
  Wi-Fi and Internet access.
- `.10`: DocumentScanner opened its native scanner and returned from both close
  and Android Back without a stuck loader, including reopening afterward.
  LocalDatabase opened the original modal dialog, saved a record, retained it
  after force-stop/relaunch, and deleted it successfully.

These are the original synchronous 4.0 callers. The Mesa checks cover five
representative samples; they are not an all-eleven physical-device matrix.

Initial emulator runs under concurrent host builds produced ANRs. After a cold
restart with 3 GB guest memory and all builds complete, each `.10` app was run
sequentially with the previous app stopped. All eleven displayed their original
UI, without fatal exceptions or ANRs. The initial traces remain recorded; this
does not establish a single root cause for the earlier emulator failures.

## Follow-up sample UI corrections

The original Navigation return path could select no non-busy view, then call
`GetType()` on null. It also used mutable display order as navigation history.
The 4.1 sample now keeps an explicit stack, waits for retained views' animations,
validates pop targets, and ignores events from inactive views. Hidden intermediate
views dispose directly; only the visible outgoing view animates. Five regression
cases link the actual `MainPage.cs`; all pass, while the committed 4.0 implementation
fails those same controlled cases. This proves an algorithm defect, not historical
runtime behavior. The published 4.0 package comparison's reverse UI test was
interrupted, so no historical runtime conclusion is made.

The corrected Windows copy passed repeated Login/Home/Login round trips,
including duplicate clicks. Strict sub-250 ms reverse timing is covered by the
controlled regression test, not claimed from Windows UI automation. The original
Android copy also passed two settled return trips; that does not rule out the
transition race. The corrected current 4.1 Android sample then passed four native
round trips, including rapid Return during Home's entrance, with no null-reference
or fatal exception. The pristine migration copies remain unchanged.

Current Showcase also received two small sample fixes: DeviceInfo now binds its
property grid to the existing System, Battery, Display and Networking objects;
SwitchView adds controls only when needed and puts the incoming view in front
before showing it. The shared view uses the theme's opaque window background.
Re-adding an existing child had sent it behind the outgoing animated menu. Before
the fix, native-frame Mesa recordings reproduced a roughly 35 ms menu overlay
between two Clipboard detail frames. Correcting only the display order left a
16 ms flash through the transparent detail background, which motivated the opaque
background correction. Windows displays real device values and passes
DeviceInfo/AppInfo reopen checks; its final opaque build also builds, installs
and displays the dark menu. Slow Windows snapshots do not establish absence of a
one-frame flicker. On Mesa, final native-frame recordings of Clipboard first
open, repeat open and dark-theme repeat contain no menu flash. DeviceInfo
first open and reopen show actual native values; no fatal or unhandled process
error was found in the final check.

The follow-up exposed a missing server-side display-density assignment. Hybrid
now copies the native density before notifying consumers. Regression tests link
the production source and verify repeated updates and event values under both
`en-US` and `fr-FR`; the original implementation fails. The StatusBar demo
also removes an inert visibility switch that had no matching native API, leaving
its supported color controls.

## Final follow-up candidate `.11`

Source snapshots: Hybrid `57959d5`, Extensions `22ff22aa`, Examples `01ece6f`
(including application fix commit `39cab3e`). Later report-only commits do not
change the tested application source. `.11` adds the density assignment and
local net48 metadata correction to `.10`; the current sample source also includes
the Navigation, view rendering, DeviceInfo and StatusBar corrections above.
The complete original-source migration matrix was not repeated on `.11`.

- Matched public 4.1 assembly APIs: **40/40 passed**; assembly identities:
  **40/40 preserved**. Authentication uses published 4.0.11. No assemblies were
  omitted. Known package-level platform-TFM/fallback diagnostics remain separate
  from this assembly-level result.
- Fresh-cache net48 and net9 consumers: **zero warnings and zero errors**.
- Actual-source density tests pass under `en-US` and `fr-FR` on Windows and Mac;
  all five Navigation regression cases pass.
- Current Showcase full Android and Windows builds pass; resolved Hybrid
  dependencies are exclusively `.11`. Windows `.11` was built separately and
  was not brought to the foreground; its prior UI coverage is described above.
- Current Showcase iOS and Mac Catalyst plus Navigation iOS builds pass against
  `.11`. The iOS Showcase displays DeviceInfo in light and dark themes with
  density `3`; current Navigation renders Login after startup settles.
- Mac Catalyst `.11` launches a native process/window and serves HTTP 200 over
  the VPN-connected Mac. Its visible UI interactions remain unverified because
  SSH screen capture/accessibility access is unavailable.
- Android emulator `.11`: DeviceInfo displays populated groups and density
  `2.625`; StatusBar shows its background/text color controls with the unsupported
  visibility switch absent; Clipboard opens and reopens with the bridge idle.
  No fatal or unhandled process error was found.
- Mesa disconnected from ADB before the `.11` installation and remained absent
  at the final check. **Final `.11` Mesa installation/density validation is pending
  USB reconnection.** The earlier opaque-background `.10` Mesa native-frame and
  populated DeviceInfo checks passed; they do not certify the later density fix
  on that physical tablet.

The final local archive is
`.local-nuget/CombinedFeed-4.1.4-local.20260928.11.zip` (2,657,621 bytes), SHA-256
`2b70b1173cb8a902ca06f14b3854bd121592102465147a6e1fd614b63caf054d`.
All ten merged packages preserve their platform-slice binary assets byte for
byte. The archive includes a relative NuGet.Config, source provenance and hashes;
`Combined.NuGet.Config` now selects `.11`. No packages were published.

## Compatibility repairs included in `.10`

- Media image decoding retains the original image format, metadata, resolution
  and frame behavior. Redrawing into a new bitmap had changed `RawFormat` on
  .NET Framework. Tests compare JPEG, PNG, GIF, TIFF and BMP saving, metadata,
  animated GIF and multipage TIFF behavior on net48 and net9 against the original
  decoding path. The managed encoded stream remains available for GDI+ deferred
  reads; callers still dispose returned images.
- Parameterless camera `GetFrameAsync()` methods are restored alongside the
  cancellation overloads. An optional parameter alone does not preserve the
  old binary method signature. The public iOS `ScanInternalAsync` adapter is
  also restored.
- MLKit packages again include the separate signed CameraPreview assembly that
  existed in published packages. The historical duplicate camera type names
  produce the same CS0433 error in unaliased direct consumers on public 4.0.14,
  public 4.1.4 and `.10`. Consumers using explicit assembly aliases compile
  against all three; both existing type/assembly identities are preserved.
- The platform-feed merger preserves the NuGet XML default namespace. The
  previous merged `.9` archive used prefixed metadata that NuGet could not read.
  Earlier tests of its original platform slices remain valid; they did not
  establish that the merged archive restored in a fresh cache.

## Existing migration requirements and package distinctions

**`Device.AppActions.Get()` returns `AppAction[]` in public 4.1.4; public 4.0.14
returned `AppAction`.** This is an existing 4.0-to-4.1 source/binary change, not a
change introduced by this cleanup. Affected callers must update and rebuild.
Returning the old type again would instead break existing 4.1 callers.

The unchanged-source matrix updates .NET 8 targets to .NET 9, Wisej.NET to
4.1.4, Hybrid packages to the candidate, and MAUI Controls to 9.0.120. Additional
build settings were needed:

- Server: LocalDatabase net48 uses `Platform=x64` and `PlatformTarget=x64`
  because its floating SQLite dependency now rejects AnyCPU. PlatformCode uses
  `LangVersion=latest` for MAUI 9 generated binding source.
- Windows: the new `WFO1000` designer analyzer was suppressed through a build
  property; application C# was not modified.
- iOS: simulator ad hoc signing, interpreter enabled, linking disabled and
  deployment minimum 15.0. The installed .NET 9/iOS 26 toolchain rejects the old
  iOS 11.0 minimum. These simulator settings do not certify production AOT/linking.
- Android: full APK builds embed assemblies for independent device installation;
  emulator-only APKs use `android-x64`. DocumentScanner and Showcase require
  runtime minimum API 23 for their native dependencies, above the original 21.

SDK-generated local package labels (Android35/iOS18/MacCatalyst18) differ from
the lower labels used by release nuspecs. Actual Android21/iOS14.2 consumer
projects fail with the same `NETSDK1140` error against public 4.0.14, public
4.1.4 and `.10` on the pinned SDK. Package API diagnostics remain recorded, but
this did not demonstrate a new failure of a previously working consumer.
Compile API targets are separate from runtime minimum OS support; Scanning
declares Android 23 and Mac Catalyst 15 minimums.

The local `.10` net48 package exposes a `System.Net.Http` dependency omitted
by the production nuspec. The local pack overlay now marks it private, and the
`.11` nuspec omits it. Final `.11` net48 and net9 consumers restore into a clean
sibling package cache and build with zero warnings and zero errors. An initial
audit placed the cache inside the consumer project, causing SDK default file
globs to include package files and produce misleading binding warnings; that
audit was replaced. The consumed `.10` archive is unchanged.

## Artifacts and repeatability

The preserved full-matrix `.10` archive is
`.local-nuget/CombinedFeed-4.1.4-local.20260928.10.zip` (2,659,214 bytes), SHA-256
`90af6a6fe0e9727f0b442cf5ceab92c6058b1e27f4f26b3d3b7c221cbb181d34`.
It supersedes the invalid merged `.9` archive. Its manifest records source
provenance, verifies all input hashes, and verifies merged binary assets remain
byte-identical to the original platform slices. External dependencies still
restore from nuget.org. No candidate packages were published.

Ignored local evidence includes:

- `.local-nuget/combined-manifest-review10.json` and `combined-manifest-review11.json`;
  `Combined.NuGet.Config` selects the final `.11` packages.
- `.local-nuget/apple11-evidence/Apple-Final11-Report.md` and
  `showcase-final11-android/results.json`: focused final application checks; `showcase-ui-windows/evidence/candidate11-build.json`
  records the final Windows build and source/dependency audit.
- `.local-nuget/results-server-compatibility40-v10.json`.
- `.local-nuget/compat40-apple10/Apple-Compatibility-Report.md` and `apple-evidence`.
- `.local-nuget/compat40-windows/results-final-windows.json` and
  `windows-runtime-final10/Windows-Compatibility-Report.md`.
- `.local-nuget/compat40-final-integrity.json`: all 345 original C# hashes remain
  unchanged in both Windows and Android copies; all tested hosts resolve only
  `.10` Hybrid package versions.
- `.local-nuget/compat40-android/results-final-*.json`: all eleven full APK builds;
  `compatibility-logs` contains their commands, output and warnings.
- `.local-nuget/compat40-android/results-Android-runtime-final10.json` and
  `runtime-apks/review10/manifest.json`: runtime coverage and APK hashes.
- `.local-nuget/navigation-roundtrip/evidence/Navigation-Roundtrip-Report.md`:
  corrected Windows sample; `tests/Navigation` contains the regression harness.
- `.local-nuget/navigation-roundtrip/android/README.md`: corrected actual 4.1
  Android sample round trips, screenshots, source/APK hashes and logs.
- `.local-nuget/showcase-ui-windows/evidence/Showcase-Windows-UI-Report.md` and
  `.local-nuget/showcase-flicker-mesa`: follow-up Showcase rendering evidence.
- The Hybrid checkout's `artifacts/compatibility-final`: package/API reports,
  identity comparisons, fresh-cache builds and lower-target comparisons.

`Prepare-Compatibility.py` creates a new copy from the committed 4.0 source and
records its original C# hashes. Hybrid's `tests/Compatibility/Compare-Packages.ps1`
compares published package and assembly APIs; it fails on missing requested
baselines rather than silently substituting another release. Platform builds
and runtime checks remain separate from that API gate.
