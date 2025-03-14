// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CustomRolloutProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("specification"u8);
            writer.WriteObjectValue(Specification);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static CustomRolloutProperties DeserializeCustomRolloutProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            CustomRolloutPropertiesSpecification specification = default;
            Optional<CustomRolloutPropertiesStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("specification"u8))
                {
                    specification = CustomRolloutPropertiesSpecification.DeserializeCustomRolloutPropertiesSpecification(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = CustomRolloutPropertiesStatus.DeserializeCustomRolloutPropertiesStatus(property.Value);
                    continue;
                }
            }
            return new CustomRolloutProperties(Optional.ToNullable(provisioningState), specification, status.Value);
        }
    }
}
