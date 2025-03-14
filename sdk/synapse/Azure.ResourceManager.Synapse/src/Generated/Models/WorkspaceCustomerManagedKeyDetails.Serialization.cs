// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class WorkspaceCustomerManagedKeyDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteObjectValue(Key);
            }
            if (Optional.IsDefined(KekIdentity))
            {
                writer.WritePropertyName("kekIdentity"u8);
                writer.WriteObjectValue(KekIdentity);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceCustomerManagedKeyDetails DeserializeWorkspaceCustomerManagedKeyDetails(JsonElement element)
        {
            Optional<string> status = default;
            Optional<SynapseWorkspaceKeyDetails> key = default;
            Optional<KekIdentityProperties> kekIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    key = SynapseWorkspaceKeyDetails.DeserializeSynapseWorkspaceKeyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("kekIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kekIdentity = KekIdentityProperties.DeserializeKekIdentityProperties(property.Value);
                    continue;
                }
            }
            return new WorkspaceCustomerManagedKeyDetails(status.Value, key.Value, kekIdentity.Value);
        }
    }
}
