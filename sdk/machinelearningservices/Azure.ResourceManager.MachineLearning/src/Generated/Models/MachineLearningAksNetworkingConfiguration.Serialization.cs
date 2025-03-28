// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksNetworkingConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIP"u8);
                writer.WriteStringValue(DnsServiceIP);
            }
            if (Optional.IsDefined(DockerBridgeCidr))
            {
                writer.WritePropertyName("dockerBridgeCidr"u8);
                writer.WriteStringValue(DockerBridgeCidr);
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningAksNetworkingConfiguration DeserializeMachineLearningAksNetworkingConfiguration(JsonElement element)
        {
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> serviceCidr = default;
            Optional<string> dnsServiceIP = default;
            Optional<string> dockerBridgeCidr = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServiceIP"u8))
                {
                    dnsServiceIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dockerBridgeCidr"u8))
                {
                    dockerBridgeCidr = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningAksNetworkingConfiguration(subnetId.Value, serviceCidr.Value, dnsServiceIP.Value, dockerBridgeCidr.Value);
        }
    }
}
