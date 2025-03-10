// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiVersionSetContractDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(VersioningScheme))
            {
                writer.WritePropertyName("versioningScheme"u8);
                writer.WriteStringValue(VersioningScheme.Value.ToString());
            }
            if (Optional.IsDefined(VersionQueryName))
            {
                writer.WritePropertyName("versionQueryName"u8);
                writer.WriteStringValue(VersionQueryName);
            }
            if (Optional.IsDefined(VersionHeaderName))
            {
                writer.WritePropertyName("versionHeaderName"u8);
                writer.WriteStringValue(VersionHeaderName);
            }
            writer.WriteEndObject();
        }

        internal static ApiVersionSetContractDetails DeserializeApiVersionSetContractDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<VersioningScheme> versioningScheme = default;
            Optional<string> versionQueryName = default;
            Optional<string> versionHeaderName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("versioningScheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    versioningScheme = new VersioningScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionQueryName"u8))
                {
                    versionQueryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("versionHeaderName"u8))
                {
                    versionHeaderName = property.Value.GetString();
                    continue;
                }
            }
            return new ApiVersionSetContractDetails(id.Value, name.Value, description.Value, Optional.ToNullable(versioningScheme), versionQueryName.Value, versionHeaderName.Value);
        }
    }
}
