// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class KeyVaultAndSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceVault");
            JsonSerializer.Serialize(writer, SourceVault); writer.WritePropertyName("secretUrl");
            writer.WriteStringValue(SecretUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static KeyVaultAndSecretReference DeserializeKeyVaultAndSecretReference(JsonElement element)
        {
            WritableSubResource sourceVault = default;
            Uri secretUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"))
                {
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretUrl"))
                {
                    secretUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultAndSecretReference(sourceVault, secretUrl);
        }
    }
}
