// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ContinuousModeBackupPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteObjectValue(MigrationState);
            }
            writer.WriteEndObject();
        }

        internal static ContinuousModeBackupPolicy DeserializeContinuousModeBackupPolicy(JsonElement element)
        {
            BackupPolicyType type = default;
            Optional<BackupPolicyMigrationState> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value);
                    continue;
                }
            }
            return new ContinuousModeBackupPolicy(type, migrationState.Value);
        }
    }
}
