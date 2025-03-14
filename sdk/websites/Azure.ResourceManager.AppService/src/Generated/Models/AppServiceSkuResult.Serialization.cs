// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceSkuResult
    {
        internal static AppServiceSkuResult DeserializeAppServiceSkuResult(JsonElement element)
        {
            Optional<ResourceType> resourceType = default;
            Optional<IReadOnlyList<GlobalCsmSkuDescription>> skus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("skus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GlobalCsmSkuDescription> array = new List<GlobalCsmSkuDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GlobalCsmSkuDescription.DeserializeGlobalCsmSkuDescription(item));
                    }
                    skus = array;
                    continue;
                }
            }
            return new AppServiceSkuResult(Optional.ToNullable(resourceType), Optional.ToList(skus));
        }
    }
}
