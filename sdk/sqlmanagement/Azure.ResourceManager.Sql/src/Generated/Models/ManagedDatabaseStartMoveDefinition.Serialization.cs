// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabaseStartMoveDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("destinationManagedDatabaseId");
            writer.WriteStringValue(DestinationManagedDatabaseId);
            if (Optional.IsDefined(OperationMode))
            {
                writer.WritePropertyName("operationMode");
                writer.WriteStringValue(OperationMode.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
