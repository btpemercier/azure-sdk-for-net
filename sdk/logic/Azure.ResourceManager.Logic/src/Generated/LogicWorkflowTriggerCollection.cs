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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowTriggerResource" /> and their operations.
    /// Each <see cref="LogicWorkflowTriggerResource" /> in the collection will belong to the same instance of <see cref="LogicWorkflowResource" />.
    /// To get a <see cref="LogicWorkflowTriggerCollection" /> instance call the GetLogicWorkflowTriggers method from an instance of <see cref="LogicWorkflowResource" />.
    /// </summary>
    public partial class LogicWorkflowTriggerCollection : ArmCollection, IEnumerable<LogicWorkflowTriggerResource>, IAsyncEnumerable<LogicWorkflowTriggerResource>
    {
        private readonly ClientDiagnostics _logicWorkflowTriggerWorkflowTriggersClientDiagnostics;
        private readonly WorkflowTriggersRestOperations _logicWorkflowTriggerWorkflowTriggersRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerCollection"/> class for mocking. </summary>
        protected LogicWorkflowTriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowTriggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowTriggerWorkflowTriggersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowTriggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowTriggerResource.ResourceType, out string logicWorkflowTriggerWorkflowTriggersApiVersion);
            _logicWorkflowTriggerWorkflowTriggersRestClient = new WorkflowTriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowTriggerWorkflowTriggersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LogicWorkflowResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LogicWorkflowResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="triggerName"> The workflow trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowTriggerResource>> GetAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="triggerName"> The workflow trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<LogicWorkflowTriggerResource> Get(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of workflow triggers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers
        /// Operation Id: WorkflowTriggers_List
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowTriggerResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowTriggerWorkflowTriggersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowTriggerWorkflowTriggersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowTriggerResource(Client, LogicWorkflowTriggerData.DeserializeLogicWorkflowTriggerData(e)), _logicWorkflowTriggerWorkflowTriggersClientDiagnostics, Pipeline, "LogicWorkflowTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflow triggers.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers
        /// Operation Id: WorkflowTriggers_List
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowTriggerResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowTriggerWorkflowTriggersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowTriggerWorkflowTriggersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowTriggerResource(Client, LogicWorkflowTriggerData.DeserializeLogicWorkflowTriggerData(e)), _logicWorkflowTriggerWorkflowTriggersClientDiagnostics, Pipeline, "LogicWorkflowTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="triggerName"> The workflow trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}
        /// Operation Id: WorkflowTriggers_Get
        /// </summary>
        /// <param name="triggerName"> The workflow trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<bool> Exists(string triggerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowTriggerResource> IEnumerable<LogicWorkflowTriggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowTriggerResource> IAsyncEnumerable<LogicWorkflowTriggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
