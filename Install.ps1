Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
$Env:PSModulePath = $Env:PSModulePath+";C:\Users\ashwin.gaddam\OneDrive - UiPath\Documents\WindowsPowerShell\Modules1;C:\Program Files\PowerShell\7\Modules"
$Env:PSModulePath
Import-Module Microsoft.PowerShell.Management
Import-Module PowerShellGet
#Import-Module PnP.PowerShell
#Import-Module SharePointPnPPowerShellOnline
Get-Module -FullyQualifiedName $FullyQualifiedName | Format-Table -Property Name,Version
Get-ExecutionPolicy
Get-PSSession