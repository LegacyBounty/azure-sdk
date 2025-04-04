// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryRunContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunRequestType);
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(LogTemplate))
            {
                writer.WritePropertyName("logTemplate"u8);
                writer.WriteStringValue(LogTemplate);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryRunContent DeserializeContainerRegistryRunContent(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DockerBuildRequest": return ContainerRegistryDockerBuildContent.DeserializeContainerRegistryDockerBuildContent(element);
                    case "EncodedTaskRunRequest": return ContainerRegistryEncodedTaskRunContent.DeserializeContainerRegistryEncodedTaskRunContent(element);
                    case "FileTaskRunRequest": return ContainerRegistryFileTaskRunContent.DeserializeContainerRegistryFileTaskRunContent(element);
                    case "TaskRunRequest": return ContainerRegistryTaskRunContent.DeserializeContainerRegistryTaskRunContent(element);
                }
            }
            return UnknownRunRequest.DeserializeUnknownRunRequest(element);
        }
    }
}
