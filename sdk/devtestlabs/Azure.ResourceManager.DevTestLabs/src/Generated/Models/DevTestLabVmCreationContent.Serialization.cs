// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabVmCreationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BulkCreationParameters))
            {
                writer.WritePropertyName("bulkCreationParameters"u8);
                writer.WriteObjectValue(BulkCreationParameters);
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(OwnerObjectId))
            {
                writer.WritePropertyName("ownerObjectId"u8);
                writer.WriteStringValue(OwnerObjectId);
            }
            if (Optional.IsDefined(OwnerUserPrincipalName))
            {
                writer.WritePropertyName("ownerUserPrincipalName"u8);
                writer.WriteStringValue(OwnerUserPrincipalName);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(CustomImageId))
            {
                writer.WritePropertyName("customImageId"u8);
                writer.WriteStringValue(CustomImageId);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SshKey))
            {
                writer.WritePropertyName("sshKey"u8);
                writer.WriteStringValue(SshKey);
            }
            if (Optional.IsDefined(IsAuthenticationWithSshKey))
            {
                writer.WritePropertyName("isAuthenticationWithSshKey"u8);
                writer.WriteBooleanValue(IsAuthenticationWithSshKey.Value);
            }
            if (Optional.IsDefined(LabSubnetName))
            {
                writer.WritePropertyName("labSubnetName"u8);
                writer.WriteStringValue(LabSubnetName);
            }
            if (Optional.IsDefined(LabVirtualNetworkId))
            {
                writer.WritePropertyName("labVirtualNetworkId"u8);
                writer.WriteStringValue(LabVirtualNetworkId);
            }
            if (Optional.IsDefined(DisallowPublicIPAddress))
            {
                writer.WritePropertyName("disallowPublicIpAddress"u8);
                writer.WriteBooleanValue(DisallowPublicIPAddress.Value);
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                writer.WriteObjectValue(GalleryImageReference);
            }
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (Optional.IsDefined(NetworkInterface))
            {
                writer.WritePropertyName("networkInterface"u8);
                writer.WriteObjectValue(NetworkInterface);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AllowClaim))
            {
                writer.WritePropertyName("allowClaim"u8);
                writer.WriteBooleanValue(AllowClaim.Value);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(DataDiskParameters))
            {
                writer.WritePropertyName("dataDiskParameters"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleParameters))
            {
                writer.WritePropertyName("scheduleParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DevTestLabVmCreationContent DeserializeDevTestLabVmCreationContent(JsonElement element)
        {
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<BulkCreationParameters> bulkCreationParameters = default;
            Optional<string> notes = default;
            Optional<string> ownerObjectId = default;
            Optional<string> ownerUserPrincipalName = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> customImageId = default;
            Optional<string> size = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            Optional<string> sshKey = default;
            Optional<bool> isAuthenticationWithSshKey = default;
            Optional<string> labSubnetName = default;
            Optional<ResourceIdentifier> labVirtualNetworkId = default;
            Optional<bool> disallowPublicIPAddress = default;
            Optional<IList<DevTestLabArtifactInstallInfo>> artifacts = default;
            Optional<DevTestLabGalleryImageReference> galleryImageReference = default;
            Optional<string> planId = default;
            Optional<DevTestLabNetworkInterface> networkInterface = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<bool> allowClaim = default;
            Optional<string> storageType = default;
            Optional<string> environmentId = default;
            Optional<IList<DevTestLabDataDiskProperties>> dataDiskParameters = default;
            Optional<IList<DevTestLabScheduleCreationParameter>> scheduleParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("bulkCreationParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bulkCreationParameters = BulkCreationParameters.DeserializeBulkCreationParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerObjectId"u8))
                        {
                            ownerObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerUserPrincipalName"u8))
                        {
                            ownerUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("customImageId"u8))
                        {
                            customImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshKey"u8))
                        {
                            sshKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAuthenticationWithSshKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isAuthenticationWithSshKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("labSubnetName"u8))
                        {
                            labSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labVirtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            labVirtualNetworkId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disallowPublicIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disallowPublicIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DevTestLabArtifactInstallInfo> array = new List<DevTestLabArtifactInstallInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabArtifactInstallInfo.DeserializeDevTestLabArtifactInstallInfo(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("galleryImageReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            galleryImageReference = DevTestLabGalleryImageReference.DeserializeDevTestLabGalleryImageReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("planId"u8))
                        {
                            planId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkInterface = DevTestLabNetworkInterface.DeserializeDevTestLabNetworkInterface(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allowClaim"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowClaim = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageType"u8))
                        {
                            storageType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentId"u8))
                        {
                            environmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DevTestLabDataDiskProperties> array = new List<DevTestLabDataDiskProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskProperties.DeserializeDevTestLabDataDiskProperties(item));
                            }
                            dataDiskParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduleParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DevTestLabScheduleCreationParameter> array = new List<DevTestLabScheduleCreationParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabScheduleCreationParameter.DeserializeDevTestLabScheduleCreationParameter(item));
                            }
                            scheduleParameters = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DevTestLabVmCreationContent(name.Value, Optional.ToNullable(location), Optional.ToDictionary(tags), bulkCreationParameters.Value, notes.Value, ownerObjectId.Value, ownerUserPrincipalName.Value, Optional.ToNullable(createdDate), customImageId.Value, size.Value, userName.Value, password.Value, sshKey.Value, Optional.ToNullable(isAuthenticationWithSshKey), labSubnetName.Value, labVirtualNetworkId.Value, Optional.ToNullable(disallowPublicIPAddress), Optional.ToList(artifacts), galleryImageReference.Value, planId.Value, networkInterface.Value, Optional.ToNullable(expirationDate), Optional.ToNullable(allowClaim), storageType.Value, environmentId.Value, Optional.ToList(dataDiskParameters), Optional.ToList(scheduleParameters));
        }
    }
}
