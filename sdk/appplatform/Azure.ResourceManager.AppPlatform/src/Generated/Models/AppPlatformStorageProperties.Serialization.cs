// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformStorageProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageType"u8);
            writer.WriteStringValue(StorageType.ToString());
            writer.WriteEndObject();
        }

        internal static AppPlatformStorageProperties DeserializeAppPlatformStorageProperties(JsonElement element)
        {
            if (element.TryGetProperty("storageType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageAccount": return AppPlatformStorageAccount.DeserializeAppPlatformStorageAccount(element);
                }
            }
            return UnknownStorageProperties.DeserializeUnknownStorageProperties(element);
        }
    }
}
