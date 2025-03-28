// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _azurePermissionsForResourceGroupClientDiagnostics;
        private AzurePermissionsForResourceGroupRestOperations _azurePermissionsForResourceGroupRestClient;
        private ClientDiagnostics _azurePermissionsForResourceClientDiagnostics;
        private AzurePermissionsForResourceRestOperations _azurePermissionsForResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AzurePermissionsForResourceGroupClientDiagnostics => _azurePermissionsForResourceGroupClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Authorization", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzurePermissionsForResourceGroupRestOperations AzurePermissionsForResourceGroupRestClient => _azurePermissionsForResourceGroupRestClient ??= new AzurePermissionsForResourceGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AzurePermissionsForResourceClientDiagnostics => _azurePermissionsForResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Authorization", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzurePermissionsForResourceRestOperations AzurePermissionsForResourceRestClient => _azurePermissionsForResourceRestClient ??= new AzurePermissionsForResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all permissions the caller has for a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Authorization/permissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzurePermissionsForResourceGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleDefinitionPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleDefinitionPermission> GetAzurePermissionsForResourceGroupsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzurePermissionsForResourceGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzurePermissionsForResourceGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, RoleDefinitionPermission.DeserializeRoleDefinitionPermission, AzurePermissionsForResourceGroupClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAzurePermissionsForResourceGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all permissions the caller has for a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Authorization/permissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzurePermissionsForResourceGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleDefinitionPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleDefinitionPermission> GetAzurePermissionsForResourceGroups(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzurePermissionsForResourceGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzurePermissionsForResourceGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, RoleDefinitionPermission.DeserializeRoleDefinitionPermission, AzurePermissionsForResourceGroupClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAzurePermissionsForResourceGroups", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all permissions the caller has for a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/permissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzurePermissionsForResource_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleDefinitionPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleDefinitionPermission> GetAzurePermissionsForResourcesAsync(string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzurePermissionsForResourceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzurePermissionsForResourceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, RoleDefinitionPermission.DeserializeRoleDefinitionPermission, AzurePermissionsForResourceClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAzurePermissionsForResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all permissions the caller has for a resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/permissions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzurePermissionsForResource_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="parentResourcePath"> The parent resource identity. </param>
        /// <param name="resourceType"> The resource type of the resource. </param>
        /// <param name="resourceName"> The name of the resource to get the permissions for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleDefinitionPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleDefinitionPermission> GetAzurePermissionsForResources(string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzurePermissionsForResourceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzurePermissionsForResourceRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, RoleDefinitionPermission.DeserializeRoleDefinitionPermission, AzurePermissionsForResourceClientDiagnostics, Pipeline, "ResourceGroupResourceExtensionClient.GetAzurePermissionsForResources", "value", "nextLink", cancellationToken);
        }
    }
}
