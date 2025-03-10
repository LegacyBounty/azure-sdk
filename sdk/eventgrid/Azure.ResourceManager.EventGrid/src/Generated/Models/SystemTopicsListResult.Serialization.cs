// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class SystemTopicsListResult
    {
        internal static SystemTopicsListResult DeserializeSystemTopicsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SystemTopicData>> value = default;
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
                    List<SystemTopicData> array = new List<SystemTopicData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SystemTopicData.DeserializeSystemTopicData(item));
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
            return new SystemTopicsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
