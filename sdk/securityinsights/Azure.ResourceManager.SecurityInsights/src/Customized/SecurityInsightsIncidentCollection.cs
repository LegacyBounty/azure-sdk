// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

[assembly: CodeGenSuppressType("SecurityInsightsIncidentCollection")]
namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsIncidentResource" /> and their operations.
    /// Each <see cref="SecurityInsightsIncidentResource" /> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" />.
    /// To get a <see cref="SecurityInsightsIncidentCollection" /> instance call the GetSecurityInsightsIncidents method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" />.
    /// </summary>
    public partial class SecurityInsightsIncidentCollection : ArmCollection, IEnumerable<SecurityInsightsIncidentResource>, IAsyncEnumerable<SecurityInsightsIncidentResource>
    {
        private readonly ClientDiagnostics _securityInsightsIncidentIncidentsClientDiagnostics;
        private readonly IncidentsRestOperations _securityInsightsIncidentIncidentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentCollection"/> class for mocking. </summary>
        protected SecurityInsightsIncidentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsIncidentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsIncidentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsIncidentIncidentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsIncidentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsIncidentResource.ResourceType, out string securityInsightsIncidentIncidentsApiVersion);
            _securityInsightsIncidentIncidentsRestClient = new IncidentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsIncidentIncidentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="data"> The incident. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsIncidentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string incidentId, SecurityInsightsIncidentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentIncidentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentResource>(Response.FromValue(new SecurityInsightsIncidentResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="data"> The incident. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsIncidentResource> CreateOrUpdate(WaitUntil waitUntil, string incidentId, SecurityInsightsIncidentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentIncidentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsIncidentResource>(Response.FromValue(new SecurityInsightsIncidentResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsIncidentResource>> GetAsync(string incidentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentIncidentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a given incident.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> is null. </exception>
        public virtual Response<SecurityInsightsIncidentResource> Get(string incidentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentIncidentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsIncidentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all incidents.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsIncidentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsIncidentResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SecurityInsightsIncidentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityInsightsIncidentIncidentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityInsightsIncidentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityInsightsIncidentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _securityInsightsIncidentIncidentsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityInsightsIncidentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all incidents.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsIncidentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsIncidentResource> GetAll(string filter = null, string orderBy = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<SecurityInsightsIncidentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityInsightsIncidentIncidentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityInsightsIncidentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityInsightsIncidentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _securityInsightsIncidentIncidentsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SecurityInsightsIncidentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string incidentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsIncidentIncidentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/incidents/{incidentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Incidents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="incidentId"> Incident ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="incidentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="incidentId"/> is null. </exception>
        public virtual Response<bool> Exists(string incidentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(incidentId, nameof(incidentId));

            using var scope = _securityInsightsIncidentIncidentsClientDiagnostics.CreateScope("SecurityInsightsIncidentCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsIncidentIncidentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, incidentId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsIncidentResource> IEnumerable<SecurityInsightsIncidentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsIncidentResource> IAsyncEnumerable<SecurityInsightsIncidentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
