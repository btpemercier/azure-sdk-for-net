// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayCorsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedOrigins))
            {
                writer.WritePropertyName("allowedOrigins");
                writer.WriteStartArray();
                foreach (var item in AllowedOrigins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedMethods))
            {
                writer.WritePropertyName("allowedMethods");
                writer.WriteStartArray();
                foreach (var item in AllowedMethods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedHeaders))
            {
                writer.WritePropertyName("allowedHeaders");
                writer.WriteStartArray();
                foreach (var item in AllowedHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxAge))
            {
                writer.WritePropertyName("maxAge");
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (Optional.IsDefined(AreCredentialsAllowed))
            {
                writer.WritePropertyName("allowCredentials");
                writer.WriteBooleanValue(AreCredentialsAllowed.Value);
            }
            if (Optional.IsCollectionDefined(ExposedHeaders))
            {
                writer.WritePropertyName("exposedHeaders");
                writer.WriteStartArray();
                foreach (var item in ExposedHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppPlatformGatewayCorsProperties DeserializeAppPlatformGatewayCorsProperties(JsonElement element)
        {
            Optional<IList<string>> allowedOrigins = default;
            Optional<IList<string>> allowedMethods = default;
            Optional<IList<string>> allowedHeaders = default;
            Optional<int> maxAge = default;
            Optional<bool> allowCredentials = default;
            Optional<IList<string>> exposedHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("allowedMethods"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedMethods = array;
                    continue;
                }
                if (property.NameEquals("allowedHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedHeaders = array;
                    continue;
                }
                if (property.NameEquals("maxAge"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exposedHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposedHeaders = array;
                    continue;
                }
            }
            return new AppPlatformGatewayCorsProperties(Optional.ToList(allowedOrigins), Optional.ToList(allowedMethods), Optional.ToList(allowedHeaders), Optional.ToNullable(maxAge), Optional.ToNullable(allowCredentials), Optional.ToList(exposedHeaders));
        }
    }
}
