// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteServiceProviderBandwidthsOffered : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferName))
            {
                writer.WritePropertyName("offerName"u8);
                writer.WriteStringValue(OfferName);
            }
            if (Optional.IsDefined(ValueInMbps))
            {
                writer.WritePropertyName("valueInMbps"u8);
                writer.WriteNumberValue(ValueInMbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteServiceProviderBandwidthsOffered DeserializeExpressRouteServiceProviderBandwidthsOffered(JsonElement element)
        {
            Optional<string> offerName = default;
            Optional<int> valueInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"u8))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueInMbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExpressRouteServiceProviderBandwidthsOffered(offerName.Value, Optional.ToNullable(valueInMbps));
        }
    }
}
