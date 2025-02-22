// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseBigDataPoolInfoData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale");
                writer.WriteObjectValue(AutoScale);
            }
            if (Optional.IsDefined(AutoPause))
            {
                writer.WritePropertyName("autoPause");
                writer.WriteObjectValue(AutoPause);
            }
            if (Optional.IsDefined(IsComputeIsolationEnabled))
            {
                writer.WritePropertyName("isComputeIsolationEnabled");
                writer.WriteBooleanValue(IsComputeIsolationEnabled.Value);
            }
            if (Optional.IsDefined(IsAutotuneEnabled))
            {
                writer.WritePropertyName("isAutotuneEnabled");
                writer.WriteBooleanValue(IsAutotuneEnabled.Value);
            }
            if (Optional.IsDefined(IsSessionLevelPackagesEnabled))
            {
                writer.WritePropertyName("sessionLevelPackagesEnabled");
                writer.WriteBooleanValue(IsSessionLevelPackagesEnabled.Value);
            }
            if (Optional.IsDefined(CacheSize))
            {
                writer.WritePropertyName("cacheSize");
                writer.WriteNumberValue(CacheSize.Value);
            }
            if (Optional.IsDefined(DynamicExecutorAllocation))
            {
                writer.WritePropertyName("dynamicExecutorAllocation");
                writer.WriteObjectValue(DynamicExecutorAllocation);
            }
            if (Optional.IsDefined(SparkEventsFolder))
            {
                writer.WritePropertyName("sparkEventsFolder");
                writer.WriteStringValue(SparkEventsFolder);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount");
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(LibraryRequirements))
            {
                writer.WritePropertyName("libraryRequirements");
                writer.WriteObjectValue(LibraryRequirements);
            }
            if (Optional.IsCollectionDefined(CustomLibraries))
            {
                writer.WritePropertyName("customLibraries");
                writer.WriteStartArray();
                foreach (var item in CustomLibraries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SparkConfigProperties))
            {
                writer.WritePropertyName("sparkConfigProperties");
                writer.WriteObjectValue(SparkConfigProperties);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion");
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(DefaultSparkLogFolder))
            {
                writer.WritePropertyName("defaultSparkLogFolder");
                writer.WriteStringValue(DefaultSparkLogFolder);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize");
                writer.WriteStringValue(NodeSize.Value.ToString());
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily");
                writer.WriteStringValue(NodeSizeFamily.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseBigDataPoolInfoData DeserializeSynapseBigDataPoolInfoData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<BigDataPoolAutoScaleProperties> autoScale = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<BigDataPoolAutoPauseProperties> autoPause = default;
            Optional<bool> isComputeIsolationEnabled = default;
            Optional<bool> isAutotuneEnabled = default;
            Optional<bool> sessionLevelPackagesEnabled = default;
            Optional<int> cacheSize = default;
            Optional<SynapseDynamicExecutorAllocation> dynamicExecutorAllocation = default;
            Optional<string> sparkEventsFolder = default;
            Optional<int> nodeCount = default;
            Optional<BigDataPoolLibraryRequirements> libraryRequirements = default;
            Optional<IList<BigDataPoolLibraryInfo>> customLibraries = default;
            Optional<BigDataPoolSparkConfigProperties> sparkConfigProperties = default;
            Optional<string> sparkVersion = default;
            Optional<string> defaultSparkLogFolder = default;
            Optional<BigDataPoolNodeSize> nodeSize = default;
            Optional<BigDataPoolNodeSizeFamily> nodeSizeFamily = default;
            Optional<DateTimeOffset> lastSucceededTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoScale"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoScale = BigDataPoolAutoScaleProperties.DeserializeBigDataPoolAutoScaleProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoPause"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoPause = BigDataPoolAutoPauseProperties.DeserializeBigDataPoolAutoPauseProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isComputeIsolationEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isComputeIsolationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAutotuneEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isAutotuneEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sessionLevelPackagesEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sessionLevelPackagesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cacheSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cacheSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dynamicExecutorAllocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dynamicExecutorAllocation = SynapseDynamicExecutorAllocation.DeserializeSynapseDynamicExecutorAllocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkEventsFolder"))
                        {
                            sparkEventsFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("libraryRequirements"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            libraryRequirements = BigDataPoolLibraryRequirements.DeserializeBigDataPoolLibraryRequirements(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customLibraries"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BigDataPoolLibraryInfo> array = new List<BigDataPoolLibraryInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BigDataPoolLibraryInfo.DeserializeBigDataPoolLibraryInfo(item));
                            }
                            customLibraries = array;
                            continue;
                        }
                        if (property0.NameEquals("sparkConfigProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sparkConfigProperties = BigDataPoolSparkConfigProperties.DeserializeBigDataPoolSparkConfigProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"))
                        {
                            sparkVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSparkLogFolder"))
                        {
                            defaultSparkLogFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nodeSize = new BigDataPoolNodeSize(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeSizeFamily"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nodeSizeFamily = new BigDataPoolNodeSizeFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSucceededTimestamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSucceededTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseBigDataPoolInfoData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, provisioningState.Value, autoScale.Value, Optional.ToNullable(creationDate), autoPause.Value, Optional.ToNullable(isComputeIsolationEnabled), Optional.ToNullable(isAutotuneEnabled), Optional.ToNullable(sessionLevelPackagesEnabled), Optional.ToNullable(cacheSize), dynamicExecutorAllocation.Value, sparkEventsFolder.Value, Optional.ToNullable(nodeCount), libraryRequirements.Value, Optional.ToList(customLibraries), sparkConfigProperties.Value, sparkVersion.Value, defaultSparkLogFolder.Value, Optional.ToNullable(nodeSize), Optional.ToNullable(nodeSizeFamily), Optional.ToNullable(lastSucceededTimestamp));
        }
    }
}
