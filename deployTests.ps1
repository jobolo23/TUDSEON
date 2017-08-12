Import-Module -DisableNameChecking ..\..\..\BuildTools.psm1

dotnet restore
dotnet publish
Deploy-CasperJsTest
