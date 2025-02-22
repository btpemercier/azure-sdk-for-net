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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubResource" /> and their operations.
    /// Each <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubResource" /> in the collection will belong to the same instance of <see cref="SynapsePrivateLinkHubResource" />.
    /// To get a <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubCollection" /> instance call the GetSynapsePrivateEndpointConnectionForPrivateLinkHubs method from an instance of <see cref="SynapsePrivateLinkHubResource" />.
    /// </summary>
    public partial class SynapsePrivateEndpointConnectionForPrivateLinkHubCollection : ArmCollection, IEnumerable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource>, IAsyncEnumerable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource>
    {
        private readonly ClientDiagnostics _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics;
        private readonly PrivateEndpointConnectionsPrivateLinkHubRestOperations _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubCollection"/> class for mocking. </summary>
        protected SynapsePrivateEndpointConnectionForPrivateLinkHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapsePrivateEndpointConnectionForPrivateLinkHubCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapsePrivateEndpointConnectionForPrivateLinkHubResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapsePrivateEndpointConnectionForPrivateLinkHubResource.ResourceType, out string synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubApiVersion);
            _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient = new PrivateEndpointConnectionsPrivateLinkHubRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapsePrivateLinkHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapsePrivateLinkHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get all PrivateEndpointConnection in the PrivateLinkHub by name
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the privateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<SynapsePrivateEndpointConnectionForPrivateLinkHubResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapsePrivateEndpointConnectionForPrivateLinkHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all PrivateEndpointConnection in the PrivateLinkHub by name
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the privateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<SynapsePrivateEndpointConnectionForPrivateLinkHubResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.Get");
            scope.Start();
            try
            {
                var response = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapsePrivateEndpointConnectionForPrivateLinkHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all PrivateEndpointConnections in the PrivateLinkHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapsePrivateEndpointConnectionForPrivateLinkHubResource(Client, SynapsePrivateEndpointConnectionForPrivateLinkHubData.DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(e)), _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics, Pipeline, "SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all PrivateEndpointConnections in the PrivateLinkHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapsePrivateEndpointConnectionForPrivateLinkHubResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapsePrivateEndpointConnectionForPrivateLinkHubResource(Client, SynapsePrivateEndpointConnectionForPrivateLinkHubData.DeserializeSynapsePrivateEndpointConnectionForPrivateLinkHubData(e)), _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics, Pipeline, "SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the privateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/privateLinkHubs/{privateLinkHubName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnectionsPrivateLinkHub_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> Name of the privateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionForPrivateLinkHubCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapsePrivateEndpointConnectionForPrivateLinkHubPrivateEndpointConnectionsPrivateLinkHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapsePrivateEndpointConnectionForPrivateLinkHubResource> IEnumerable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapsePrivateEndpointConnectionForPrivateLinkHubResource> IAsyncEnumerable<SynapsePrivateEndpointConnectionForPrivateLinkHubResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
