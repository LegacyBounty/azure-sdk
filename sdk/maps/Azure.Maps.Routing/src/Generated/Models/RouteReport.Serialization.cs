// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteReport
    {
        internal static RouteReport DeserializeRouteReport(JsonElement element)
        {
            Optional<IReadOnlyList<EffectiveSetting>> effectiveSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("effectiveSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EffectiveSetting> array = new List<EffectiveSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveSetting.DeserializeEffectiveSetting(item));
                    }
                    effectiveSettings = array;
                    continue;
                }
            }
            return new RouteReport(Optional.ToList(effectiveSettings));
        }
    }
}
