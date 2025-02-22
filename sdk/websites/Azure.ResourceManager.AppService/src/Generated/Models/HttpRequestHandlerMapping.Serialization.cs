// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HttpRequestHandlerMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Extension))
            {
                writer.WritePropertyName("extension");
                writer.WriteStringValue(Extension);
            }
            if (Optional.IsDefined(ScriptProcessor))
            {
                writer.WritePropertyName("scriptProcessor");
                writer.WriteStringValue(ScriptProcessor);
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteStringValue(Arguments);
            }
            writer.WriteEndObject();
        }

        internal static HttpRequestHandlerMapping DeserializeHttpRequestHandlerMapping(JsonElement element)
        {
            Optional<string> extension = default;
            Optional<string> scriptProcessor = default;
            Optional<string> arguments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extension"))
                {
                    extension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptProcessor"))
                {
                    scriptProcessor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"))
                {
                    arguments = property.Value.GetString();
                    continue;
                }
            }
            return new HttpRequestHandlerMapping(extension.Value, scriptProcessor.Value, arguments.Value);
        }
    }
}
