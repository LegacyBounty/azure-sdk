// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubBaiduCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BaiduApiKey))
            {
                writer.WritePropertyName("baiduApiKey"u8);
                writer.WriteStringValue(BaiduApiKey);
            }
            if (Optional.IsDefined(BaiduEndpoint))
            {
                writer.WritePropertyName("baiduEndPoint"u8);
                writer.WriteStringValue(BaiduEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(BaiduSecretKey))
            {
                writer.WritePropertyName("baiduSecretKey"u8);
                writer.WriteStringValue(BaiduSecretKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubBaiduCredential DeserializeNotificationHubBaiduCredential(JsonElement element)
        {
            Optional<string> baiduApiKey = default;
            Optional<Uri> baiduEndPoint = default;
            Optional<string> baiduSecretKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("baiduApiKey"u8))
                        {
                            baiduApiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baiduEndPoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                baiduEndPoint = null;
                                continue;
                            }
                            baiduEndPoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("baiduSecretKey"u8))
                        {
                            baiduSecretKey = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubBaiduCredential(baiduApiKey.Value, baiduEndPoint.Value, baiduSecretKey.Value);
        }
    }
}
