# Hybrid 4.2 Framework desktop acceptance

The isolated examples source branch is based on `00205183d6535dde4e6d28ffc4fb4070ca4c29c5` (`fix/showcase-desktop-release-20261016`) in `iceteagroup/Wisej-Hybrid-Examples`. Its original 4.0 checkout and existing 4.1 release worktree were preserved. The new worktree is on C: because H: ran out of space.

The verified package set uses Hybrid **4.2.0-test.20261021.3**, and separately built Wisej-4/Managed.System.Drawing **4.2.0-test.20261021.1**. These are local test packages, not published stable packages. Existing non-Hybrid UI extensions remain at 4.1.4. All Hybrid package references in the feature branch use `$(HybridPackageVersion)`, defaulting to `4.2.*-*`; Wisej uses the independent `$(WisejVersion)` property. Mobile target lists are retained.

## Actual results

All thirteen application/server projects in the eleven retained examples built for net48 against the coherent candidate package set, including both Showcase variants and the RemoteWebApi backend. The package-only x64 desktop acceptance client also built with zero warnings/errors. The selected-runtime-asset audit covers fourteen project outputs and found zero hash mismatches.

| Existing application | Actual Windows net48 result | Limits |
| --- | --- | --- |
| Showcase online | Real server/WebView2 session, navigation, truthful WinForms device information, preferences save/native alert, native file write, document cancellation/reopen and physical camera capture returned to the real Image Preview. Production browser JavaScript/native image callback returned QR contents/bounds and the correlated corrupt-image error. | QR pixels are a generated fixture; this is not a physical barcode-camera decoding test. Unsupported native cards are disabled with a reason. |
| Showcase offline application | Actual application code rendered through the Framework server and WebView2. | Hosted through isolated IIS Express; this does not verify an integrated Framework embedded/offline server or offline fallback. |
| Navigation | Signup, native preference persistence, Home and Return to Login. | Sample workflow; its existing password-validation TODO is unchanged. |
| LocalDatabase | Actual SQLite initialization, Add User/grid refresh, and a second session reopening the saved row. | Local test data only. IIS fixture redirects the actually selected System.Memory assembly and disables managed shadow-copy so SQLite finds its native payload. |
| PlatformCode | Actual machine model and owned native Welcome/Hello/OK dialog. | iOS/Android branches retained. |
| RemoteWebApi | Actual Save Data/Fetch Data through the original sample's net48 API backend, both on loopback. | The old development tunnel was not contacted. Set `HYBRID_REMOTE_API_URL` to use another backend. |
| Authentication | Actual server/session/UI startup. | Native authentication is unsupported by the Framework adapter; no biometric or provider authentication claimed. |
| DocumentScanner | Actual standalone UI startup; its public scanner protocol is also exercised by the Showcase camera/cancellation flow. | Camera permission was already Allow; no permission changes were made. |
| ExternalApps | Actual server/session/UI startup. | Lyft/Maps/Facebook were not launched. |
| Flashlight | Actual server/session/UI startup. | Desktop torch control is unsupported. |
| NetworkEvents | Actual server/session/UI startup, displaying Unknown access. | No implemented desktop networking provider/change-event acceptance claimed. |
| Shortcuts | Actual server/session/UI startup. | Native application shortcuts are unsupported by this host. |

Showcase camera acceptance returned a 1280x720 JPEG (19,129 bytes in the final coherent run). The harness exported no captured frame file and took no screenshot of the hardware image. Normal isolated WebView user-data/cache folders are retained. Physical USB/Bluetooth transfers, packaged OCR, authentication, notifications, NFC, Mesa, embedded mobile MLKit UI, ARM execution and Windows Server are outside this evidence.

## Fixes exposed by live acceptance

* The core WebView2 sender accessed COM from a worker before checking `InvokeRequired`; the actual image callback reproduced this and the integration owner fixed the sender before candidate3.
* Framework Showcase Device Info now binds implemented System fields instead of eagerly calling the unported Display.KeepOn API.
* Framework feature availability enables document capture and disables unavailable native demos with an explicit caption; modern host rules are retained.
* The SQLite dependency is pinned to the consistent 1.9.172/2.1.2 set instead of a wildcard that selected incompatible major native components. Its shared service registers once rather than failing when another session starts.
* PlatformCode excludes MAUI on net48 and uses real desktop information/alert APIs for that target.
* The API endpoint can be overridden for isolated tests; its System.Web backend resolves data inside the hosted application instead of C:\data.txt.

## Reproducing the package-only checks

Use the repository's installed SDK toolchain, .NET Framework 4.8 targeting pack, WebView2 Evergreen runtime and an isolated NuGet configuration containing the candidate feeds plus nuget.org. Keep generated outputs/caches on a volume with adequate space. With Visual Studio desktop MSBuild, use the installed SDK9 resolver for net48 resource compilation; no machine-wide SDK or permission change is required.

Build the application/server projects with `TargetFrameworks=net48`, `UseLocalHybridPackages=true`, `HybridPackageVersion=4.2.0-test.20261021.3`, `LocalHybridPackageVersion` set to the same value, `WisejVersion=4.2.0-test.20261021.1`, and an isolated `RestorePackagesPath`/`RestoreConfigFile`. Build `tests/Net48DesktopAcceptance/Net48DesktopAcceptance.csproj` with the same properties. It consumes packages rather than source project references.

Host the original net48 applications in dedicated loopback IIS Express sites, staging each project's actual net48 CopyLocal output. Use the application's HTML/JSON entry point and normal Wisej HttpModule/HttpHandler configuration. For the SQLite IIS fixture, derive the System.Memory redirect from the staged assembly; the final selected `System.Memory/4.6.3` runtime is `lib/net462/System.Memory.dll`, assembly **4.0.5.0**, SHA256 **d5e8e4866f9cfa66f7765660f84b210198893e55335487afe5ebda342c0e913d**. Set `hostingEnvironment shadowCopyBinAssemblies="false"` only in this fixture so native SQLite loads beside its actual managed package.

Run the acceptance executable with `URL`, application mode (`Showcase`, `Navigation`, `LocalDatabase`, `LocalDatabaseReopen`, `PlatformCode`, `RemoteWebApiFlow`, or the app name for startup), and a fresh result directory. `Showcase` checks the actual image bridge and native flows. Add `--camera` only when existing camera access is already granted; otherwise document cancellation is tested. Each run writes a JSON report and startup screenshot, and keeps application preferences/files in its result folder.

The original ShowcaseTests project tests playwright.dev rather than this application. It is not counted as Showcase validation.

## Evidence retained on the validation machine

The local task's `showcase42` folder contains `candidate3-builds.json`, `startup-matrix-final3.json`, `final3-selected-assets.json`, `localdatabase3-assembly-inventory.json`, full build/server logs, and per-app result directories. The strongest flow reports are `results/showcase-final3`, `results/navigation-final3`, `results/localdatabase-final3c`, `results/localdatabase-reopen-final3`, `results/platformcode-final3`, `results/remotewebapi-final3-flow`, and `results/baseline-final3` (the separate minimal real server event/native bridge probe; both real buttons passed against final candidate3).

Startup-only rows must not be interpreted as end-to-end support for their unported native APIs. No production deployment, paid service, stable package publication, security-permission change or public announcement was part of these tests.
