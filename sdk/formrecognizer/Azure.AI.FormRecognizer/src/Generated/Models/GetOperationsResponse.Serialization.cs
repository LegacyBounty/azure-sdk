// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class GetOperationsResponse
    {
        internal static GetOperationsResponse DeserializeGetOperationsResponse(JsonElement element)
        {
            IReadOnlyList<OperationSummary> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<OperationSummary> array = new List<OperationSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationSummary.DeserializeOperationSummary(item));
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
            return new GetOperationsResponse(value, nextLink.Value);
        }
    }
}
