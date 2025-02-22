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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="BestPracticeResource" /> and their operations.
    /// Each <see cref="BestPracticeResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="BestPracticeCollection" /> instance call the GetBestPractices method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class BestPracticeCollection : ArmCollection, IEnumerable<BestPracticeResource>, IAsyncEnumerable<BestPracticeResource>
    {
        private readonly ClientDiagnostics _bestPracticeClientDiagnostics;
        private readonly BestPracticesRestOperations _bestPracticeRestClient;

        /// <summary> Initializes a new instance of the <see cref="BestPracticeCollection"/> class for mocking. </summary>
        protected BestPracticeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BestPracticeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BestPracticeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bestPracticeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", BestPracticeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BestPracticeResource.ResourceType, out string bestPracticeApiVersion);
            _bestPracticeRestClient = new BestPracticesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bestPracticeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// Request Path: /providers/Microsoft.Automanage/bestPractices/{bestPracticeName}
        /// Operation Id: BestPractices_Get
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual async Task<Response<BestPracticeResource>> GetAsync(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeCollection.Get");
            scope.Start();
            try
            {
                var response = await _bestPracticeRestClient.GetAsync(bestPracticeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// Request Path: /providers/Microsoft.Automanage/bestPractices/{bestPracticeName}
        /// Operation Id: BestPractices_Get
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual Response<BestPracticeResource> Get(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeCollection.Get");
            scope.Start();
            try
            {
                var response = _bestPracticeRestClient.Get(bestPracticeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of Automanage best practices
        /// Request Path: /providers/Microsoft.Automanage/bestPractices
        /// Operation Id: BestPractices_ListByTenant
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BestPracticeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BestPracticeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bestPracticeRestClient.CreateListByTenantRequest();
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new BestPracticeResource(Client, BestPracticeData.DeserializeBestPracticeData(e)), _bestPracticeClientDiagnostics, Pipeline, "BestPracticeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of Automanage best practices
        /// Request Path: /providers/Microsoft.Automanage/bestPractices
        /// Operation Id: BestPractices_ListByTenant
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BestPracticeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BestPracticeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _bestPracticeRestClient.CreateListByTenantRequest();
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new BestPracticeResource(Client, BestPracticeData.DeserializeBestPracticeData(e)), _bestPracticeClientDiagnostics, Pipeline, "BestPracticeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Automanage/bestPractices/{bestPracticeName}
        /// Operation Id: BestPractices_Get
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _bestPracticeRestClient.GetAsync(bestPracticeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /providers/Microsoft.Automanage/bestPractices/{bestPracticeName}
        /// Operation Id: BestPractices_Get
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual Response<bool> Exists(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _bestPracticeClientDiagnostics.CreateScope("BestPracticeCollection.Exists");
            scope.Start();
            try
            {
                var response = _bestPracticeRestClient.Get(bestPracticeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BestPracticeResource> IEnumerable<BestPracticeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BestPracticeResource> IAsyncEnumerable<BestPracticeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
