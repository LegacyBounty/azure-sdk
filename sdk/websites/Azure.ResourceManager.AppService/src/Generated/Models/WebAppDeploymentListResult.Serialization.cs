// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class WebAppDeploymentListResult
    {
        internal static WebAppDeploymentListResult DeserializeWebAppDeploymentListResult(JsonElement element)
        {
            IReadOnlyList<WebAppDeploymentData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<WebAppDeploymentData> array = new List<WebAppDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebAppDeploymentData.DeserializeWebAppDeploymentData(item));
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
            return new WebAppDeploymentListResult(value, nextLink.Value);
        }
    }
}
