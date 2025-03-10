// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class FunctionRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("functionUri"u8);
            writer.WriteStringValue(FunctionUri.AbsoluteUri);
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static FunctionRule DeserializeFunctionRule(JsonElement element)
        {
            Uri functionUri = default;
            Optional<FunctionRuleCredential> credential = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionUri"u8))
                {
                    functionUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credential = FunctionRuleCredential.DeserializeFunctionRuleCredential(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new FunctionRule(kind, functionUri, credential.Value);
        }
    }
}
