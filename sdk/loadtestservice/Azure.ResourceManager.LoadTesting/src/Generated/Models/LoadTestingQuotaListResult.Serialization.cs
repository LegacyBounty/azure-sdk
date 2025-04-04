// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LoadTesting;

namespace Azure.ResourceManager.LoadTesting.Models
{
    internal partial class LoadTestingQuotaListResult
    {
        internal static LoadTestingQuotaListResult DeserializeLoadTestingQuotaListResult(JsonElement element)
        {
            Optional<IReadOnlyList<LoadTestingQuotaData>> value = default;
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
                    List<LoadTestingQuotaData> array = new List<LoadTestingQuotaData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingQuotaData.DeserializeLoadTestingQuotaData(item));
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
            return new LoadTestingQuotaListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
