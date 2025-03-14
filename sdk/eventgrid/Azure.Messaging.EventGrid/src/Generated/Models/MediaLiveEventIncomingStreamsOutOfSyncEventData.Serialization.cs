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
    [JsonConverter(typeof(MediaLiveEventIncomingStreamsOutOfSyncEventDataConverter))]
    public partial class MediaLiveEventIncomingStreamsOutOfSyncEventData
    {
        internal static MediaLiveEventIncomingStreamsOutOfSyncEventData DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(JsonElement element)
        {
            Optional<string> minLastTimestamp = default;
            Optional<string> typeOfStreamWithMinLastTimestamp = default;
            Optional<string> maxLastTimestamp = default;
            Optional<string> typeOfStreamWithMaxLastTimestamp = default;
            Optional<string> timescaleOfMinLastTimestamp = default;
            Optional<string> timescaleOfMaxLastTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minLastTimestamp"u8))
                {
                    minLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeOfStreamWithMinLastTimestamp"u8))
                {
                    typeOfStreamWithMinLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLastTimestamp"u8))
                {
                    maxLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeOfStreamWithMaxLastTimestamp"u8))
                {
                    typeOfStreamWithMaxLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescaleOfMinLastTimestamp"u8))
                {
                    timescaleOfMinLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescaleOfMaxLastTimestamp"u8))
                {
                    timescaleOfMaxLastTimestamp = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventIncomingStreamsOutOfSyncEventData(minLastTimestamp.Value, typeOfStreamWithMinLastTimestamp.Value, maxLastTimestamp.Value, typeOfStreamWithMaxLastTimestamp.Value, timescaleOfMinLastTimestamp.Value, timescaleOfMaxLastTimestamp.Value);
        }

        internal partial class MediaLiveEventIncomingStreamsOutOfSyncEventDataConverter : JsonConverter<MediaLiveEventIncomingStreamsOutOfSyncEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIncomingStreamsOutOfSyncEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaLiveEventIncomingStreamsOutOfSyncEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(document.RootElement);
            }
        }
    }
}
