// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SubscriptionSecurityAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionSecurityAlertResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionSecurityAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="SecurityCenterLocationResource" /> using the GetSubscriptionSecurityAlert method.
    /// </summary>
    public partial class SubscriptionSecurityAlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionSecurityAlertResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation ascLocation, string alertName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionSecurityAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _subscriptionSecurityAlertAlertsRestClient;
        private readonly SecurityAlertData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityAlertResource"/> class for mocking. </summary>
        protected SubscriptionSecurityAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionSecurityAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionSecurityAlertResource(ArmClient client, SecurityAlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionSecurityAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionSecurityAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionSecurityAlertAlertsApiVersion);
            _subscriptionSecurityAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionSecurityAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/alerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityAlertData Data
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

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionSecurityAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevelAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated with a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionSecurityAlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.GetSubscriptionLevel(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToDismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DismissAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToDismissAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/dismiss</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToDismiss</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Dismiss(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToDismiss(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToResolve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResolveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Resolve");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToResolveAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/resolve</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToResolve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Resolve(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Resolve");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToResolve(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToActivate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ActivateAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Activate");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToActivateAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/activate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToActivate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Activate(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.Activate");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToActivate(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToInProgress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateSatateToInProgressAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.UpdateSatateToInProgress");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToInProgressAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the alert&apos;s state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}/inProgress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_UpdateSubscriptionLevelStateToInProgress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateSatateToInProgress(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSecurityAlertAlertsClientDiagnostics.CreateScope("SubscriptionSecurityAlertResource.UpdateSatateToInProgress");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityAlertAlertsRestClient.UpdateSubscriptionLevelStateToInProgress(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
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
