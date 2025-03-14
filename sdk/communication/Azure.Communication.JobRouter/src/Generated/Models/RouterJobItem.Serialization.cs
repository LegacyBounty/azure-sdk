// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterJobItem
    {
        internal static RouterJobItem DeserializeRouterJobItem(JsonElement element)
        {
            Optional<RouterJob> routerJob = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routerJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routerJob = RouterJob.DeserializeRouterJob(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new RouterJobItem(routerJob.Value, etag.Value);
        }
    }
}
