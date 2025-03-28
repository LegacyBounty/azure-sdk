// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusDeadletterMessagesAvailableWithNoListenersEventDataConverter))]
    public partial class ServiceBusDeadletterMessagesAvailableWithNoListenersEventData
    {
        internal static ServiceBusDeadletterMessagesAvailableWithNoListenersEventData DeserializeServiceBusDeadletterMessagesAvailableWithNoListenersEventData(JsonElement element)
        {
            Optional<string> namespaceName = default;
            Optional<string> requestUri = default;
            Optional<string> entityType = default;
            Optional<string> queueName = default;
            Optional<string> topicName = default;
            Optional<string> subscriptionName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    requestUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topicName"u8))
                {
                    topicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceBusDeadletterMessagesAvailableWithNoListenersEventData(namespaceName.Value, requestUri.Value, entityType.Value, queueName.Value, topicName.Value, subscriptionName.Value);
        }

        internal partial class ServiceBusDeadletterMessagesAvailableWithNoListenersEventDataConverter : JsonConverter<ServiceBusDeadletterMessagesAvailableWithNoListenersEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusDeadletterMessagesAvailableWithNoListenersEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ServiceBusDeadletterMessagesAvailableWithNoListenersEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusDeadletterMessagesAvailableWithNoListenersEventData(document.RootElement);
            }
        }
    }
}
