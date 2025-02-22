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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridData
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridDataManagerResource" /> and their operations.
    /// Each <see cref="HybridDataManagerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HybridDataManagerCollection" /> instance call the GetHybridDataManagers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HybridDataManagerCollection : ArmCollection, IEnumerable<HybridDataManagerResource>, IAsyncEnumerable<HybridDataManagerResource>
    {
        private readonly ClientDiagnostics _hybridDataManagerDataManagersClientDiagnostics;
        private readonly DataManagersRestOperations _hybridDataManagerDataManagersRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridDataManagerCollection"/> class for mocking. </summary>
        protected HybridDataManagerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridDataManagerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridDataManagerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridDataManagerDataManagersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridData", HybridDataManagerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridDataManagerResource.ResourceType, out string hybridDataManagerDataManagersApiVersion);
            _hybridDataManagerDataManagersRestClient = new DataManagersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridDataManagerDataManagersApiVersion);
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
        /// Creates a new data manager resource with the specified parameters. Existing resources cannot be updated with this API
        /// and should instead be updated with the Update data manager resource API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="data"> Data manager resource details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridDataManagerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataManagerName, HybridDataManagerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridDataManagerDataManagersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridDataArmOperation<HybridDataManagerResource>(new HybridDataManagerOperationSource(Client), _hybridDataManagerDataManagersClientDiagnostics, Pipeline, _hybridDataManagerDataManagersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new data manager resource with the specified parameters. Existing resources cannot be updated with this API
        /// and should instead be updated with the Update data manager resource API.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="data"> Data manager resource details from request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridDataManagerResource> CreateOrUpdate(WaitUntil waitUntil, string dataManagerName, HybridDataManagerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridDataManagerDataManagersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, data, cancellationToken);
                var operation = new HybridDataArmOperation<HybridDataManagerResource>(new HybridDataManagerOperationSource(Client), _hybridDataManagerDataManagersClientDiagnostics, Pipeline, _hybridDataManagerDataManagersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about the specified data manager resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        public virtual async Task<Response<HybridDataManagerResource>> GetAsync(string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridDataManagerDataManagersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridDataManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified data manager resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        public virtual Response<HybridDataManagerResource> Get(string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridDataManagerDataManagersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridDataManagerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the data manager resources available under the given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridDataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridDataManagerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridDataManagerDataManagersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new HybridDataManagerResource(Client, HybridDataManagerData.DeserializeHybridDataManagerData(e)), _hybridDataManagerDataManagersClientDiagnostics, Pipeline, "HybridDataManagerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the data manager resources available under the given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridDataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridDataManagerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridDataManagerDataManagersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new HybridDataManagerResource(Client, HybridDataManagerData.DeserializeHybridDataManagerData(e)), _hybridDataManagerDataManagersClientDiagnostics, Pipeline, "HybridDataManagerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridDataManagerDataManagersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridData/dataManagers/{dataManagerName}
        /// Operation Id: DataManagers_Get
        /// </summary>
        /// <param name="dataManagerName"> The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataManagerName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataManagerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataManagerName, nameof(dataManagerName));

            using var scope = _hybridDataManagerDataManagersClientDiagnostics.CreateScope("HybridDataManagerCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridDataManagerDataManagersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataManagerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridDataManagerResource> IEnumerable<HybridDataManagerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridDataManagerResource> IAsyncEnumerable<HybridDataManagerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
