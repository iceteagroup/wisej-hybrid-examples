param(
    [ValidateSet('Android', 'Windows')][string]$Platform = 'Android',
    [string[]]$Examples = @('Authentication', 'DocumentScanner', 'DynamicUpdates', 'ExternalApps',
        'Flashlight', 'LocalDatabase', 'Navigation', 'NetworkEvents', 'PlatformCode', 'RemoteWebApi', 'Shortcuts', 'Showcase'),
    [switch]$CompileOnly
)
$ErrorActionPreference = 'Stop'
if ($CompileOnly -and $Platform -eq 'Windows') { throw 'Windows requires a full build to generate its XAML entry point. Omit -CompileOnly.' }
$root = Split-Path $PSScriptRoot -Parent
$local = Join-Path $root '.local-nuget'
$manifest = Get-Content -Raw (Join-Path $local 'manifest.json') | ConvertFrom-Json
$framework = if ($Platform -eq 'Android') { 'net9.0-android' } else { 'net9.0-windows10.0.19041.0' }
$results = @()
Push-Location $root
try {
    foreach ($example in $Examples) {
        $project = if ($example -eq 'Showcase') { 'Showcase/App/HybridApp.csproj' } else { "$example/HybridClient/HybridClient.csproj" }
        [xml]$xml = Get-Content -Raw -LiteralPath $project
        $declaredFrameworks = @($xml.SelectNodes('//TargetFrameworks') | ForEach-Object { $_.InnerText }) -join ';'
        if ($declaredFrameworks -notmatch [regex]::Escape($framework)) {
            $results += [pscustomobject]@{ example=$example; status='skipped'; reason="Does not target $framework" }
            continue
        }
        $log = Join-Path $local "logs/$example-$Platform-test.log"
        $properties = @('-p:UseLocalHybridPackages=true', "-p:TargetFrameworks=$framework", '-p:BuildInParallel=false')
        if ($Platform -eq 'Android') { $properties += '-p:EmbedAssembliesIntoApk=true' }
        Write-Host "Testing $example against $($manifest.version) ($framework)"
        & dotnet restore $project --configfile (Join-Path $local 'NuGet.Config') @properties --verbosity quiet *> $log
        if ($LASTEXITCODE -ne 0) {
            $results += [pscustomobject]@{ example=$example; status='restore-failed'; log=$log }
            continue
        }
        $assetsPath = Join-Path (Split-Path $project) 'obj/project.assets.json'
        $assets = Get-Content -Raw $assetsPath | ConvertFrom-Json
        $hybrid = @($assets.libraries.PSObject.Properties | Where-Object { $_.Name -match '^Wisej[.-].*Hybrid' })
        $wrong = @($hybrid | Where-Object { $_.Value.type -ne 'package' -or !($_.Name.EndsWith('/' + $manifest.version)) })
        if (!$hybrid.Count -or $wrong.Count) {
            $results += [pscustomobject]@{ example=$example; status='wrong-dependencies'; dependencies=@($wrong.Name); log=$log }
            continue
        }
        $args = @('build', $project, '-f', $framework, '--no-restore', '-m:1', '--verbosity', 'quiet') + $properties
        if ($CompileOnly) { $args += '-t:Compile' }
        & dotnet @args *>> $log
        $status = if ($LASTEXITCODE -eq 0) { 'passed' } else { 'build-failed' }
        $results += [pscustomobject]@{ example=$example; status=$status; dependencies=@($hybrid.Name); log=$log }
        Write-Host "$example : $status"
    }
    $report = Join-Path $local "results-$Platform.json"
    @{ version=$manifest.version; framework=$framework; compileOnly=[bool]$CompileOnly; results=$results } |
        ConvertTo-Json -Depth 6 | Set-Content $report -Encoding utf8
    $results | Format-Table example,status
    if (@($results | Where-Object { $_.status -notin @('passed', 'skipped') }).Count) { throw "Validation failed. See $report" }
}
finally { Pop-Location }
