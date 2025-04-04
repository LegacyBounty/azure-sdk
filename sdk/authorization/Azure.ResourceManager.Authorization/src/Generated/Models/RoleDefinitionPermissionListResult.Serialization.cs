// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    internal partial class RoleDefinitionPermissionListResult
    {
        internal static RoleDefinitionPermissionListResult DeserializeRoleDefinitionPermissionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RoleDefinitionPermission>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RoleDefinitionPermission> array = new List<RoleDefinitionPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleDefinitionPermission.DeserializeRoleDefinitionPermission(item));
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
            return new RoleDefinitionPermissionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
