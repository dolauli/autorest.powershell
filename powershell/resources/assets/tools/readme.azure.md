# Azure PowerShell AutoRest Configuration

> Values
``` yaml
azure: true
powershell: true
branch: master
repo: https://github.com/Azure/azure-rest-api-specs/blob/$(branch)
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  copyright: Microsoft Corporation. All rights reserved.
  companyName: Microsoft Corporation
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/azps-license
  projectUri: https://github.com/Azure/azure-powershell
```

> Names
``` yaml
prefix: Az
```

> Folders
``` yaml
clear-output-folder: true
output-folder: .
```

> Profiles
``` yaml
#require: $(repo)/profiles/readme.md
#profile:
#  - hybrid-2019-03-01
#  - latest-2019-04-30
```

> Directives
``` yaml
directive:
  - where:
      subject: Operation
    hide: true
  - where:
      parameter-name: SubscriptionId
    set:
      default:
        script: '(Get-AzContext).Subscription.Id'
```