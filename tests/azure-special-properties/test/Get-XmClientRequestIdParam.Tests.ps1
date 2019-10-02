$TestRecordingFile = Join-Path $PSScriptRoot 'Get-XmClientRequestIdParam.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-XmClientRequestIdParam' {
    It 'Get' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
