Param(
	[Parameter(Mandatory=$true)][string]$resourceName,
	[Parameter(Mandatory=$true)][string]$buildNumber)
	

octo pack --id=$resourceName --version=$buildNumber --format=zip --basePath=./src/DevOpsPorto/bin/Release/netcoreapp1.0/publish

exit $LastExitCode