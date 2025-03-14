// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class Office365PolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BreakOutCategories))
            {
                writer.WritePropertyName("breakOutCategories"u8);
                writer.WriteObjectValue(BreakOutCategories);
            }
            writer.WriteEndObject();
        }

        internal static Office365PolicyProperties DeserializeOffice365PolicyProperties(JsonElement element)
        {
            Optional<BreakOutCategoryPolicies> breakOutCategories = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("breakOutCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    breakOutCategories = BreakOutCategoryPolicies.DeserializeBreakOutCategoryPolicies(property.Value);
                    continue;
                }
            }
            return new Office365PolicyProperties(breakOutCategories.Value);
        }
    }
}
