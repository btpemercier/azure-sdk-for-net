// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing the FactoryVirtualNetwork data model. </summary>
    public partial class FactoryVirtualNetworkData : ResourceData
    {
        /// <summary> Initializes a new instance of FactoryVirtualNetworkData. </summary>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public FactoryVirtualNetworkData(ManagedVirtualNetwork properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of FactoryVirtualNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Managed Virtual Network properties. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal FactoryVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedVirtualNetwork properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> Managed Virtual Network properties. </summary>
        public ManagedVirtualNetwork Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
