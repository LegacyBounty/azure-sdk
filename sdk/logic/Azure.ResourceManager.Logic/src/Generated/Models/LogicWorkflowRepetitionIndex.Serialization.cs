// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowRepetitionIndex : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScopeName))
            {
                writer.WritePropertyName("scopeName"u8);
                writer.WriteStringValue(ScopeName);
            }
            writer.WritePropertyName("itemIndex"u8);
            writer.WriteNumberValue(ItemIndex);
            writer.WriteEndObject();
        }

        internal static LogicWorkflowRepetitionIndex DeserializeLogicWorkflowRepetitionIndex(JsonElement element)
        {
            Optional<string> scopeName = default;
            int itemIndex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scopeName"u8))
                {
                    scopeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemIndex"u8))
                {
                    itemIndex = property.Value.GetInt32();
                    continue;
                }
            }
            return new LogicWorkflowRepetitionIndex(scopeName.Value, itemIndex);
        }
    }
}
