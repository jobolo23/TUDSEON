Import-Module -DisableNameChecking ..\..\..\BuildTools.psm1

dotnet restore
dotnet build
Run-KestrelTest 5569
