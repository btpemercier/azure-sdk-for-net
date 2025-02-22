// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint");
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint");
                writer.WriteStringValue(TokenEndpoint);
            }
            if (Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer");
                writer.WriteStringValue(Issuer);
            }
            if (Optional.IsDefined(CertificationUri))
            {
                writer.WritePropertyName("certificationUri");
                writer.WriteStringValue(CertificationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(WellKnownOpenIdConfiguration))
            {
                writer.WritePropertyName("wellKnownOpenIdConfiguration");
                writer.WriteStringValue(WellKnownOpenIdConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppOpenIdConnectConfig DeserializeContainerAppOpenIdConnectConfig(JsonElement element)
        {
            Optional<string> authorizationEndpoint = default;
            Optional<string> tokenEndpoint = default;
            Optional<string> issuer = default;
            Optional<Uri> certificationUri = default;
            Optional<string> wellKnownOpenIdConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationEndpoint"))
                {
                    authorizationEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpoint"))
                {
                    tokenEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificationUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        certificationUri = null;
                        continue;
                    }
                    certificationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wellKnownOpenIdConfiguration"))
                {
                    wellKnownOpenIdConfiguration = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectConfig(authorizationEndpoint.Value, tokenEndpoint.Value, issuer.Value, certificationUri.Value, wellKnownOpenIdConfiguration.Value);
        }
    }
}
