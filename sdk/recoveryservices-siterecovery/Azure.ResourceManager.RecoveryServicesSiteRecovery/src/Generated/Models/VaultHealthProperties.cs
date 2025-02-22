// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> class to define the health summary of the Vault. </summary>
    public partial class VaultHealthProperties
    {
        /// <summary> Initializes a new instance of VaultHealthProperties. </summary>
        internal VaultHealthProperties()
        {
            VaultErrors = new ChangeTrackingList<HealthError>();
        }

        /// <summary> Initializes a new instance of VaultHealthProperties. </summary>
        /// <param name="vaultErrors"> The list of errors on the vault. </param>
        /// <param name="protectedItemsHealth"> The list of the health detail of the protected items in the vault. </param>
        /// <param name="fabricsHealth"> The list of the health detail of the fabrics in the vault. </param>
        /// <param name="containersHealth"> The list of the health detail of the containers in the vault. </param>
        internal VaultHealthProperties(IReadOnlyList<HealthError> vaultErrors, ResourceHealthSummary protectedItemsHealth, ResourceHealthSummary fabricsHealth, ResourceHealthSummary containersHealth)
        {
            VaultErrors = vaultErrors;
            ProtectedItemsHealth = protectedItemsHealth;
            FabricsHealth = fabricsHealth;
            ContainersHealth = containersHealth;
        }

        /// <summary> The list of errors on the vault. </summary>
        public IReadOnlyList<HealthError> VaultErrors { get; }
        /// <summary> The list of the health detail of the protected items in the vault. </summary>
        public ResourceHealthSummary ProtectedItemsHealth { get; }
        /// <summary> The list of the health detail of the fabrics in the vault. </summary>
        public ResourceHealthSummary FabricsHealth { get; }
        /// <summary> The list of the health detail of the containers in the vault. </summary>
        public ResourceHealthSummary ContainersHealth { get; }
    }
}
