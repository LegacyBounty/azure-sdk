// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class UnknownLinkedIntegrationRuntimeType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static UnknownLinkedIntegrationRuntimeType DeserializeUnknownLinkedIntegrationRuntimeType(JsonElement element)
        {
            string authorizationType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownLinkedIntegrationRuntimeType(authorizationType);
        }
    }
}
