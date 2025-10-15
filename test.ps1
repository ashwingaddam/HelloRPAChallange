Import-Module PowerShellGet
Import-Module Microsoft.Graph
Get-Module "Microsoft.Graph" -ListAvailable
Connect-MgGraph -Scopes "User.Read.All","Group.ReadWrite.All"


