// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyRule DeserializeRoleManagementPolicyRule(JsonElement element)
        {
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RoleManagementPolicyApprovalRule": return RoleManagementPolicyApprovalRule.DeserializeRoleManagementPolicyApprovalRule(element);
                    case "RoleManagementPolicyAuthenticationContextRule": return RoleManagementPolicyAuthenticationContextRule.DeserializeRoleManagementPolicyAuthenticationContextRule(element);
                    case "RoleManagementPolicyEnablementRule": return RoleManagementPolicyEnablementRule.DeserializeRoleManagementPolicyEnablementRule(element);
                    case "RoleManagementPolicyExpirationRule": return RoleManagementPolicyExpirationRule.DeserializeRoleManagementPolicyExpirationRule(element);
                    case "RoleManagementPolicyNotificationRule": return RoleManagementPolicyNotificationRule.DeserializeRoleManagementPolicyNotificationRule(element);
                }
            }
            return UnknownRoleManagementPolicyRule.DeserializeUnknownRoleManagementPolicyRule(element);
        }
    }
}
