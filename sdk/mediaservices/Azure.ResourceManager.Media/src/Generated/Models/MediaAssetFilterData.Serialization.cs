// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetFilterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PresentationTimeRange))
            {
                writer.WritePropertyName("presentationTimeRange"u8);
                writer.WriteObjectValue(PresentationTimeRange);
            }
            if (Optional.IsDefined(FirstQuality))
            {
                writer.WritePropertyName("firstQuality"u8);
                writer.WriteObjectValue(FirstQuality);
            }
            if (Optional.IsCollectionDefined(Tracks))
            {
                writer.WritePropertyName("tracks"u8);
                writer.WriteStartArray();
                foreach (var item in Tracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MediaAssetFilterData DeserializeMediaAssetFilterData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PresentationTimeRange> presentationTimeRange = default;
            Optional<FirstQuality> firstQuality = default;
            Optional<IList<FilterTrackSelection>> tracks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("presentationTimeRange"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            presentationTimeRange = PresentationTimeRange.DeserializePresentationTimeRange(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("firstQuality"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firstQuality = FirstQuality.DeserializeFirstQuality(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tracks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FilterTrackSelection> array = new List<FilterTrackSelection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterTrackSelection.DeserializeFilterTrackSelection(item));
                            }
                            tracks = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MediaAssetFilterData(id, name, type, systemData.Value, presentationTimeRange.Value, firstQuality.Value, Optional.ToList(tracks));
        }
    }
}
