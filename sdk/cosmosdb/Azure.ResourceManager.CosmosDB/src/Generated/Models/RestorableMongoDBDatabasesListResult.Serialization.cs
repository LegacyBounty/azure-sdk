// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableMongoDBDatabasesListResult
    {
        internal static RestorableMongoDBDatabasesListResult DeserializeRestorableMongoDBDatabasesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RestorableMongoDBDatabase>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorableMongoDBDatabase> array = new List<RestorableMongoDBDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableMongoDBDatabase.DeserializeRestorableMongoDBDatabase(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RestorableMongoDBDatabasesListResult(Optional.ToList(value));
        }
    }
}
