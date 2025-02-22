// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="AlertResource" /> and their operations.
    /// Each <see cref="AlertResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AlertCollection" /> instance call the GetAlerts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AlertCollection : ArmCollection, IEnumerable<AlertResource>, IAsyncEnumerable<AlertResource>
    {
        private readonly ClientDiagnostics _alertReplicationAlertSettingsClientDiagnostics;
        private readonly ReplicationAlertSettingsRestOperations _alertReplicationAlertSettingsRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="AlertCollection"/> class for mocking. </summary>
        protected AlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal AlertCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _alertReplicationAlertSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", AlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AlertResource.ResourceType, out string alertReplicationAlertSettingsApiVersion);
            _alertReplicationAlertSettingsRestClient = new ReplicationAlertSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, alertReplicationAlertSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an email notification(alert) configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertSettingName"> The name of the email notification(alert) configuration. </param>
        /// <param name="content"> The input to configure the email notification(alert). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AlertResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string alertSettingName, AlertCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _alertReplicationAlertSettingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<AlertResource>(Response.FromValue(new AlertResource(Client, response), response.GetRawResponse()));
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
        /// Create or update an email notification(alert) configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alertSettingName"> The name of the email notification(alert) configuration. </param>
        /// <param name="content"> The input to configure the email notification(alert). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AlertResource> CreateOrUpdate(WaitUntil waitUntil, string alertSettingName, AlertCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _alertReplicationAlertSettingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<AlertResource>(Response.FromValue(new AlertResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the specified email notification(alert) configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Get
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual async Task<Response<AlertResource>> GetAsync(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _alertReplicationAlertSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified email notification(alert) configuration.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Get
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual Response<AlertResource> Get(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.Get");
            scope.Start();
            try
            {
                var response = _alertReplicationAlertSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of email notification(alert) configurations for the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings
        /// Operation Id: ReplicationAlertSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertReplicationAlertSettingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertReplicationAlertSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AlertResource(Client, AlertData.DeserializeAlertData(e)), _alertReplicationAlertSettingsClientDiagnostics, Pipeline, "AlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of email notification(alert) configurations for the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings
        /// Operation Id: ReplicationAlertSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _alertReplicationAlertSettingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _alertReplicationAlertSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AlertResource(Client, AlertData.DeserializeAlertData(e)), _alertReplicationAlertSettingsClientDiagnostics, Pipeline, "AlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Get
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _alertReplicationAlertSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationAlertSettings/{alertSettingName}
        /// Operation Id: ReplicationAlertSettings_Get
        /// </summary>
        /// <param name="alertSettingName"> The name of the email notification configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertSettingName, nameof(alertSettingName));

            using var scope = _alertReplicationAlertSettingsClientDiagnostics.CreateScope("AlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _alertReplicationAlertSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, alertSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AlertResource> IEnumerable<AlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AlertResource> IAsyncEnumerable<AlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
