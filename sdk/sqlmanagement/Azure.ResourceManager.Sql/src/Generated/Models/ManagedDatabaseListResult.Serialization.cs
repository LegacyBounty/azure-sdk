// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ManagedDatabaseListResult
    {
        internal static ManagedDatabaseListResult DeserializeManagedDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedDatabaseData>> value = default;
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
                    List<ManagedDatabaseData> array = new List<ManagedDatabaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedDatabaseData.DeserializeManagedDatabaseData(item));
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
            return new ManagedDatabaseListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
