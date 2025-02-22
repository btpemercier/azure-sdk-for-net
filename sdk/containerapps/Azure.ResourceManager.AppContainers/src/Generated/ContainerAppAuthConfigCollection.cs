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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppAuthConfigResource" /> and their operations.
    /// Each <see cref="ContainerAppAuthConfigResource" /> in the collection will belong to the same instance of <see cref="ContainerAppResource" />.
    /// To get a <see cref="ContainerAppAuthConfigCollection" /> instance call the GetContainerAppAuthConfigs method from an instance of <see cref="ContainerAppResource" />.
    /// </summary>
    public partial class ContainerAppAuthConfigCollection : ArmCollection, IEnumerable<ContainerAppAuthConfigResource>, IAsyncEnumerable<ContainerAppAuthConfigResource>
    {
        private readonly ClientDiagnostics _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics;
        private readonly ContainerAppsAuthConfigsRestOperations _containerAppAuthConfigContainerAppsAuthConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppAuthConfigCollection"/> class for mocking. </summary>
        protected ContainerAppAuthConfigCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppAuthConfigCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppAuthConfigCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppAuthConfigResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppAuthConfigResource.ResourceType, out string containerAppAuthConfigContainerAppsAuthConfigsApiVersion);
            _containerAppAuthConfigContainerAppsAuthConfigsRestClient = new ContainerAppsAuthConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppAuthConfigContainerAppsAuthConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the AuthConfig for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="data"> Properties used to create a Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppAuthConfigResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authConfigName, ContainerAppAuthConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppAuthConfigResource>(Response.FromValue(new ContainerAppAuthConfigResource(Client, response), response.GetRawResponse()));
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
        /// Create or update the AuthConfig for a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="data"> Properties used to create a Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppAuthConfigResource> CreateOrUpdate(WaitUntil waitUntil, string authConfigName, ContainerAppAuthConfigData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppAuthConfigResource>(Response.FromValue(new ContainerAppAuthConfigResource(Client, response), response.GetRawResponse()));
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
        /// Get a AuthConfig of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_Get
        /// </summary>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppAuthConfigResource>> GetAsync(string authConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppAuthConfigContainerAppsAuthConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppAuthConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AuthConfig of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_Get
        /// </summary>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> is null. </exception>
        public virtual Response<ContainerAppAuthConfigResource> Get(string authConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppAuthConfigContainerAppsAuthConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppAuthConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Container App AuthConfigs in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs
        /// Operation Id: ContainerAppsAuthConfigs_ListByContainerApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppAuthConfigResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppAuthConfigResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateListByContainerAppRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateListByContainerAppNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppAuthConfigResource(Client, ContainerAppAuthConfigData.DeserializeContainerAppAuthConfigData(e)), _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics, Pipeline, "ContainerAppAuthConfigCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Container App AuthConfigs in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs
        /// Operation Id: ContainerAppsAuthConfigs_ListByContainerApp
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppAuthConfigResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppAuthConfigResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateListByContainerAppRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppAuthConfigContainerAppsAuthConfigsRestClient.CreateListByContainerAppNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppAuthConfigResource(Client, ContainerAppAuthConfigData.DeserializeContainerAppAuthConfigData(e)), _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics, Pipeline, "ContainerAppAuthConfigCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_Get
        /// </summary>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppAuthConfigContainerAppsAuthConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/authConfigs/{authConfigName}
        /// Operation Id: ContainerAppsAuthConfigs_Get
        /// </summary>
        /// <param name="authConfigName"> Name of the Container App AuthConfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authConfigName"/> is null. </exception>
        public virtual Response<bool> Exists(string authConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authConfigName, nameof(authConfigName));

            using var scope = _containerAppAuthConfigContainerAppsAuthConfigsClientDiagnostics.CreateScope("ContainerAppAuthConfigCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppAuthConfigContainerAppsAuthConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authConfigName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppAuthConfigResource> IEnumerable<ContainerAppAuthConfigResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppAuthConfigResource> IAsyncEnumerable<ContainerAppAuthConfigResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
