// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSharedPrivateLinkResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MachineLearningSharedPrivateLinkResource DeserializeMachineLearningSharedPrivateLinkResource(JsonElement element)
        {
            Optional<string> name = default;
            Optional<ResourceIdentifier> privateLinkResourceId = default;
            Optional<string> groupId = default;
            Optional<string> requestMessage = default;
            Optional<MachineLearningPrivateEndpointServiceConnectionStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("privateLinkResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("groupId"u8))
                        {
                            groupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestMessage"u8))
                        {
                            requestMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new MachineLearningPrivateEndpointServiceConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MachineLearningSharedPrivateLinkResource(name.Value, privateLinkResourceId.Value, groupId.Value, requestMessage.Value, Optional.ToNullable(status));
        }
    }
}
