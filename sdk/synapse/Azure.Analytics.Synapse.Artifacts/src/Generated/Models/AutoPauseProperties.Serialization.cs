// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AutoPausePropertiesConverter))]
    public partial class AutoPauseProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DelayInMinutes))
            {
                writer.WritePropertyName("delayInMinutes"u8);
                writer.WriteNumberValue(DelayInMinutes.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutoPauseProperties DeserializeAutoPauseProperties(JsonElement element)
        {
            Optional<int> delayInMinutes = default;
            Optional<bool> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delayInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    delayInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AutoPauseProperties(Optional.ToNullable(delayInMinutes), Optional.ToNullable(enabled));
        }

        internal partial class AutoPausePropertiesConverter : JsonConverter<AutoPauseProperties>
        {
            public override void Write(Utf8JsonWriter writer, AutoPauseProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AutoPauseProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAutoPauseProperties(document.RootElement);
            }
        }
    }
}
