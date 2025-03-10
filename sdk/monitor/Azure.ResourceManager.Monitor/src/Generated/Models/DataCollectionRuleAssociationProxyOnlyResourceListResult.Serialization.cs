// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DataCollectionRuleAssociationProxyOnlyResourceListResult
    {
        internal static DataCollectionRuleAssociationProxyOnlyResourceListResult DeserializeDataCollectionRuleAssociationProxyOnlyResourceListResult(JsonElement element)
        {
            IReadOnlyList<DataCollectionRuleAssociationData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataCollectionRuleAssociationData> array = new List<DataCollectionRuleAssociationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleAssociationData.DeserializeDataCollectionRuleAssociationData(item));
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
            return new DataCollectionRuleAssociationProxyOnlyResourceListResult(value, nextLink.Value);
        }
    }
}
