// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StorageQueueEventSubscriptionDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(QueueMessageTimeToLiveInSeconds))
            {
                writer.WritePropertyName("queueMessageTimeToLiveInSeconds"u8);
                writer.WriteNumberValue(QueueMessageTimeToLiveInSeconds.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageQueueEventSubscriptionDestination DeserializeStorageQueueEventSubscriptionDestination(JsonElement element)
        {
            EndpointType endpointType = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> queueName = default;
            Optional<long> queueMessageTimeToLiveInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("queueName"u8))
                        {
                            queueName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queueMessageTimeToLiveInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queueMessageTimeToLiveInSeconds = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageQueueEventSubscriptionDestination(endpointType, resourceId.Value, queueName.Value, Optional.ToNullable(queueMessageTimeToLiveInSeconds));
        }
    }
}
