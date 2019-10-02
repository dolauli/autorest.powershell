$TestRecordingFile = Join-Path $PSScriptRoot 'Set-IntMin32.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-IntMin32' {
    It 'Put' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
