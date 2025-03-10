// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatThreadsItemCollection
    {
        internal static ChatThreadsItemCollection DeserializeChatThreadsItemCollection(JsonElement element)
        {
            IReadOnlyList<ChatThreadItem> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ChatThreadItem> array = new List<ChatThreadItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatThreadItem.DeserializeChatThreadItem(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ChatThreadsItemCollection(value, nextLink.Value);
        }
    }
}
