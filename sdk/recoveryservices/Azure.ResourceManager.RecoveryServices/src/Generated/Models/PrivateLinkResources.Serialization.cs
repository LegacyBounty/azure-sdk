// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    internal partial class PrivateLinkResources
    {
        internal static PrivateLinkResources DeserializePrivateLinkResources(JsonElement element)
        {
            Optional<IReadOnlyList<RecoveryServicesPrivateLinkResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RecoveryServicesPrivateLinkResourceData> array = new List<RecoveryServicesPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryServicesPrivateLinkResourceData.DeserializeRecoveryServicesPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateLinkResources(Optional.ToList(value), nextLink.Value);
        }
    }
}
