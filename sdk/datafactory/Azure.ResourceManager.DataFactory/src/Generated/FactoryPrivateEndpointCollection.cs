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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="FactoryPrivateEndpointResource" /> and their operations.
    /// Each <see cref="FactoryPrivateEndpointResource" /> in the collection will belong to the same instance of <see cref="FactoryVirtualNetworkResource" />.
    /// To get a <see cref="FactoryPrivateEndpointCollection" /> instance call the GetFactoryPrivateEndpoints method from an instance of <see cref="FactoryVirtualNetworkResource" />.
    /// </summary>
    public partial class FactoryPrivateEndpointCollection : ArmCollection, IEnumerable<FactoryPrivateEndpointResource>, IAsyncEnumerable<FactoryPrivateEndpointResource>
    {
        private readonly ClientDiagnostics _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics;
        private readonly ManagedPrivateEndpointsRestOperations _factoryPrivateEndpointManagedPrivateEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FactoryPrivateEndpointCollection"/> class for mocking. </summary>
        protected FactoryPrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FactoryPrivateEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FactoryPrivateEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", FactoryPrivateEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FactoryPrivateEndpointResource.ResourceType, out string factoryPrivateEndpointManagedPrivateEndpointsApiVersion);
            _factoryPrivateEndpointManagedPrivateEndpointsRestClient = new ManagedPrivateEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, factoryPrivateEndpointManagedPrivateEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FactoryVirtualNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FactoryVirtualNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: managedPrivateEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="data"> Managed private endpoint resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed private endpoint entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FactoryPrivateEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedPrivateEndpointName, FactoryPrivateEndpointData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<FactoryPrivateEndpointResource>(Response.FromValue(new FactoryPrivateEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a managed private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: managedPrivateEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="data"> Managed private endpoint resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed private endpoint entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FactoryPrivateEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string managedPrivateEndpointName, FactoryPrivateEndpointData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<FactoryPrivateEndpointResource>(Response.FromValue(new FactoryPrivateEndpointResource(Client, response), response.GetRawResponse()));
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
        /// Gets a managed private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: ManagedPrivateEndpoints_Get
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<FactoryPrivateEndpointResource>> GetAsync(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _factoryPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FactoryPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed private endpoint.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: ManagedPrivateEndpoints_Get
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<FactoryPrivateEndpointResource> Get(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _factoryPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FactoryPrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists managed private endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints
        /// Operation Id: ManagedPrivateEndpoints_ListByFactory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FactoryPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FactoryPrivateEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FactoryPrivateEndpointResource(Client, FactoryPrivateEndpointData.DeserializeFactoryPrivateEndpointData(e)), _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "FactoryPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists managed private endpoints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints
        /// Operation Id: ManagedPrivateEndpoints_ListByFactory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FactoryPrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FactoryPrivateEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _factoryPrivateEndpointManagedPrivateEndpointsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FactoryPrivateEndpointResource(Client, FactoryPrivateEndpointData.DeserializeFactoryPrivateEndpointData(e)), _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics, Pipeline, "FactoryPrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: ManagedPrivateEndpoints_Get
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _factoryPrivateEndpointManagedPrivateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}/managedPrivateEndpoints/{managedPrivateEndpointName}
        /// Operation Id: ManagedPrivateEndpoints_Get
        /// </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed private endpoint entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedPrivateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedPrivateEndpointName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedPrivateEndpointName, nameof(managedPrivateEndpointName));

            using var scope = _factoryPrivateEndpointManagedPrivateEndpointsClientDiagnostics.CreateScope("FactoryPrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _factoryPrivateEndpointManagedPrivateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedPrivateEndpointName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FactoryPrivateEndpointResource> IEnumerable<FactoryPrivateEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FactoryPrivateEndpointResource> IAsyncEnumerable<FactoryPrivateEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
