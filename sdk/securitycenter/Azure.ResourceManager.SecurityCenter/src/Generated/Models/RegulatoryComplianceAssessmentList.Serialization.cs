// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class RegulatoryComplianceAssessmentList
    {
        internal static RegulatoryComplianceAssessmentList DeserializeRegulatoryComplianceAssessmentList(JsonElement element)
        {
            IReadOnlyList<RegulatoryComplianceAssessmentData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<RegulatoryComplianceAssessmentData> array = new List<RegulatoryComplianceAssessmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegulatoryComplianceAssessmentData.DeserializeRegulatoryComplianceAssessmentData(item));
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
            return new RegulatoryComplianceAssessmentList(value, nextLink.Value);
        }
    }
}
