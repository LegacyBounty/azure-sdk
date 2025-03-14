// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Automanage;
using Azure.ResourceManager.Automanage.Models;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageHciClusterConfigurationProfileAssignmentCollection
    {
        // List configuration profile assignments by resourceGroup and cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListConfigurationProfileAssignmentsByResourceGroupAndCluster()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/listConfigurationProfileAssignmentsByClusterName.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_ListByClusterName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageHciClusterConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string clusterName = "myClusterName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.AzureStackHci/clusters/{2}", subscriptionId, resourceGroupName, clusterName));
            AutomanageHciClusterConfigurationProfileAssignmentCollection collection = client.GetAutomanageHciClusterConfigurationProfileAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (AutomanageHciClusterConfigurationProfileAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomanageConfigurationProfileAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create or update a HCI configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAHCIConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/createOrUpdateConfigurationProfileHCIAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCIAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageHciClusterConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string clusterName = "myClusterName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.AzureStackHci/clusters/{2}", subscriptionId, resourceGroupName, clusterName));
            AutomanageHciClusterConfigurationProfileAssignmentCollection collection = client.GetAutomanageHciClusterConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            AutomanageConfigurationProfileAssignmentData data = new AutomanageConfigurationProfileAssignmentData()
            {
                Properties = new ConfigurationProfileAssignmentProperties()
                {
                    ConfigurationProfile = "/providers/Microsoft.Automanage/bestPractices/AzureBestPracticesProduction",
                },
            };
            ArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationProfileAssignmentName, data);
            AutomanageHciClusterConfigurationProfileAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a HCI configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAHCIConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileHCIAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCIAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageHciClusterConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string clusterName = "myClusterName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.AzureStackHci/clusters/{2}", subscriptionId, resourceGroupName, clusterName));
            AutomanageHciClusterConfigurationProfileAssignmentCollection collection = client.GetAutomanageHciClusterConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            AutomanageHciClusterConfigurationProfileAssignmentResource result = await collection.GetAsync(configurationProfileAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a HCI configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAHCIConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileHCIAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCIAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageHciClusterConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string clusterName = "myClusterName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.AzureStackHci/clusters/{2}", subscriptionId, resourceGroupName, clusterName));
            AutomanageHciClusterConfigurationProfileAssignmentCollection collection = client.GetAutomanageHciClusterConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            bool result = await collection.ExistsAsync(configurationProfileAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
