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

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _userAssignedIdentityClientDiagnostics;
        private UserAssignedIdentitiesRestOperations _userAssignedIdentityRestClient;

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

        private ClientDiagnostics UserAssignedIdentityClientDiagnostics => _userAssignedIdentityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", UserAssignedIdentityResource.ResourceType.Namespace, Diagnostics);
        private UserAssignedIdentitiesRestOperations UserAssignedIdentityRestClient => _userAssignedIdentityRestClient ??= new UserAssignedIdentitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(UserAssignedIdentityResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ManagedIdentity/userAssignedIdentities
        /// Operation Id: UserAssignedIdentities_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UserAssignedIdentityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UserAssignedIdentityResource> GetUserAssignedIdentitiesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UserAssignedIdentityRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UserAssignedIdentityRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), UserAssignedIdentityClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUserAssignedIdentities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the userAssignedIdentities available under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ManagedIdentity/userAssignedIdentities
        /// Operation Id: UserAssignedIdentities_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UserAssignedIdentityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UserAssignedIdentityResource> GetUserAssignedIdentities(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UserAssignedIdentityRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UserAssignedIdentityRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UserAssignedIdentityResource(Client, UserAssignedIdentityData.DeserializeUserAssignedIdentityData(e)), UserAssignedIdentityClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetUserAssignedIdentities", "value", "nextLink", cancellationToken);
        }
    }
}
