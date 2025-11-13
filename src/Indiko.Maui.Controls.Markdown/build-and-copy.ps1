# Build script for NuGet package creation and copying
$configuration = "Release"
$targetFramework = "net9.0"
$projectPath = "."
$outputPath = "/Users/dandan/src/Flow/app/Flow.Maui/LocalPackages"

# Ensure the output directory exists
if (-not (Test-Path $outputPath)) {
    New-Item -ItemType Directory -Path $outputPath -Force
}

# Clean and build the solution
Write-Host "Cleaning solution..."
dotnet clean
Write-Host "Building solution..."
dotnet build -c $configuration

# Pack the NuGet package
Write-Host "Creating NuGet package..."
dotnet pack -c $configuration --no-build

# Display all nupkg files found for debugging
Write-Host "`nSearching for .nupkg files..."
$allNupkgs = Get-ChildItem -Recurse -Filter "*.nupkg"
Write-Host "Found $($allNupkgs.Count) .nupkg files:"
$allNupkgs | ForEach-Object {
    Write-Host "- $($_.FullName)"
}

# Find and copy the newest .nupkg file to the target directory
$nupkgFile = Get-ChildItem -Recurse -Filter "*.nupkg" | 
    Where-Object { $_.FullName -like "*bin\$configuration*" -or $_.FullName -like "*bin/$configuration*" } |
    Sort-Object LastWriteTime -Descending | 
    Select-Object -First 1

if ($nupkgFile) {
    Write-Host "`nCopying package..."
    Copy-Item $nupkgFile.FullName -Destination $outputPath -Force
    Write-Host "Successfully copied $($nupkgFile.Name) to $outputPath"
} else {
    Write-Host "`nNo .nupkg file found in the bin/$configuration directory!"
    Write-Host "Current directory: $(Get-Location)"
    
    # List contents of bin directory if it exists
    $binPath = Join-Path $projectPath "bin"
    if (Test-Path $binPath) {
        Write-Host "`nContents of bin directory:"
        Get-ChildItem -Recurse $binPath | ForEach-Object {
            Write-Host "- $($_.FullName)"
        }
    }
}