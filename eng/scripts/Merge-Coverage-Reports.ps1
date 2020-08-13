# Wrapper Script for ChangeLog Verification
param (
  [String]$RepoRoot,
  [String]$BinDirectory
)

Push-Location $RepoRoot
$CoverageFiles = Get-ChildItem "*coverage.cobertura.xml" -Recurse -File
$CoverageFilesString

ForEach ($file in $CoverageFiles)
{
    if ($CoverageFilesString)
    {
        $CoverageFilesString += ';'
    }
    $CoverageFilesString += $file.FullName
}

#Download ReportGenerator Tool from Nuget
Invoke-WebRequest -MaximumRetryCount 10 -Uri "https://www.nuget.org/api/v2/package/ReportGenerator/4.6.4" `
-OutFile "ReportGenerator.zip" | Wait-Process; Expand-Archive -Path "ReportGenerator.zip" -DestinationPath $BinDirectory

Write-Output $CoverageFilesString


&dotnet (Join-Path $BinDirectory 'tools' 'netcoreapp3.0' 'ReportGenerator.dll') "-reports:${CoverageFilesString}" "-targetdir:${RepoRoot}" "-reporttypes:Cobertura"


