Param(
	[Parameter(Mandatory=$true)][string]$resourceName,
	[Parameter(Mandatory=$true)][string]$buildNumber)
	
$packExtension = ".zip"	
$packVersion = "." + $buildNumber

$packFullPath = $resourceName + $packVersion + $packExtension 

octo push --package $packFullPath  --server http://localhost:8091 --apiKey API-A3EDYTKSDBU36DMH3VBZL4OWWYY


exit $LastExitCode