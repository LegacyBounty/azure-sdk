// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafRankingsResponse
    {
        internal static WafRankingsResponse DeserializeWafRankingsResponse(JsonElement element)
        {
            Optional<DateTimeOffset> dateTimeBegin = default;
            Optional<DateTimeOffset> dateTimeEnd = default;
            Optional<IReadOnlyList<string>> groups = default;
            Optional<IReadOnlyList<WafRankingsResponseDataItem>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeBegin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dateTimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WafRankingsResponseDataItem> array = new List<WafRankingsResponseDataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafRankingsResponseDataItem.DeserializeWafRankingsResponseDataItem(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new WafRankingsResponse(Optional.ToNullable(dateTimeBegin), Optional.ToNullable(dateTimeEnd), Optional.ToList(groups), Optional.ToList(data));
        }
    }
}
