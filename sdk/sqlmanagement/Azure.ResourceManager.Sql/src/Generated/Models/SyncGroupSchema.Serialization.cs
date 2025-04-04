// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MasterSyncMemberName))
            {
                writer.WritePropertyName("masterSyncMemberName"u8);
                writer.WriteStringValue(MasterSyncMemberName);
            }
            writer.WriteEndObject();
        }

        internal static SyncGroupSchema DeserializeSyncGroupSchema(JsonElement element)
        {
            Optional<IList<SyncGroupSchemaTable>> tables = default;
            Optional<string> masterSyncMemberName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncGroupSchemaTable> array = new List<SyncGroupSchemaTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncGroupSchemaTable.DeserializeSyncGroupSchemaTable(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("masterSyncMemberName"u8))
                {
                    masterSyncMemberName = property.Value.GetString();
                    continue;
                }
            }
            return new SyncGroupSchema(Optional.ToList(tables), masterSyncMemberName.Value);
        }
    }
}
