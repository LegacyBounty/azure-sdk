// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class SynapseLinkWorkspaceListResult
    {
        internal static SynapseLinkWorkspaceListResult DeserializeSynapseLinkWorkspaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SqlSynapseLinkWorkspace>> value = default;
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
                    List<SqlSynapseLinkWorkspace> array = new List<SqlSynapseLinkWorkspace>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlSynapseLinkWorkspace.DeserializeSqlSynapseLinkWorkspace(item));
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
            return new SynapseLinkWorkspaceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
