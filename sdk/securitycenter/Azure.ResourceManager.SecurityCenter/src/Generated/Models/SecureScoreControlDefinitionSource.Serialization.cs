// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecureScoreControlDefinitionSource
    {
        internal static SecureScoreControlDefinitionSource DeserializeSecureScoreControlDefinitionSource(JsonElement element)
        {
            Optional<SecurityControlType> sourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceType = new SecurityControlType(property.Value.GetString());
                    continue;
                }
            }
            return new SecureScoreControlDefinitionSource(Optional.ToNullable(sourceType));
        }
    }
}
