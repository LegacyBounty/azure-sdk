// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

[assembly: CodeGenSuppressType("SecurityInsightsWatchlistResource")]
namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A Class representing a SecurityInsightsWatchlist along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecurityInsightsWatchlistResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecurityInsightsWatchlistResource method.
    /// Otherwise you can get one from its parent resource <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> using the GetSecurityInsightsWatchlist method.
    /// </summary>
    public partial class SecurityInsightsWatchlistResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityInsightsWatchlistResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityInsightsWatchlistWatchlistsClientDiagnostics;
        private readonly WatchlistsRestOperations _securityInsightsWatchlistWatchlistsRestClient;
        private readonly SecurityInsightsWatchlistData _data;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistResource"/> class for mocking. </summary>
        protected SecurityInsightsWatchlistResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecurityInsightsWatchlistResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityInsightsWatchlistResource(ArmClient client, SecurityInsightsWatchlistData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityInsightsWatchlistResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsWatchlistWatchlistsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityInsightsWatchlistWatchlistsApiVersion);
            _securityInsightsWatchlistWatchlistsRestClient = new WatchlistsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsWatchlistWatchlistsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SecurityInsights/watchlists";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityInsightsWatchlistData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SecurityInsightsWatchlistItemResources in the SecurityInsightsWatchlist. </summary>
        /// <returns> An object representing collection of SecurityInsightsWatchlistItemResources and their operations over a SecurityInsightsWatchlistItemResource. </returns>
        public virtual SecurityInsightsWatchlistItemCollection GetSecurityInsightsWatchlistItems()
        {
            return GetCachedClient(Client => new SecurityInsightsWatchlistItemCollection(Client, Id));
        }

        /// <summary>
        /// Get a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityInsightsWatchlistItemResource>> GetSecurityInsightsWatchlistItemAsync(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            return await GetSecurityInsightsWatchlistItems().GetAsync(watchlistItemId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityInsightsWatchlistItemResource> GetSecurityInsightsWatchlistItem(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            return GetSecurityInsightsWatchlistItems().Get(watchlistItemId, cancellationToken);
        }

        /// <summary>
        /// Get a watchlist, without its watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityInsightsWatchlistResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a watchlist, without its watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityInsightsWatchlistResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a watchlist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a watchlist.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Delete");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Watchlist and its Watchlist Items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its Items, we should call this endpoint with rawContent and contentType properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsWatchlistResource>> UpdateAsync(WaitUntil waitUntil, SecurityInsightsWatchlistData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Update");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistResource>(Response.FromValue(new SecurityInsightsWatchlistResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Watchlist and its Watchlist Items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its Items, we should call this endpoint with rawContent and contentType properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsWatchlistResource> Update(WaitUntil waitUntil, SecurityInsightsWatchlistData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistResource.Update");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistResource>(Response.FromValue(new SecurityInsightsWatchlistResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
