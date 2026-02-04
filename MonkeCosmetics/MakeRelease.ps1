# Needs to be at least that version, or mmm can't read the archive
#Requires -Modules @{ ModuleName="Microsoft.PowerShell.Archive"; ModuleVersion="1.2.3" }
$MyInvocation.MyCommand.Path | Split-Path | Push-Location # Run from this script's directory
curl -L https://github.com/logicblocker/MonkeCosmetics/releases/download/v3.0.0/MonkeCosmetics-3.0.0.zip -o GC.zip
Expand-Archive GC.zip 
rm GC.zip
dotnet build -c Release -o Temp
cp Temp\MonkeCosmetics.dll GC\BepInEx\plugins\MonkeCosmetics\MonkeCosmetics.dll
rmdir Temp -Recurse
Compress-Archive GC\BepInEx\ MonkeCosmetics-v.zip 
rmdir GC -Recurse
