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

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupEngineBaseResource" /> and their operations.
    /// Each <see cref="BackupEngineBaseResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="BackupEngineBaseResourceCollection" /> instance call the GetBackupEngineBaseResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class BackupEngineBaseResourceCollection : ArmCollection, IEnumerable<BackupEngineBaseResource>, IAsyncEnumerable<BackupEngineBaseResource>
    {
        private readonly ClientDiagnostics _backupEngineBaseResourceBackupEnginesClientDiagnostics;
        private readonly BackupEnginesRestOperations _backupEngineBaseResourceBackupEnginesRestClient;
        private readonly string _vaultName;

        /// <summary> Initializes a new instance of the <see cref="BackupEngineBaseResourceCollection"/> class for mocking. </summary>
        protected BackupEngineBaseResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupEngineBaseResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BackupEngineBaseResourceCollection(ArmClient client, ResourceIdentifier id, string vaultName) : base(client, id)
        {
            _vaultName = vaultName;
            _backupEngineBaseResourceBackupEnginesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupEngineBaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupEngineBaseResource.ResourceType, out string backupEngineBaseResourceBackupEnginesApiVersion);
            _backupEngineBaseResourceBackupEnginesRestClient = new BackupEnginesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupEngineBaseResourceBackupEnginesApiVersion);
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
        /// Returns backup management server registered to Recovery Services Vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}
        /// Operation Id: BackupEngines_Get
        /// </summary>
        /// <param name="backupEngineName"> Name of the backup management server. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupEngineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupEngineName"/> is null. </exception>
        public virtual async Task<Response<BackupEngineBaseResource>> GetAsync(string backupEngineName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupEngineName, nameof(backupEngineName));

            using var scope = _backupEngineBaseResourceBackupEnginesClientDiagnostics.CreateScope("BackupEngineBaseResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupEngineBaseResourceBackupEnginesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, backupEngineName, filter, skipToken, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupEngineBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns backup management server registered to Recovery Services Vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}
        /// Operation Id: BackupEngines_Get
        /// </summary>
        /// <param name="backupEngineName"> Name of the backup management server. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupEngineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupEngineName"/> is null. </exception>
        public virtual Response<BackupEngineBaseResource> Get(string backupEngineName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupEngineName, nameof(backupEngineName));

            using var scope = _backupEngineBaseResourceBackupEnginesClientDiagnostics.CreateScope("BackupEngineBaseResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _backupEngineBaseResourceBackupEnginesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, backupEngineName, filter, skipToken, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupEngineBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Backup management servers registered to Recovery Services Vault. Returns a pageable list of servers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines
        /// Operation Id: BackupEngines_List
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackupEngineBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackupEngineBaseResource> GetAllAsync(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupEngineBaseResourceBackupEnginesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupEngineBaseResourceBackupEnginesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BackupEngineBaseResource(Client, BackupEngineBaseResourceData.DeserializeBackupEngineBaseResourceData(e)), _backupEngineBaseResourceBackupEnginesClientDiagnostics, Pipeline, "BackupEngineBaseResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Backup management servers registered to Recovery Services Vault. Returns a pageable list of servers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines
        /// Operation Id: BackupEngines_List
        /// </summary>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackupEngineBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackupEngineBaseResource> GetAll(string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _backupEngineBaseResourceBackupEnginesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _backupEngineBaseResourceBackupEnginesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName, filter, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BackupEngineBaseResource(Client, BackupEngineBaseResourceData.DeserializeBackupEngineBaseResourceData(e)), _backupEngineBaseResourceBackupEnginesClientDiagnostics, Pipeline, "BackupEngineBaseResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}
        /// Operation Id: BackupEngines_Get
        /// </summary>
        /// <param name="backupEngineName"> Name of the backup management server. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupEngineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupEngineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupEngineName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupEngineName, nameof(backupEngineName));

            using var scope = _backupEngineBaseResourceBackupEnginesClientDiagnostics.CreateScope("BackupEngineBaseResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupEngineBaseResourceBackupEnginesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, backupEngineName, filter, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEngines/{backupEngineName}
        /// Operation Id: BackupEngines_Get
        /// </summary>
        /// <param name="backupEngineName"> Name of the backup management server. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupEngineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupEngineName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupEngineName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupEngineName, nameof(backupEngineName));

            using var scope = _backupEngineBaseResourceBackupEnginesClientDiagnostics.CreateScope("BackupEngineBaseResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupEngineBaseResourceBackupEnginesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, backupEngineName, filter, skipToken, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackupEngineBaseResource> IEnumerable<BackupEngineBaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackupEngineBaseResource> IAsyncEnumerable<BackupEngineBaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
