# ExactMatchFlattenInheritance

This project is for testing flatten properties.

## AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
title: ExactMatchFlattenInheritance
require: $(this-folder)/../../../readme.md
azure-arm: true
model-namespace: false
input-file: $(this-folder)/AzureResourceFlattenProperties.json
namespace: ExactMatchFlattenInheritance

mgmt-debug:
  show-request-path: true
# need the following to trigger flattening
payload-flattening-threshold: 2
```
