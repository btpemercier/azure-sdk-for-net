// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuInfo. </summary>
    public partial class ResourceTypeSkuInfo
    {
        /// <summary> Initializes a new instance of ResourceTypeSkuInfo. </summary>
        /// <param name="skuSettings"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="skuSettings"/> is null. </exception>
        public ResourceTypeSkuInfo(IEnumerable<SkuSetting> skuSettings)
        {
            Argument.AssertNotNull(skuSettings, nameof(skuSettings));

            SkuSettings = skuSettings.ToList();
        }

        /// <summary> Initializes a new instance of ResourceTypeSkuInfo. </summary>
        /// <param name="skuSettings"></param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        internal ResourceTypeSkuInfo(IList<SkuSetting> skuSettings, ProvisioningState? provisioningState)
        {
            SkuSettings = skuSettings;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets the sku settings. </summary>
        public IList<SkuSetting> SkuSettings { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
    }
}
