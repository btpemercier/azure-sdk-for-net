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
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private DeviceUpdateRestOperations _defaultRestClient;
        private ClientDiagnostics _deviceUpdateAccountAccountsClientDiagnostics;
        private AccountsRestOperations _deviceUpdateAccountAccountsRestClient;

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

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DeviceUpdateRestOperations DefaultRestClient => _defaultRestClient ??= new DeviceUpdateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DeviceUpdateAccountAccountsClientDiagnostics => _deviceUpdateAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", DeviceUpdateAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations DeviceUpdateAccountAccountsRestClient => _deviceUpdateAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DeviceUpdateAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResponse>> CheckDeviceUpdateNameAvailabilityAsync(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDeviceUpdateNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResponse> CheckDeviceUpdateNameAvailability(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDeviceUpdateNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdateAccountResource> GetDeviceUpdateAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeviceUpdateAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeviceUpdateAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeviceUpdateAccountResource(Client, DeviceUpdateAccountData.DeserializeDeviceUpdateAccountData(e)), DeviceUpdateAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeviceUpdateAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdateAccountResource> GetDeviceUpdateAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeviceUpdateAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DeviceUpdateAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeviceUpdateAccountResource(Client, DeviceUpdateAccountData.DeserializeDeviceUpdateAccountData(e)), DeviceUpdateAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeviceUpdateAccounts", "value", "nextLink", cancellationToken);
        }
    }
}
