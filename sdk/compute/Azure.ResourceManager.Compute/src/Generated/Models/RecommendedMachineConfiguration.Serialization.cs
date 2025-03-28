// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RecommendedMachineConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VCpus))
            {
                writer.WritePropertyName("vCPUs"u8);
                writer.WriteObjectValue(VCpus);
            }
            if (Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory"u8);
                writer.WriteObjectValue(Memory);
            }
            writer.WriteEndObject();
        }

        internal static RecommendedMachineConfiguration DeserializeRecommendedMachineConfiguration(JsonElement element)
        {
            Optional<ResourceRange> vCpus = default;
            Optional<ResourceRange> memory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vCpus = ResourceRange.DeserializeResourceRange(property.Value);
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memory = ResourceRange.DeserializeResourceRange(property.Value);
                    continue;
                }
            }
            return new RecommendedMachineConfiguration(vCpus.Value, memory.Value);
        }
    }
}
