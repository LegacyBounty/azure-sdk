// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiRevisionContract
    {
        internal static ApiRevisionContract DeserializeApiRevisionContract(JsonElement element)
        {
            Optional<string> apiId = default;
            Optional<string> apiRevision = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> updatedDateTime = default;
            Optional<string> description = default;
            Optional<Uri> privateUri = default;
            Optional<bool> isOnline = default;
            Optional<bool> isCurrent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateUri = null;
                        continue;
                    }
                    privateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ApiRevisionContract(apiId.Value, apiRevision.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(updatedDateTime), description.Value, privateUri.Value, Optional.ToNullable(isOnline), Optional.ToNullable(isCurrent));
        }
    }
}
