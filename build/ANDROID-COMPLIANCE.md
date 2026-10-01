# Showcase Android candidate 40 — 2026-10-01

The Release candidate targets API 36, replaces production 39's reported ML Kit
LOAD-alignment offenders, and fixes a reproduced incremental-install startup
failure by embedding native libraries with 16 KB APK alignment. It remains a
**draft with release gates**: the strict GNU_RELRO-end check fails for 21 libraries,
physical ARM64 coverage and production-permission comparison are outstanding,
and the AAB has not been production-signed or uploaded.

Android alone uses `net10.0-android36.0` / MAUI 10.0.20. iOS, Mac Catalyst and
Windows retain their .NET 9 / MAUI 9.0.120 targets. Existing Wisej 4.1.4 contracts,
NuGet IDs and source references remain. Android version is 1.3.5 / code 40;
the console worker checked all uploaded artifacts and maximum code 39 on October 1.
Recheck that inventory before any separately authorized upload.

Production 39 reportedly flags `libbarhopper_v3.so` and
`libmlkit_google_ocr_pipeline.so` in both arm64-v8a and x86_64. Android pins the
existing IDs `Xamarin.Google.MLKit.BarcodeScanning` 117.3.0.7 and
`Xamarin.Google.MLKit.TextRecognition` 116.0.1.7. They supply Google barcode 17.3.0
and bundled text-recognition 16.0.1, identified in Google's
[August 7, 2024 release notes](https://developers.google.com/ml-kit/release-notes)
as adding 16 KB support. All four replacement binaries pass actual LOAD checks.

## Reproduce the build

Use PowerShell 7. The verified installed toolchain is .NET SDK 10.0.401, Android
workload 36.1.69, Mono runtime packs 10.0.12, Android SDK/build-tools 36.0.0,
JDK 21.0.8 and bundletool 1.17.0. No system SDK/workload installation was needed.
An official API 36 x86_64 16 KB image, revision 7, was added to an isolated test
SDK/AVD; its downloaded archive SHA-1 matched
`DD783282E84BF475A02EBA6777C79FC5695E1583`.

Use isolated committed source snapshots:

- Hybrid 4.1: `16f0b7bbee120df5198ac01ae0c99067fb39d149`
- Hybrid Extensions 4.1: `5690ba81b7a0c7cb23362e8477ee61b6792bde6e`
- Showcase base: `7a4fc1308b2d646bd048ee651ab5d9b98038f591`

```powershell
./build/Build-ShowcaseAndroid.ps1 -HybridRoot PATH_TO_HYBRID_16F0B7B -ExtensionsRoot PATH_TO_EXTENSIONS_5690BA8
```

The script accepts explicit Android/Java SDK directories, NuGet configuration
and a writable package cache. It restores only Android, retains dependency
`net9.0-android` targets, and uses short, source-root-specific intermediate paths.
A source-root switch previously reused JNI/typemap state and failed startup;
the isolated fresh build and source-specific cache resolve that case. Use fresh
snapshot directories when changing dependency revisions. Existing .NET 9
dependency EOL warnings remain; this change does not migrate server contracts.

Hybrid's committed correction explicitly calls `Results.AsEnumerable().Reverse()`.
`Results` is a `BarcodeScanResult[]`; C# 14 otherwise binds `array.Reverse()` to
the void-returning `MemoryExtensions.Reverse(Span<T>)`. The current artifact uses
the committed fix, with no temporary patch. The core owner independently reports
six existing scanner targets compiling under SDKs 9.0.311 and 10.0.401, with 11
scanner checks passing under each. Those results are separate from this app's
artifact/runtime checks. No other worker's worktree was modified.

## Actual binary checks

Unsigned AAB SHA-256:

`24F370C0D281F1237DD00B414AEA2B7545542321F36A6121FAAB27A99FD75CF4`

AAB-generated universal APK, signed with the existing Android Debug certificate:

`B23403BDECB0691B40156B98B061052C28434A6450FEEF8F55EEB9980A0C9CB7`

[Structured evidence](evidence/showcase-android-release-40.json) contains source
revisions, native providers/hashes, LOAD and RELRO segments, permissions and runtime
results. The [actual merged manifest](evidence/showcase-android-release-40-manifest.xml)
has package `com.iceteagroup.hybrid`, minimum SDK 23, target SDK 36, code 40 and
`extractNativeLibs=false`. Actual bundle config specifies `PAGE_ALIGNMENT_16K`.
All 24 native entries in the generated APK are uncompressed, pass
`zipalign -c -P 16 -v 4`, and match the AAB's native hashes. Every arm64-v8a and
x86_64 library passes 16 KB PT_LOAD alignment and offset/address congruence.
The older bundled barcode 17.2.0 AAR fails the same verifier as a negative control.

```powershell
./build/Test-Android16Kb.ps1 -Archive ACTUAL_AAB -Report aab-elf.json
./build/Test-Android16Kb.ps1 -Archive ACTUAL_AAB -RequireAlignedRelroEnd
java -jar bundletool.jar dump manifest --bundle=ACTUAL_AAB --module=base
java -jar bundletool.jar dump config --bundle=ACTUAL_AAB
java -jar bundletool.jar build-apks --bundle=ACTUAL_AAB --output=test.apks --aapt2=PATH_TO_AAPT2 --mode=universal
zipalign -c -P 16 -v 4 GENERATED_APK
adb -s TEST_DEVICE shell getconf PAGE_SIZE
```

The second command deliberately fails for this candidate. Android's current
[RELRO guidance](https://developer.android.com/guide/practices/page-sizes#relro)
requires `(VirtAddr + MemSiz) % 0x4000 == 0`. The 21 failures comprise:

| Provider | Libraries with non-aligned RELRO ends |
| --- | --- |
| Generated by Android SDK 36.1.69 | `libassembly-store.so`, `libarc.bin.so`, `libxamarin-app.so`, both ABIs (6) |
| Mono runtime 10.0.12 | `libSystem.Globalization.Native.so`, `libSystem.IO.Compression.Native.so`, `libSystem.Native.so`, `libmono-component-marshal-ilgen.so`, `libmonosgen-2.0.so`, both ABIs (10) |
| Android SDK runtime | `libmonodroid.so`, both ABIs (2) |
| Google ML Kit | x86_64 `libbarhopper_v3.so`; both ABI `libmlkit_google_ocr_pipeline.so` (3) |

Static layout inspection finds **zero intersections** between each rounded RELRO
end tail and writable PT_LOAD data outside RELRO. Android's
[linker source](https://android.googlesource.com/platform/bionic/+/refs/heads/main/linker/linker_phdr.cpp)
rounds the protection range to pages. Padding gaps plausibly explain the observed
successful native loads and recognition, but this is an inference, not a waiver
of the documented check. The verifier reports both facts independently. Native
SDK/toolchain owner resolution and physical ARM64 testing remain release gates.
App XML cannot safely relink Google's or Microsoft's prebuilt native binaries.
No binary header patch or runtime-library substitution was applied.

## Incremental-install failure and source fix

The preserved compressed candidate (`2F18441F…606`) reproducibly crashed in the
loader's writable-segment tail memset, on IncFS, in x86_64 `libxamarin-app.so`.
The file pulled from the device exactly matched the AAB's SHA-256:
`8DAB67EAE534066769F5A1E424F5F0021434DF9DF385E757CE2537797B007731`.
That original library's RELRO end **was aligned**.

Its length was `0x20d8a0`; writing at file mapping offset `0x20fff0` lies beyond
its 4 KB-rounded EOF and inside its 16 KB-rounded EOF (`0x210000`). The
[syscall-only probe](probes/IncfsTailProbe.S) reproduces SIGBUS (exit 135) on the
IncFS file while the identical copied file on ext4 exits 0. It maps privately,
changes no underlying file, and involves no ELF loader or RELRO protection.
This isolates a partial 16 KB file-page tail issue on the tested image kernel;
it does not establish the behavior of every Android kernel or install method.

```powershell
llvm-mc -filetype=obj -triple=x86_64-linux-android -o probe.o build/probes/IncfsTailProbe.S
ld -m elf_x86_64 -e _start --build-id -z max-page-size=16384 -o probe probe.o
# Run on the isolated emulator against the preserved matching IncFS library,
# then an identical ext4 copy. Constants intentionally identify that exact file.
```

The source fix sets `extractNativeLibs=false` and supplies an Android-only
bundle config with uncompressed 16 KB native alignment. The final generated APK
passes fresh incremental installation and startup; the streamed install path
also passes. Local traces retain the original crash, byte comparison, mapping
probe controls, final installs and launches.

## Recognition and runtime evidence

The separate API 36 test emulator reports page size 16384. On the current APK:

- x86_64 native barcode single scan returns `WISEJ16KB` to Showcase.
- Batch scan displays `1 scanned`, the `WISEJ16KB` history item, and `Done (1)`,
  exercising the committed scanner enumeration correction.
- Native OCR recognizes `WISEJ 16 KB TEST` and `SDK 36 PAGE 16384` in its live
  overlay. Barcode/OCR libraries load from `base.apk!/lib/x86_64`; no fatal signal,
  fatal exception or `UnsatisfiedLinkError` occurs in those test traces.
- A forced `arm64-v8a` install selects that primary ABI. Through the image's
  `libndk_translation.so` bridge, ARM64 runtime, barcode and OCR binaries load;
  barcode returns `WISEJ16KB` and OCR recognizes both fixture lines. This is
  **translated ARM64 coverage on an x86_64 emulator**, not physical ARM64 testing.

The [fixture](evidence/recognition-fixture.png) and recognition screenshots are
committed under `build/evidence`. The virtual-scene wall poster was loaded through
the emulator console; a camera pose facing its front was set through the local
emulator controller. Barcode pose: position `(-1.807, 0.32, 3.584)`, rotation
`(0, -150, 0)` degrees. OCR uses position `(-2.807, 0.32, 1.852)` with the same
rotation. This avoids claiming success from initialization alone.

## Remaining release gates

Resolve the strict native RELRO findings and run physical ARM64 16 KB and remaining
hardware integration tests. Compare the committed merged permissions against
production 39 before upload: that production manifest/list has not been supplied
by the console worker. The source graph already declares foreground-service,
media-projection and microphone service permissions; this app patch adds no
`uses-permission`, but production parity is unverified. Any expansion needs the
user's specific authorization.

The AAB is unsigned; only the existing test Debug certificate was used locally.
Production upload signing must use the owner's approved workflow and next code
must be rechecked. No signing keys were exported, no persistent release credential
was created, and no Play upload, rollout, deployment or pack/release workflow was
performed. The candidate remains unshipped.
