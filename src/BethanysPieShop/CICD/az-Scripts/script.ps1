[CmdletBinding()]
param (
    $WorkingDirectory
)
$workDirectory = $WorkingDirectory

 New-AzResourceGroupDeployment -ResourceGroupName AzureDevOpsResourceGroup  -nameFromTemplate BethanyShop123 `
-TemplateFile "$($workDirectory)\_Prashant_Goda-Azure Web App for ASP.NET-CI\drop\BethanysPieShop\CICD\template.json" `
-TemplateParameterFile "$($workDirectory)\_Prashant_Goda-Azure Web App for ASP.NET-CI\drop\BethanysPieShop\CICD\Parameters.json"