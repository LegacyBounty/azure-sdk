// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxOrderPreferences : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PreferredDataCenterRegion))
            {
                writer.WritePropertyName("preferredDataCenterRegion"u8);
                writer.WriteStartArray();
                foreach (var item in PreferredDataCenterRegion)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TransportPreferences))
            {
                writer.WritePropertyName("transportPreferences"u8);
                writer.WriteObjectValue(TransportPreferences);
            }
            if (Optional.IsDefined(EncryptionPreferences))
            {
                writer.WritePropertyName("encryptionPreferences"u8);
                writer.WriteObjectValue(EncryptionPreferences);
            }
            if (Optional.IsCollectionDefined(StorageAccountAccessTierPreferences))
            {
                writer.WritePropertyName("storageAccountAccessTierPreferences"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccountAccessTierPreferences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DataBoxOrderPreferences DeserializeDataBoxOrderPreferences(JsonElement element)
        {
            Optional<IList<string>> preferredDataCenterRegion = default;
            Optional<TransportPreferences> transportPreferences = default;
            Optional<DataBoxEncryptionPreferences> encryptionPreferences = default;
            Optional<IList<string>> storageAccountAccessTierPreferences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preferredDataCenterRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    preferredDataCenterRegion = array;
                    continue;
                }
                if (property.NameEquals("transportPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transportPreferences = TransportPreferences.DeserializeTransportPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryptionPreferences = DataBoxEncryptionPreferences.DeserializeDataBoxEncryptionPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("storageAccountAccessTierPreferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    storageAccountAccessTierPreferences = array;
                    continue;
                }
            }
            return new DataBoxOrderPreferences(Optional.ToList(preferredDataCenterRegion), transportPreferences.Value, encryptionPreferences.Value, Optional.ToList(storageAccountAccessTierPreferences));
        }
    }
}
