// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class AppConfigurationKeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier");
                writer.WriteStringValue(KeyIdentifier);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId");
                writer.WriteStringValue(IdentityClientId);
            }
            writer.WriteEndObject();
        }

        internal static AppConfigurationKeyVaultProperties DeserializeAppConfigurationKeyVaultProperties(JsonElement element)
        {
            Optional<string> keyIdentifier = default;
            Optional<string> identityClientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationKeyVaultProperties(keyIdentifier.Value, identityClientId.Value);
        }
    }
}
