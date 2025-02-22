// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthcareApis.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A Class representing a HealthcareApisIotConnector along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HealthcareApisIotConnectorResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHealthcareApisIotConnectorResource method.
    /// Otherwise you can get one from its parent resource <see cref="HealthcareApisWorkspaceResource" /> using the GetHealthcareApisIotConnector method.
    /// </summary>
    public partial class HealthcareApisIotConnectorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HealthcareApisIotConnectorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string iotConnectorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _healthcareApisIotConnectorIotConnectorsClientDiagnostics;
        private readonly IotConnectorsRestOperations _healthcareApisIotConnectorIotConnectorsRestClient;
        private readonly HealthcareApisIotConnectorData _data;

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotConnectorResource"/> class for mocking. </summary>
        protected HealthcareApisIotConnectorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HealthcareApisIotConnectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HealthcareApisIotConnectorResource(ArmClient client, HealthcareApisIotConnectorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotConnectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HealthcareApisIotConnectorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthcareApisIotConnectorIotConnectorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisIotConnectorIotConnectorsApiVersion);
            _healthcareApisIotConnectorIotConnectorsRestClient = new IotConnectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisIotConnectorIotConnectorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/workspaces/iotconnectors";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HealthcareApisIotConnectorData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of HealthcareApisIotFhirDestinationResources in the HealthcareApisIotConnector. </summary>
        /// <returns> An object representing collection of HealthcareApisIotFhirDestinationResources and their operations over a HealthcareApisIotFhirDestinationResource. </returns>
        public virtual HealthcareApisIotFhirDestinationCollection GetHealthcareApisIotFhirDestinations()
        {
            return GetCachedClient(Client => new HealthcareApisIotFhirDestinationCollection(Client, Id));
        }

        /// <summary>
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HealthcareApisIotFhirDestinationResource>> GetHealthcareApisIotFhirDestinationAsync(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            return await GetHealthcareApisIotFhirDestinations().GetAsync(fhirDestinationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}
        /// Operation Id: IotConnectorFhirDestination_Get
        /// </summary>
        /// <param name="fhirDestinationName"> The name of IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fhirDestinationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirDestinationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<HealthcareApisIotFhirDestinationResource> GetHealthcareApisIotFhirDestination(string fhirDestinationName, CancellationToken cancellationToken = default)
        {
            return GetHealthcareApisIotFhirDestinations().Get(fhirDestinationName, cancellationToken);
        }

        /// <summary>
        /// Gets the properties of the specified IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HealthcareApisIotConnectorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Get");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HealthcareApisIotConnectorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Get");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotConnectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Delete");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation(_healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Delete");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HealthcareApisArmOperation(_healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Patch an IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The parameters for updating an IoT Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<HealthcareApisIotConnectorResource>> UpdateAsync(WaitUntil waitUntil, HealthcareApisIotConnectorPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Update");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotConnectorIotConnectorsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotConnectorResource>(new HealthcareApisIotConnectorOperationSource(Client), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Patch an IoT Connector.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The parameters for updating an IoT Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<HealthcareApisIotConnectorResource> Update(WaitUntil waitUntil, HealthcareApisIotConnectorPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.Update");
            scope.Start();
            try
            {
                var response = _healthcareApisIotConnectorIotConnectorsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotConnectorResource>(new HealthcareApisIotConnectorOperationSource(Client), _healthcareApisIotConnectorIotConnectorsClientDiagnostics, Pipeline, _healthcareApisIotConnectorIotConnectorsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<HealthcareApisIotConnectorResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<HealthcareApisIotConnectorResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<HealthcareApisIotConnectorResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<HealthcareApisIotConnectorResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<HealthcareApisIotConnectorResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _healthcareApisIotConnectorIotConnectorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}
        /// Operation Id: IotConnectors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<HealthcareApisIotConnectorResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _healthcareApisIotConnectorIotConnectorsClientDiagnostics.CreateScope("HealthcareApisIotConnectorResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _healthcareApisIotConnectorIotConnectorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new HealthcareApisIotConnectorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new HealthcareApisIotConnectorPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
