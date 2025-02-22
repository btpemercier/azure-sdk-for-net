// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentEntitiesResult
    {
        internal static SecurityInsightsIncidentEntitiesResult DeserializeSecurityInsightsIncidentEntitiesResult(JsonElement element)
        {
            Optional<IReadOnlyList<SecurityInsightsEntity>> entities = default;
            Optional<IReadOnlyList<SecurityInsightsIncidentEntitiesMetadata>> metaData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecurityInsightsEntity> array = new List<SecurityInsightsEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsEntity.DeserializeSecurityInsightsEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("metaData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecurityInsightsIncidentEntitiesMetadata> array = new List<SecurityInsightsIncidentEntitiesMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsIncidentEntitiesMetadata.DeserializeSecurityInsightsIncidentEntitiesMetadata(item));
                    }
                    metaData = array;
                    continue;
                }
            }
            return new SecurityInsightsIncidentEntitiesResult(Optional.ToList(entities), Optional.ToList(metaData));
        }
    }
}
