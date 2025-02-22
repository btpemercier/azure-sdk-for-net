// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resolve health input properties. </summary>
    internal partial class ResolveHealthInputProperties
    {
        /// <summary> Initializes a new instance of ResolveHealthInputProperties. </summary>
        public ResolveHealthInputProperties()
        {
            HealthErrors = new ChangeTrackingList<ResolveHealthError>();
        }

        /// <summary> Health errors. </summary>
        public IList<ResolveHealthError> HealthErrors { get; }
    }
}
