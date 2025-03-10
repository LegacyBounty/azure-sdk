// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class AnalyzeResult
    {
        internal static AnalyzeResult DeserializeAnalyzeResult(JsonElement element)
        {
            IReadOnlyList<AnalyzedTokenInfo> tokens = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokens"u8))
                {
                    List<AnalyzedTokenInfo> array = new List<AnalyzedTokenInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzedTokenInfo.DeserializeAnalyzedTokenInfo(item));
                    }
                    tokens = array;
                    continue;
                }
            }
            return new AnalyzeResult(tokens);
        }
    }
}
