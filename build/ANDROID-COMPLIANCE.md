# Showcase Android release candidate — 2026-10-01

This is a draft release candidate, with binary checks and limited emulator tests.
It is not a Play rollout or approval to broaden permissions.

The Android application targets `net10.0-android36.0` and MAUI 10.0.20.
Existing iOS, Mac Catalyst and Windows targets retain .NET 9 / MAUI 9.0.120.
Wisej 4.1.4 contracts, package IDs, and source references are retained. Android
code 40 / version 1.3.5 exceeds the console inventory's maximum 39 checked on
2026-10-01; recheck every uploaded artifact before any final upload.

Production 39's reported offenders were `libbarhopper_v3.so` and
`libmlkit_google_ocr_pipeline.so`, for arm64-v8a and x86_64. The application now
pins the existing package IDs `Xamarin.Google.MLKit.BarcodeScanning` 117.3.0.7
and `Xamarin.Google.MLKit.TextRecognition` 116.0.1.7. These resolve Google's
barcode 17.3.0 and bundled text-recognition 16.0.1 binaries. Google's
[ML Kit release notes](https://developers.google.com/ml-kit/release-notes)
identify the August 7, 2024 updates as adding 16 KB support.

## Reproduce

Use PowerShell 7 and stable .NET 10 with Android API 36 tooling. The verified environment used
SDK 10.0.401, Android workload 36.1.69, SDK/build-tools 36.0.0, JDK 21.0.8,
and bundletool 1.17.0. No system SDK/workload installation was needed.

```powershell
./build/Build-ShowcaseAndroid.ps1 -HybridRoot PATH_TO_ISOLATED_HYBRID_4_1 -ExtensionsRoot PATH_TO_ISOLATED_EXTENSIONS_4_1
```

The script accepts explicit Android/Java SDK directories, NuGet config and a
writable package-cache path. It prunes restore to Android, preserves the source
dependencies' existing net9.0-android targets, and uses short temporary paths.
Existing SDK9 dependency EOL warnings remain; no server contract upgrade was
made. Run from `Showcase` when invoking dotnet manually so its scoped SDK applies.

Source snapshots used core `54e5abd656df6db37daef71dbc8ba034495d195f` and extensions
`5690ba81b7a0c7cb23362e8477ee61b6792bde6e`; no other worker's worktree was changed.
The core snapshot additionally required this compile correction at
`Wisej.Hybrid.Scanning/Platforms/Android/BarcodeScannerActivity.cs:263`:

```diff
- foreach (var result in _request.Session.Results.Reverse().Take(_request.Session.Options.RecentScanCount))
+ foreach (var result in _request.Session.Results.AsEnumerable().Reverse().Take(_request.Session.Options.RecentScanCount))
```

`Results` is a list, so its instance `Reverse()` returns void. The core owner
must apply/review this correction through the coordinating thread before the
candidate is reproducible from those committed dependencies alone.

## Binary evidence

The Android-only script successfully produced the Release AAB and APK.
The unsigned AAB SHA-256 is:

`2F18441F19CC19927B34FD6D6076763752EE4E9A6AFB0AB071582DD86657B606`

The checked artifact metadata, per-library hashes and runtime observations are
recorded in [release-40 evidence](evidence/showcase-android-release-40.json).

- The actual AAB manifest has package `com.iceteagroup.hybrid`, target SDK 36,
  minimum SDK 23, version code 40 and version name 1.3.5.
- Every shipped arm64-v8a and x86_64 ELF library passes 16 KB PT_LOAD alignment
  and file-offset/virtual-address congruence: 24/24. Both production offender
  names are present with 16 KB-aligned replacements.
- The bundled barcode 17.2.0 negative control fails the same LOAD checks.
- The direct Release APK and bundletool-generated universal APK both pass
  `zipalign -c -P 16 -v 4`; the generated test-signed APK also passes.
- All 24 native hashes in the tested, generated APK match the final AAB.
- Native `.so` entries are compressed and the actual manifest sets
  `extractNativeLibs=true`. The AAB config does not specify
  `PAGE_ALIGNMENT_16K`; this candidate uses compressed native packaging rather
  than an uncompressed alignment claim. Android documents compressed native
  libraries as an alternative in its [16 KB guidance](https://developer.android.com/guide/practices/page-sizes).
- The verifier separately records non-aligned GNU_RELRO ends. Those observations
  are not silently treated as overall compatibility approval. Use
  `-RequireAlignedRelroEnd` for the stricter check and retain runtime evidence.

```powershell
./build/Test-Android16Kb.ps1 -Archive PATH_TO_ACTUAL_AAB -Report aab-elf.json
java -jar bundletool.jar dump manifest --bundle=PATH_TO_ACTUAL_AAB --module=base
java -jar bundletool.jar dump config --bundle=PATH_TO_ACTUAL_AAB
java -jar bundletool.jar build-apks --bundle=PATH_TO_ACTUAL_AAB --output=test.apks --aapt2=PATH_TO_AAPT2 --mode=universal
zipalign -c -P 16 -v 4 GENERATED_APK
adb -s TEST_DEVICE shell getconf PAGE_SIZE
```

Generated artifacts are test-signed with the existing Android Debug certificate,
not a production upload certificate. The unsigned AAB is the candidate for the
owner's approved release-signing workflow; no signing keys were exported.

## Runtime and release gates

The separate Google API 36 x86_64 16 KB emulator reports SDK 36 and page size
16384. Google's image archive SHA-1 matched
`dd783282e84bf475a02eba6777c79fc5695e1583` (revision 7). The final AAB-generated,
test-signed APK installs with `adb install --no-incremental` and renders the
Showcase Integrations UI. A first incremental install produced SIGBUS inside
Android's native ELF loader; a streamed reinstall of the same APK passed startup.
Both traces are retained; no claim is made that every installation path passes.

On the same final APK, the barcode scanner opened, loaded `libbarhopper_v3.so`
successfully, initialized its native decoder, and returned to Showcase. The
native text scanner opened, loaded `libmlkit_google_ocr_pipeline.so` successfully,
initialized its OCR models, and returned to Showcase. The process stayed alive
and neither scanner trace contained a fatal exception, fatal signal or
`UnsatisfiedLinkError`. These are camera/initialization smoke tests; no barcode
or text recognition result was asserted using the emulated scene.

Before release, the owner must coordinate the core compile correction, inspect
the native/RELRO findings with 16 KB arm64 runtime coverage, exercise barcode/OCR
recognition and remaining hardware integrations, compare the merged permissions
against production 39, apply approved production signing, and recheck the next
version code. The merged source graph already declares foreground-service,
media-projection and microphone service permissions; this PR adds no manifest
permissions, but it does not establish that production 39 already has that set.
Any permission expansion needs the user's specific confirmation.

No Play upload, public rollout, paid device farm, legal declaration, production
signing change, or persistent credential setup was performed. Local evidence
includes AAB/ZIP/ELF reports, merged manifest, native hashes, test certificate,
emulator metadata, install/launch traces and screenshots.
