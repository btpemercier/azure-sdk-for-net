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

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchAccountDetectorResource" /> and their operations.
    /// Each <see cref="BatchAccountDetectorResource" /> in the collection will belong to the same instance of <see cref="BatchAccountResource" />.
    /// To get a <see cref="BatchAccountDetectorCollection" /> instance call the GetBatchAccountDetectors method from an instance of <see cref="BatchAccountResource" />.
    /// </summary>
    public partial class BatchAccountDetectorCollection : ArmCollection, IEnumerable<BatchAccountDetectorResource>, IAsyncEnumerable<BatchAccountDetectorResource>
    {
        private readonly ClientDiagnostics _batchAccountDetectorBatchAccountClientDiagnostics;
        private readonly BatchAccountRestOperations _batchAccountDetectorBatchAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchAccountDetectorCollection"/> class for mocking. </summary>
        protected BatchAccountDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchAccountDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchAccountDetectorBatchAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchAccountDetectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchAccountDetectorResource.ResourceType, out string batchAccountDetectorBatchAccountApiVersion);
            _batchAccountDetectorBatchAccountRestClient = new BatchAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchAccountDetectorBatchAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the given detector for a given Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}
        /// Operation Id: BatchAccount_GetDetector
        /// </summary>
        /// <param name="detectorId"> The name of the detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorId"/> is null. </exception>
        public virtual async Task<Response<BatchAccountDetectorResource>> GetAsync(string detectorId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorId, nameof(detectorId));

            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchAccountDetectorBatchAccountRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the given detector for a given Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}
        /// Operation Id: BatchAccount_GetDetector
        /// </summary>
        /// <param name="detectorId"> The name of the detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorId"/> is null. </exception>
        public virtual Response<BatchAccountDetectorResource> Get(string detectorId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorId, nameof(detectorId));

            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _batchAccountDetectorBatchAccountRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the detectors available for a given Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors
        /// Operation Id: BatchAccount_ListDetectors
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchAccountDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchAccountDetectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountDetectorBatchAccountRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountDetectorBatchAccountRestClient.CreateListDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchAccountDetectorResource(Client, BatchAccountDetectorData.DeserializeBatchAccountDetectorData(e)), _batchAccountDetectorBatchAccountClientDiagnostics, Pipeline, "BatchAccountDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the detectors available for a given Batch account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors
        /// Operation Id: BatchAccount_ListDetectors
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchAccountDetectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchAccountDetectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchAccountDetectorBatchAccountRestClient.CreateListDetectorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchAccountDetectorBatchAccountRestClient.CreateListDetectorsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchAccountDetectorResource(Client, BatchAccountDetectorData.DeserializeBatchAccountDetectorData(e)), _batchAccountDetectorBatchAccountClientDiagnostics, Pipeline, "BatchAccountDetectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}
        /// Operation Id: BatchAccount_GetDetector
        /// </summary>
        /// <param name="detectorId"> The name of the detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string detectorId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorId, nameof(detectorId));

            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchAccountDetectorBatchAccountRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}
        /// Operation Id: BatchAccount_GetDetector
        /// </summary>
        /// <param name="detectorId"> The name of the detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorId"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorId, nameof(detectorId));

            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchAccountDetectorBatchAccountRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchAccountDetectorResource> IEnumerable<BatchAccountDetectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchAccountDetectorResource> IAsyncEnumerable<BatchAccountDetectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
