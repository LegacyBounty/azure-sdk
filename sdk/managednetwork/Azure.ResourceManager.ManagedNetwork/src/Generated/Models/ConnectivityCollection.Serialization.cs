// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    public partial class ConnectivityCollection
    {
        internal static ConnectivityCollection DeserializeConnectivityCollection(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedNetworkGroupData>> groups = default;
            Optional<IReadOnlyList<ManagedNetworkPeeringPolicyData>> peerings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedNetworkGroupData> array = new List<ManagedNetworkGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedNetworkGroupData.DeserializeManagedNetworkGroupData(item));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("peerings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedNetworkPeeringPolicyData> array = new List<ManagedNetworkPeeringPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedNetworkPeeringPolicyData.DeserializeManagedNetworkPeeringPolicyData(item));
                    }
                    peerings = array;
                    continue;
                }
            }
            return new ConnectivityCollection(Optional.ToList(groups), Optional.ToList(peerings));
        }
    }
}
