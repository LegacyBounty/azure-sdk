// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewManagedResource
    {
        internal static PurviewManagedResource DeserializePurviewManagedResource(JsonElement element)
        {
            Optional<ResourceIdentifier> eventHubNamespace = default;
            Optional<ResourceIdentifier> resourceGroup = default;
            Optional<ResourceIdentifier> storageAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubNamespace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eventHubNamespace = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceGroup = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccount = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new PurviewManagedResource(eventHubNamespace.Value, resourceGroup.Value, storageAccount.Value);
        }
    }
}
