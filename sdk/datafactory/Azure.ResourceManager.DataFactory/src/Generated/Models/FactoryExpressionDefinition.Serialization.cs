// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryExpressionDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExpressionType.ToString());
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            writer.WriteEndObject();
        }

        internal static FactoryExpressionDefinition DeserializeFactoryExpressionDefinition(JsonElement element)
        {
            FactoryExpressionType type = default;
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new FactoryExpressionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new FactoryExpressionDefinition(type, value);
        }
    }
}
