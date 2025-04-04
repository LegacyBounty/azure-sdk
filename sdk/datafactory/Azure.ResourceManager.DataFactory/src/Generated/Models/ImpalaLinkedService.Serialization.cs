// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ImpalaLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("host"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Host);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Host.ToString()).RootElement);
#endif
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Port);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Port.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Username);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Username.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(EnableSsl))
            {
                writer.WritePropertyName("enableSsl"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EnableSsl);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EnableSsl.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TrustedCertPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TrustedCertPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseSystemTrustStore);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UseSystemTrustStore.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AllowHostNameCNMismatch))
            {
                writer.WritePropertyName("allowHostNameCNMismatch"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AllowHostNameCNMismatch);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AllowHostNameCNMismatch.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AllowSelfSignedServerCert))
            {
                writer.WritePropertyName("allowSelfSignedServerCert"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AllowSelfSignedServerCert);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AllowSelfSignedServerCert.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ImpalaLinkedService DeserializeImpalaLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            BinaryData host = default;
            Optional<BinaryData> port = default;
            ImpalaAuthenticationType authenticationType = default;
            Optional<BinaryData> username = default;
            Optional<FactorySecretBaseDefinition> password = default;
            Optional<BinaryData> enableSsl = default;
            Optional<BinaryData> trustedCertPath = default;
            Optional<BinaryData> useSystemTrustStore = default;
            Optional<BinaryData> allowHostNameCNMismatch = default;
            Optional<BinaryData> allowSelfSignedServerCert = default;
            Optional<BinaryData> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"u8))
                        {
                            host = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            authenticationType = new ImpalaAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("username"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            username = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = FactorySecretBaseDefinition.DeserializeFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableSsl = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trustedCertPath = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useSystemTrustStore = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("allowHostNameCNMismatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowHostNameCNMismatch = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowSelfSignedServerCert = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ImpalaLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, host, port.Value, authenticationType, username.Value, password.Value, enableSsl.Value, trustedCertPath.Value, useSystemTrustStore.Value, allowHostNameCNMismatch.Value, allowSelfSignedServerCert.Value, encryptedCredential.Value);
        }
    }
}
