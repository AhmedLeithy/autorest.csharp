# TenantOnly
### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
require: $(this-folder)/../../../readme.md
input-file: $(this-folder)/SingleTopLevelClientWithOperations.json
low-level-client: true
security: AzureKey
security-header-name: Fake-Subscription-Key
single-top-level-client: true
```