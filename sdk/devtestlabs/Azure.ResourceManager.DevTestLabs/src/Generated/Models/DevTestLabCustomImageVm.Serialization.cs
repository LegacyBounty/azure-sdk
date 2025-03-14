// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCustomImageVm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVmId))
            {
                writer.WritePropertyName("sourceVmId"u8);
                writer.WriteStringValue(SourceVmId);
            }
            if (Optional.IsDefined(WindowsOSInfo))
            {
                writer.WritePropertyName("windowsOsInfo"u8);
                writer.WriteObjectValue(WindowsOSInfo);
            }
            if (Optional.IsDefined(LinuxOSInfo))
            {
                writer.WritePropertyName("linuxOsInfo"u8);
                writer.WriteObjectValue(LinuxOSInfo);
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabCustomImageVm DeserializeDevTestLabCustomImageVm(JsonElement element)
        {
            Optional<string> sourceVmId = default;
            Optional<WindowsOSInfo> windowsOSInfo = default;
            Optional<LinuxOSInfo> linuxOSInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVmId"u8))
                {
                    sourceVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsOsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowsOSInfo = WindowsOSInfo.DeserializeWindowsOSInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxOsInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxOSInfo = LinuxOSInfo.DeserializeLinuxOSInfo(property.Value);
                    continue;
                }
            }
            return new DevTestLabCustomImageVm(sourceVmId.Value, windowsOSInfo.Value, linuxOSInfo.Value);
        }
    }
}
