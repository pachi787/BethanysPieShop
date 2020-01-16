param ($WorkingDirectory)

 New-AzResourceGroupDeployment -ResourceGroupName AzureDevOpsResourceGroup  -nameFromTemplate BethanyShop123 `
-TemplateFile "$WorkingDirectory\_Prashant_Goda-Azure Web App for ASP.NET-CI\drop\BethanysPieShop\CICD\template.json" `
-TemplateParameterFile "$WorkingDirectory\_Prashant_Goda-Azure Web App for ASP.NET-CI\drop\BethanysPieShop\CICD\Parameters.json"