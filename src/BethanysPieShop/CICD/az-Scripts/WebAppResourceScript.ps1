
param ($TemplateFilePath,$TemplateParameterFilePath)



 New-AzResourceGroupDeployment -ResourceGroupName AzureDevOpsResourceGroup  -nameFromTemplate BethanyShop123 `
-TemplateFile $TemplateFilePath  -TemplateParameterFile  $TemplateParameterFilePath
