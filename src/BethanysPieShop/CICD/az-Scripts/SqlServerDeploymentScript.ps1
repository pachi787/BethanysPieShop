
param ($TemplateFilePath,$TemplateParameterFilePath)



 New-AzResourceGroupDeployment -ResourceGroupName AzureDevOpsResourceGroup  `
-TemplateFile $TemplateFilePath  -TemplateParameterFile  $TemplateParameterFilePath
