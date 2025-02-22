// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Datastore Service Principal secrets.
    /// Serialized Name: ServicePrincipalDatastoreSecrets
    /// </summary>
    public partial class MachineLearningServicePrincipalDatastoreSecrets : MachineLearningDatastoreSecrets
    {
        /// <summary> Initializes a new instance of MachineLearningServicePrincipalDatastoreSecrets. </summary>
        public MachineLearningServicePrincipalDatastoreSecrets()
        {
            SecretsType = SecretsType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of MachineLearningServicePrincipalDatastoreSecrets. </summary>
        /// <param name="secretsType">
        /// [Required] Credential type used to authentication with storage.
        /// Serialized Name: DatastoreSecrets.secretsType
        /// </param>
        /// <param name="clientSecret">
        /// Service principal secret.
        /// Serialized Name: ServicePrincipalDatastoreSecrets.clientSecret
        /// </param>
        internal MachineLearningServicePrincipalDatastoreSecrets(SecretsType secretsType, string clientSecret) : base(secretsType)
        {
            ClientSecret = clientSecret;
            SecretsType = secretsType;
        }

        /// <summary>
        /// Service principal secret.
        /// Serialized Name: ServicePrincipalDatastoreSecrets.clientSecret
        /// </summary>
        public string ClientSecret { get; set; }
    }
}
