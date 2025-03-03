dotnet test --collect:"XPlat Code Coverage"

$projectName = "CassandraQueryBuilder.Tests"

$coverageDir = Get-ChildItem -Directory ".\$projectName\TestResults" | Sort-Object LastWriteTime | Select-Object -Last 1

$guid = $coverageDir.Name

$reportPath = "coveragereport\$guid\index.html"
reportgenerator -reports:".\$projectName\TestResults\$guid\coverage.cobertura.xml" -targetdir:"coveragereport\$guid" -reporttypes:Html

$fullPath = (Join-Path -Path (Get-Location) -ChildPath $reportPath)
$fileUrl = $fullPath -replace '\\', '/'
$fileUrl = "file:///" + $fileUrl

Write-Host "Relatório gerado em: coveragereport\$guid"

Start-Process $fileUrl


Write-Host "Aperte qualquer botão para fechar..."
[System.Console]::ReadKey() | Out-Null