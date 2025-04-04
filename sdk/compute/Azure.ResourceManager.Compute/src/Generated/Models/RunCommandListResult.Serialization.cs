// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class RunCommandListResult
    {
        internal static RunCommandListResult DeserializeRunCommandListResult(JsonElement element)
        {
            IReadOnlyList<RunCommandDocumentBase> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<RunCommandDocumentBase> array = new List<RunCommandDocumentBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunCommandDocumentBase.DeserializeRunCommandDocumentBase(item));
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
            return new RunCommandListResult(value, nextLink.Value);
        }
    }
}
