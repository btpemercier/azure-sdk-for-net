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

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing a collection of <see cref="IotHubCertificateDescriptionResource" /> and their operations.
    /// Each <see cref="IotHubCertificateDescriptionResource" /> in the collection will belong to the same instance of <see cref="IotHubDescriptionResource" />.
    /// To get an <see cref="IotHubCertificateDescriptionCollection" /> instance call the GetIotHubCertificateDescriptions method from an instance of <see cref="IotHubDescriptionResource" />.
    /// </summary>
    public partial class IotHubCertificateDescriptionCollection : ArmCollection, IEnumerable<IotHubCertificateDescriptionResource>, IAsyncEnumerable<IotHubCertificateDescriptionResource>
    {
        private readonly ClientDiagnostics _iotHubCertificateDescriptionCertificatesClientDiagnostics;
        private readonly CertificatesRestOperations _iotHubCertificateDescriptionCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotHubCertificateDescriptionCollection"/> class for mocking. </summary>
        protected IotHubCertificateDescriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotHubCertificateDescriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotHubCertificateDescriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotHubCertificateDescriptionCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotHub", IotHubCertificateDescriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotHubCertificateDescriptionResource.ResourceType, out string iotHubCertificateDescriptionCertificatesApiVersion);
            _iotHubCertificateDescriptionCertificatesRestClient = new CertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotHubCertificateDescriptionCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotHubDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotHubDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds new or replaces existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the Certificate. Do not specify for creating a brand new certificate. Required to update an existing certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotHubCertificateDescriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, IotHubCertificateDescriptionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotHubCertificateDescriptionCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new IotHubArmOperation<IotHubCertificateDescriptionResource>(Response.FromValue(new IotHubCertificateDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Adds new or replaces existing certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the Certificate. Do not specify for creating a brand new certificate. Required to update an existing certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotHubCertificateDescriptionResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, IotHubCertificateDescriptionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotHubCertificateDescriptionCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, ifMatch, cancellationToken);
                var operation = new IotHubArmOperation<IotHubCertificateDescriptionResource>(Response.FromValue(new IotHubCertificateDescriptionResource(Client, response), response.GetRawResponse()));
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
        /// Returns the certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<IotHubCertificateDescriptionResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotHubCertificateDescriptionCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubCertificateDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the certificate.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<IotHubCertificateDescriptionResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _iotHubCertificateDescriptionCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotHubCertificateDescriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of certificates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates
        /// Operation Id: Certificates_ListByIotHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotHubCertificateDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotHubCertificateDescriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotHubCertificateDescriptionCertificatesRestClient.CreateListByIotHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new IotHubCertificateDescriptionResource(Client, IotHubCertificateDescriptionData.DeserializeIotHubCertificateDescriptionData(e)), _iotHubCertificateDescriptionCertificatesClientDiagnostics, Pipeline, "IotHubCertificateDescriptionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns the list of certificates.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates
        /// Operation Id: Certificates_ListByIotHub
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotHubCertificateDescriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotHubCertificateDescriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotHubCertificateDescriptionCertificatesRestClient.CreateListByIotHubRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new IotHubCertificateDescriptionResource(Client, IotHubCertificateDescriptionData.DeserializeIotHubCertificateDescriptionData(e)), _iotHubCertificateDescriptionCertificatesClientDiagnostics, Pipeline, "IotHubCertificateDescriptionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotHubCertificateDescriptionCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}/certificates/{certificateName}
        /// Operation Id: Certificates_Get
        /// </summary>
        /// <param name="certificateName"> The name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _iotHubCertificateDescriptionCertificatesClientDiagnostics.CreateScope("IotHubCertificateDescriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotHubCertificateDescriptionCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotHubCertificateDescriptionResource> IEnumerable<IotHubCertificateDescriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotHubCertificateDescriptionResource> IAsyncEnumerable<IotHubCertificateDescriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
