// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TrafficSelectorPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("localAddressRanges"u8);
            writer.WriteStartArray();
            foreach (var item in LocalAddressRanges)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("remoteAddressRanges"u8);
            writer.WriteStartArray();
            foreach (var item in RemoteAddressRanges)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static TrafficSelectorPolicy DeserializeTrafficSelectorPolicy(JsonElement element)
        {
            IList<string> localAddressRanges = default;
            IList<string> remoteAddressRanges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddressRanges"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    localAddressRanges = array;
                    continue;
                }
                if (property.NameEquals("remoteAddressRanges"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    remoteAddressRanges = array;
                    continue;
                }
            }
            return new TrafficSelectorPolicy(localAddressRanges, remoteAddressRanges);
        }
    }
}
