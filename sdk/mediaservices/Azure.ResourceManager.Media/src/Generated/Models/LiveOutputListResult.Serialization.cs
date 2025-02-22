// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class LiveOutputListResult
    {
        internal static LiveOutputListResult DeserializeLiveOutputListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MediaLiveOutputData>> value = default;
            Optional<int> odataCount = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaLiveOutputData> array = new List<MediaLiveOutputData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaLiveOutputData.DeserializeMediaLiveOutputData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LiveOutputListResult(Optional.ToList(value), Optional.ToNullable(odataCount), odataNextLink.Value);
        }
    }
}
