// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapDiskConfigurationsResult
    {
        internal static SapDiskConfigurationsResult DeserializeSapDiskConfigurationsResult(JsonElement element)
        {
            Optional<IReadOnlyList<SapDiskConfiguration>> diskConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SapDiskConfiguration> array = new List<SapDiskConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SapDiskConfiguration.DeserializeSapDiskConfiguration(item));
                    }
                    diskConfigurations = array;
                    continue;
                }
            }
            return new SapDiskConfigurationsResult(Optional.ToList(diskConfigurations));
        }
    }
}
