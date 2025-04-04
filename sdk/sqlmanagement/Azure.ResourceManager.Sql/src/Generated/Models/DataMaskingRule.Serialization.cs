// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DataMaskingRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AliasName))
            {
                writer.WritePropertyName("aliasName"u8);
                writer.WriteStringValue(AliasName);
            }
            if (Optional.IsDefined(RuleState))
            {
                writer.WritePropertyName("ruleState"u8);
                writer.WriteStringValue(RuleState.Value.ToSerialString());
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
                writer.WriteStringValue(ColumnName);
            }
            if (Optional.IsDefined(MaskingFunction))
            {
                writer.WritePropertyName("maskingFunction"u8);
                writer.WriteStringValue(MaskingFunction.Value.ToSerialString());
            }
            if (Optional.IsDefined(NumberFrom))
            {
                writer.WritePropertyName("numberFrom"u8);
                writer.WriteStringValue(NumberFrom);
            }
            if (Optional.IsDefined(NumberTo))
            {
                writer.WritePropertyName("numberTo"u8);
                writer.WriteStringValue(NumberTo);
            }
            if (Optional.IsDefined(PrefixSize))
            {
                writer.WritePropertyName("prefixSize"u8);
                writer.WriteStringValue(PrefixSize);
            }
            if (Optional.IsDefined(SuffixSize))
            {
                writer.WritePropertyName("suffixSize"u8);
                writer.WriteStringValue(SuffixSize);
            }
            if (Optional.IsDefined(ReplacementString))
            {
                writer.WritePropertyName("replacementString"u8);
                writer.WriteStringValue(ReplacementString);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataMaskingRule DeserializeDataMaskingRule(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> aliasName = default;
            Optional<DataMaskingRuleState> ruleState = default;
            Optional<string> schemaName = default;
            Optional<string> tableName = default;
            Optional<string> columnName = default;
            Optional<DataMaskingFunction> maskingFunction = default;
            Optional<string> numberFrom = default;
            Optional<string> numberTo = default;
            Optional<string> prefixSize = default;
            Optional<string> suffixSize = default;
            Optional<string> replacementString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("aliasName"u8))
                        {
                            aliasName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ruleState = property0.Value.GetString().ToDataMaskingRuleState();
                            continue;
                        }
                        if (property0.NameEquals("schemaName"u8))
                        {
                            schemaName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columnName"u8))
                        {
                            columnName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maskingFunction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maskingFunction = property0.Value.GetString().ToDataMaskingFunction();
                            continue;
                        }
                        if (property0.NameEquals("numberFrom"u8))
                        {
                            numberFrom = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberTo"u8))
                        {
                            numberTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixSize"u8))
                        {
                            prefixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffixSize"u8))
                        {
                            suffixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replacementString"u8))
                        {
                            replacementString = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataMaskingRule(id, name, type, systemData.Value, Optional.ToNullable(location), kind.Value, aliasName.Value, Optional.ToNullable(ruleState), schemaName.Value, tableName.Value, columnName.Value, Optional.ToNullable(maskingFunction), numberFrom.Value, numberTo.Value, prefixSize.Value, suffixSize.Value, replacementString.Value);
        }
    }
}
