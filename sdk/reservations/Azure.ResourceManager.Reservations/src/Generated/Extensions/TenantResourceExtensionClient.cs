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
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _reservationDetailReservationClientDiagnostics;
        private ReservationRestOperations _reservationDetailReservationRestClient;
        private ClientDiagnostics _reservationOrderClientDiagnostics;
        private ReservationOrderRestOperations _reservationOrderRestClient;
        private ClientDiagnostics _calculateExchangeClientDiagnostics;
        private CalculateExchangeRestOperations _calculateExchangeRestClient;
        private ClientDiagnostics _exchangeClientDiagnostics;
        private ExchangeRestOperations _exchangeRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ReservationDetailReservationClientDiagnostics => _reservationDetailReservationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationDetailResource.ResourceType.Namespace, Diagnostics);
        private ReservationRestOperations ReservationDetailReservationRestClient => _reservationDetailReservationRestClient ??= new ReservationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ReservationDetailResource.ResourceType));
        private ClientDiagnostics ReservationOrderClientDiagnostics => _reservationOrderClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationOrderResource.ResourceType.Namespace, Diagnostics);
        private ReservationOrderRestOperations ReservationOrderRestClient => _reservationOrderRestClient ??= new ReservationOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ReservationOrderResource.ResourceType));
        private ClientDiagnostics CalculateExchangeClientDiagnostics => _calculateExchangeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CalculateExchangeRestOperations CalculateExchangeRestClient => _calculateExchangeRestClient ??= new CalculateExchangeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExchangeClientDiagnostics => _exchangeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExchangeRestOperations ExchangeRestClient => _exchangeRestClient ??= new ExchangeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ReservationOrderResources in the TenantResource. </summary>
        /// <returns> An object representing collection of ReservationOrderResources and their operations over a ReservationOrderResource. </returns>
        public virtual ReservationOrderCollection GetReservationOrders()
        {
            return GetCachedClient(Client => new ReservationOrderCollection(Client, Id));
        }

        /// <summary>
        /// List the reservations and the roll up counts of reservations group by provisioning states that the user has access to in the current tenant.
        /// Request Path: /providers/Microsoft.Capacity/reservations
        /// Operation Id: Reservation_ListAll
        /// </summary>
        /// <param name="filter"> May be used to filter by reservation properties. The filter supports &apos;eq&apos;, &apos;or&apos;, and &apos;and&apos;. It does not currently support &apos;ne&apos;, &apos;gt&apos;, &apos;le&apos;, &apos;ge&apos;, or &apos;not&apos;. Reservation properties include sku/name, properties/{appliedScopeType, archived, displayName, displayProvisioningState, effectiveDateTime, expiryDate, provisioningState, quantity, renew, reservedResourceType, term, userFriendlyAppliedScopeType, userFriendlyRenewState}. </param>
        /// <param name="orderby"> May be used to sort order by reservation properties. </param>
        /// <param name="refreshSummary"> To indicate whether to refresh the roll up counts of the reservations group by provisioning states. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="selectedState"> The selected provisioning state. </param>
        /// <param name="take"> To number of reservations to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationDetailResource> GetReservationDetailsAsync(string filter = null, string orderby = null, string refreshSummary = null, float? skiptoken = null, string selectedState = null, float? take = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ReservationDetailReservationRestClient.CreateListAllRequest(filter, orderby, refreshSummary, skiptoken, selectedState, take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ReservationDetailReservationRestClient.CreateListAllNextPageRequest(nextLink, filter, orderby, refreshSummary, skiptoken, selectedState, take);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), ReservationDetailReservationClientDiagnostics, Pipeline, "TenantResourceExtensionClient.GetReservationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the reservations and the roll up counts of reservations group by provisioning states that the user has access to in the current tenant.
        /// Request Path: /providers/Microsoft.Capacity/reservations
        /// Operation Id: Reservation_ListAll
        /// </summary>
        /// <param name="filter"> May be used to filter by reservation properties. The filter supports &apos;eq&apos;, &apos;or&apos;, and &apos;and&apos;. It does not currently support &apos;ne&apos;, &apos;gt&apos;, &apos;le&apos;, &apos;ge&apos;, or &apos;not&apos;. Reservation properties include sku/name, properties/{appliedScopeType, archived, displayName, displayProvisioningState, effectiveDateTime, expiryDate, provisioningState, quantity, renew, reservedResourceType, term, userFriendlyAppliedScopeType, userFriendlyRenewState}. </param>
        /// <param name="orderby"> May be used to sort order by reservation properties. </param>
        /// <param name="refreshSummary"> To indicate whether to refresh the roll up counts of the reservations group by provisioning states. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="selectedState"> The selected provisioning state. </param>
        /// <param name="take"> To number of reservations to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationDetailResource> GetReservationDetails(string filter = null, string orderby = null, string refreshSummary = null, float? skiptoken = null, string selectedState = null, float? take = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ReservationDetailReservationRestClient.CreateListAllRequest(filter, orderby, refreshSummary, skiptoken, selectedState, take);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ReservationDetailReservationRestClient.CreateListAllNextPageRequest(nextLink, filter, orderby, refreshSummary, skiptoken, selectedState, take);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), ReservationDetailReservationClientDiagnostics, Pipeline, "TenantResourceExtensionClient.GetReservationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Calculate price for placing a `ReservationOrder`.
        /// Request Path: /providers/Microsoft.Capacity/calculatePrice
        /// Operation Id: ReservationOrder_Calculate
        /// </summary>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CalculatePriceResult>> CalculateReservationOrderAsync(ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ReservationOrderClientDiagnostics.CreateScope("TenantResourceExtensionClient.CalculateReservationOrder");
            scope.Start();
            try
            {
                var response = await ReservationOrderRestClient.CalculateAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculate price for placing a `ReservationOrder`.
        /// Request Path: /providers/Microsoft.Capacity/calculatePrice
        /// Operation Id: ReservationOrder_Calculate
        /// </summary>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CalculatePriceResult> CalculateReservationOrder(ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ReservationOrderClientDiagnostics.CreateScope("TenantResourceExtensionClient.CalculateReservationOrder");
            scope.Start();
            try
            {
                var response = ReservationOrderRestClient.Calculate(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Calculates price for exchanging `Reservations` if there are no policy errors.
        /// 
        /// Request Path: /providers/Microsoft.Capacity/calculateExchange
        /// Operation Id: CalculateExchange_Post
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing purchases and refunds that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<CalculateExchangeResult>> CalculateReservationExchangeAsync(WaitUntil waitUntil, CalculateExchangeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CalculateExchangeClientDiagnostics.CreateScope("TenantResourceExtensionClient.CalculateReservationExchange");
            scope.Start();
            try
            {
                var response = await CalculateExchangeRestClient.PostAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<CalculateExchangeResult>(new CalculateExchangeResultOperationSource(), CalculateExchangeClientDiagnostics, Pipeline, CalculateExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Calculates price for exchanging `Reservations` if there are no policy errors.
        /// 
        /// Request Path: /providers/Microsoft.Capacity/calculateExchange
        /// Operation Id: CalculateExchange_Post
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing purchases and refunds that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<CalculateExchangeResult> CalculateReservationExchange(WaitUntil waitUntil, CalculateExchangeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CalculateExchangeClientDiagnostics.CreateScope("TenantResourceExtensionClient.CalculateReservationExchange");
            scope.Start();
            try
            {
                var response = CalculateExchangeRestClient.Post(content, cancellationToken);
                var operation = new ReservationsArmOperation<CalculateExchangeResult>(new CalculateExchangeResultOperationSource(), CalculateExchangeClientDiagnostics, Pipeline, CalculateExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns one or more `Reservations` in exchange for one or more `Reservation` purchases.
        /// 
        /// Request Path: /providers/Microsoft.Capacity/exchange
        /// Operation Id: Exchange_Post
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing the refunds and purchases that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<ExchangeResult>> ExchangeAsync(WaitUntil waitUntil, ExchangeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ExchangeClientDiagnostics.CreateScope("TenantResourceExtensionClient.Exchange");
            scope.Start();
            try
            {
                var response = await ExchangeRestClient.PostAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ExchangeResult>(new ExchangeResultOperationSource(), ExchangeClientDiagnostics, Pipeline, ExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns one or more `Reservations` in exchange for one or more `Reservation` purchases.
        /// 
        /// Request Path: /providers/Microsoft.Capacity/exchange
        /// Operation Id: Exchange_Post
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Request containing the refunds and purchases that need to be executed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<ExchangeResult> Exchange(WaitUntil waitUntil, ExchangeContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ExchangeClientDiagnostics.CreateScope("TenantResourceExtensionClient.Exchange");
            scope.Start();
            try
            {
                var response = ExchangeRestClient.Post(content, cancellationToken);
                var operation = new ReservationsArmOperation<ExchangeResult>(new ExchangeResultOperationSource(), ExchangeClientDiagnostics, Pipeline, ExchangeRestClient.CreatePostRequest(content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
