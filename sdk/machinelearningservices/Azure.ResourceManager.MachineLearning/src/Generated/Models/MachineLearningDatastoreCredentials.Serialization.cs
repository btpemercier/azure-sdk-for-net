// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDatastoreCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("credentialsType");
            writer.WriteStringValue(CredentialsType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningDatastoreCredentials DeserializeMachineLearningDatastoreCredentials(JsonElement element)
        {
            if (element.TryGetProperty("credentialsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AccountKey": return MachineLearningAccountKeyDatastoreCredentials.DeserializeMachineLearningAccountKeyDatastoreCredentials(element);
                    case "Certificate": return MachineLearningCertificateDatastoreCredentials.DeserializeMachineLearningCertificateDatastoreCredentials(element);
                    case "None": return MachineLearningNoneDatastoreCredentials.DeserializeMachineLearningNoneDatastoreCredentials(element);
                    case "Sas": return MachineLearningSasDatastoreCredentials.DeserializeMachineLearningSasDatastoreCredentials(element);
                    case "ServicePrincipal": return MachineLearningServicePrincipalDatastoreCredentials.DeserializeMachineLearningServicePrincipalDatastoreCredentials(element);
                }
            }
            return UnknownDatastoreCredentials.DeserializeUnknownDatastoreCredentials(element);
        }
    }
}
