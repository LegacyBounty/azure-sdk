// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    internal partial class SearchSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static SearchSku DeserializeSearchSku(JsonElement element)
        {
            Optional<SearchSkuName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = property.Value.GetString().ToSearchSkuName();
                    continue;
                }
            }
            return new SearchSku(Optional.ToNullable(name));
        }
    }
}
