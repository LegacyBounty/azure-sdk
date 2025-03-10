// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkUsagesListResult
    {
        internal static NetworkUsagesListResult DeserializeNetworkUsagesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<NetworkUsage>> value = default;
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
                    List<NetworkUsage> array = new List<NetworkUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkUsage.DeserializeNetworkUsage(item));
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
            return new NetworkUsagesListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
