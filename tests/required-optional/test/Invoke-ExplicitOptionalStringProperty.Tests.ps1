$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ExplicitOptionalStringProperty.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ExplicitOptionalStringProperty' {
    It 'PostExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Post' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
