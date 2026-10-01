#requires -Version 7.0
param(
    [Parameter(Mandatory)][string]$Archive,
    [string]$Report,
    [switch]$RequireAlignedRelroEnd
)

# Inspect bytes from the actual AAB/APK/AAR, including every shipped 64-bit ABI.
# An AAB's ZIP offsets are not APK offsets; verify its bundletool config separately.
$ErrorActionPreference = 'Stop'
$path = (Resolve-Path -LiteralPath $Archive).Path
$zip = [IO.Compression.ZipFile]::OpenRead($path)
$results = @()
try {
    foreach ($entry in $zip.Entries) {
        if ($entry.FullName -notmatch '/(arm64-v8a|x86_64)/[^/]+\.so$') { continue }
        $stream = $entry.Open()
        $memory = [IO.MemoryStream]::new()
        try { $stream.CopyTo($memory); $bytes = $memory.ToArray() }
        finally { $stream.Dispose(); $memory.Dispose() }
        if ($bytes.Length -lt 64 -or [BitConverter]::ToUInt32($bytes, 0) -ne 0x464c457f -or
            $bytes[4] -ne 2 -or $bytes[5] -ne 1) {
            throw "Expected a little-endian ELF64 library: $($entry.FullName)"
        }
        $phoff = [BitConverter]::ToUInt64($bytes, 32)
        $phsize = [BitConverter]::ToUInt16($bytes, 54)
        $phcount = [BitConverter]::ToUInt16($bytes, 56)
        if ($phsize -lt 56 -or $phoff + $phsize * $phcount -gt $bytes.Length) {
            throw "Invalid ELF program header table: $($entry.FullName)"
        }
        $loads = @()
        $relro = @()
        for ($i = 0; $i -lt $phcount; $i++) {
            $offset = [int]($phoff + $i * $phsize)
            $type = [BitConverter]::ToUInt32($bytes, $offset)
            $fileOffset = [BitConverter]::ToUInt64($bytes, $offset + 8)
            $address = [BitConverter]::ToUInt64($bytes, $offset + 16)
            $size = [BitConverter]::ToUInt64($bytes, $offset + 40)
            $alignment = [BitConverter]::ToUInt64($bytes, $offset + 48)
            if ($type -eq 1) {
                $loads += [ordered]@{
                    alignment = $alignment
                    offset = $fileOffset
                    virtualAddress = $address
                    passed = ($alignment -ge 16384 -and $fileOffset % 16384 -eq $address % 16384)
                }
            }
            if ($type -eq 0x6474e552) {
                $relro += [ordered]@{
                    virtualAddress = $address
                    memorySize = $size
                    passed = (($address + $size) % 16384 -eq 0)
                }
            }
        }
        $results += [ordered]@{
            library = $entry.FullName
            sha256 = [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData($bytes))
            loadSegments = $loads
            relroSegments = $relro
            loadAlignmentPassed = ($loads.Count -gt 0 -and @($loads | Where-Object { !$_.passed }).Count -eq 0)
            relroEndAligned = (@($relro | Where-Object { !$_.passed }).Count -eq 0)
        }
    }
}
finally { $zip.Dispose() }
if (!$results.Count) { throw 'No arm64-v8a/x86_64 native libraries found; this is not a native alignment validation.' }
$result = [ordered]@{
    archive = $path
    sha256 = (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash
    libraries = $results
    elfLoadAlignmentPassed = (@($results | Where-Object { !$_.loadAlignmentPassed }).Count -eq 0)
    relroEndAlignmentPassed = (@($results | Where-Object { !$_.relroEndAligned }).Count -eq 0)
    remainingChecks = @('bundletool config/manifest: 16 KB uncompressed alignment or compressed/extracted native packaging', 'zipalign -c -P 16 -v 4 on generated APKs', 'runtime tests with adb shell getconf PAGE_SIZE = 16384')
}
$json = $result | ConvertTo-Json -Depth 10
if ($Report) { $json | Set-Content -LiteralPath $Report -Encoding utf8 }
$json
if (!$result.elfLoadAlignmentPassed) { throw '16 KB ELF LOAD alignment failed. See the exact library and segment details in the report.' }
if ($RequireAlignedRelroEnd -and !$result.relroEndAlignmentPassed) { throw 'Strict RELRO end alignment check failed. Inspect the segment layout and test the affected native paths on a 16 KB device.' }
