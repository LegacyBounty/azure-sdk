// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LinkedIntegrationRuntimeRbacAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeRbacAuthorization DeserializeLinkedIntegrationRuntimeRbacAuthorization(JsonElement element)
        {
            string resourceId = default;
            Optional<FactoryCredentialReference> credential = default;
            string authorizationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credential = FactoryCredentialReference.DeserializeFactoryCredentialReference(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeRbacAuthorization(authorizationType, resourceId, credential.Value);
        }
    }
}
