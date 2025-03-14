// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class SnapshotsList
    {
        internal static SnapshotsList DeserializeSnapshotsList(JsonElement element)
        {
            Optional<IReadOnlyList<NetAppVolumeSnapshotData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NetAppVolumeSnapshotData> array = new List<NetAppVolumeSnapshotData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumeSnapshotData.DeserializeNetAppVolumeSnapshotData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SnapshotsList(Optional.ToList(value));
        }
    }
}
