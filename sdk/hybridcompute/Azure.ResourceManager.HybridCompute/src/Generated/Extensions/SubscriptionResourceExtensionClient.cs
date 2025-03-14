// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridCompute.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _hybridComputeMachineMachinesClientDiagnostics;
        private MachinesRestOperations _hybridComputeMachineMachinesRestClient;
        private ClientDiagnostics _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics;
        private PrivateLinkScopesRestOperations _hybridComputePrivateLinkScopePrivateLinkScopesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HybridComputeMachineMachinesClientDiagnostics => _hybridComputeMachineMachinesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputeMachineResource.ResourceType.Namespace, Diagnostics);
        private MachinesRestOperations HybridComputeMachineMachinesRestClient => _hybridComputeMachineMachinesRestClient ??= new MachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HybridComputeMachineResource.ResourceType));
        private ClientDiagnostics HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics => _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputePrivateLinkScopeResource.ResourceType.Namespace, Diagnostics);
        private PrivateLinkScopesRestOperations HybridComputePrivateLinkScopePrivateLinkScopesRestClient => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient ??= new PrivateLinkScopesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HybridComputePrivateLinkScopeResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputeMachineResource> GetHybridComputeMachinesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridComputeMachineMachinesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridComputeMachineMachinesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridComputeMachineResource(Client, HybridComputeMachineData.DeserializeHybridComputeMachineData(e)), HybridComputeMachineMachinesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHybridComputeMachines", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputeMachineResource> GetHybridComputeMachines(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridComputeMachineMachinesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridComputeMachineMachinesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridComputeMachineResource(Client, HybridComputeMachineData.DeserializeHybridComputeMachineData(e)), HybridComputeMachineMachinesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHybridComputeMachines", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkScopeResource(Client, HybridComputePrivateLinkScopeData.DeserializeHybridComputePrivateLinkScopeData(e)), HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkScopeResource(Client, HybridComputePrivateLinkScopeData.DeserializeHybridComputePrivateLinkScopeData(e)), HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHybridComputePrivateLinkScopes", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope&apos;s validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetValidationDetailsPrivateLinkScope");
            scope.Start();
            try
            {
                var response = await HybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetValidationDetailsAsync(Id.SubscriptionId, location, privateLinkScopeId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope&apos;s validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            using var scope = HybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetValidationDetailsPrivateLinkScope");
            scope.Start();
            try
            {
                var response = HybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetValidationDetails(Id.SubscriptionId, location, privateLinkScopeId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
