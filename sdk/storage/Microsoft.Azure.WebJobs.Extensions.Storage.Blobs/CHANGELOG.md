# Release History

## 5.1.0-beta.2 (Unreleased)
- Added Target Based Scaling support for Storage Queues and Blobs

## 5.1.0-beta.1 (2023-02-07)
- Added logging for details of a storage blob listener on start/stop operations.
- Updated BlobNameValidationAttribute to allow $web as a container name.
- Added Blob storage support for ParameterBindingData reference type.

## 5.0.1 (2022-05-02)
- Implemented caching blobs in shared memory for faster I/O.

## 5.0.0 (2021-10-26)
- General availability of Microsoft.Azure.WebJobs.Extensions.Storage.Blobs 5.0.0.
- Fixed bug where internal message format of blob trigger didn't interop with previous major versions of the extension.
- Adding Dynamic Concurrency support.
- Execution log when using Event Grid Blob Trigger vs Blob Trigger.
- Fix bug where dynamic SKU is not recognized correctly.

## 5.0.0-beta.5 (2021-07-09)
- This release contains bug fixes to improve quality.

## 5.0.0-beta.4 (2021-05-18)
- Added new configuration formats so extensions that need multiple storage services can specify them in one connection configuration.

Sample config:
```json
{
    "MyStorageConnection1": {
        "blobServiceUri": "https://<my_account>.blob.core.windows.net",
        "queueServiceUri": "https://<my_account>.queue.core.windows.net"
    },

    "MyStorageConnection2": {
        "accountName": "<my_account>"
    }
}
```

## 5.0.0-beta.3 (2021-03-09)

### Breaking Changes

- The configuration section name for URI configuration was changed from `endpoint` to `serviceUri` to be consistent with other clients.

In case of JSON, from:
```json
{
    "MyConnection": {
        "endpoint": "https://<my_account>.blob.core.windows.net"
    }
}
```

To
```json
{
    "MyConnection": {
        "serviceUri": "https://<my_account>.blob.core.windows.net"
    }
}
```

Or using environment variables, from:
```
MyConnection__endpoint=https://<my_account>.blob.core.windows.net
```
To
```
MyConnection__serviceUri=https://<my_account>.blob.core.windows.net
```

## 5.0.0-beta.2 (2021-02-09)

### Major changes and features
- EventGrid support for the Blob Trigger was added. Details of the feature can be found [here](https://github.com/Azure/azure-sdk-for-net/pull/17137#issue-525036753).

## 5.0.0-beta.1 (2020-11-10)

This is the first preview of the next generation of `Microsoft.Azure.WebJobs.Extension.Storage` which has been integrated with latest Azure Storage SDK that follows the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet_introduction.html) which provide a number of core capabilities that are shared amongst all Azure SDKs, including the intuitive Azure Identity library, an HTTP Pipeline with custom policies, error-handling, distributed tracing, and much more.

The `Microsoft.Azure.WebJobs.Extension.Storage.Blobs` offers drop-in replacement for scenarios where `Blob` and `BlobTrigger` attributes were bound to BCL types or user defined POCOs. Advanced scenarios like binding to Azure Storage Blobs SDK types or using `BlobsOptions` may require code changes.

This is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

### Major changes and features 
- The extension has been split per storage service, i.e. `Microsoft.Azure.WebJobs.Extension.Storage.Blobs` has been created.
- The extension uses V12 Azure Storage SDK.
- Added support for token credential authentication using Azure.Identity library, including support for managed identity and client secret credentials.
- Simplified parallelism control through single `BlobsOptions.MaxDegreeOfParallelism` property.
- The `BlobsOptions.CentralizedPoisonQueue` has been removed. The implicit poison queue for a `BlobTrigger` is located in target blob's account by default.
