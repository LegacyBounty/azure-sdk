// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing the AvsPrivateCloudClusterVirtualMachine data model. </summary>
    public partial class AvsPrivateCloudClusterVirtualMachineData : ResourceData
    {
        /// <summary> Initializes a new instance of AvsPrivateCloudClusterVirtualMachineData. </summary>
        public AvsPrivateCloudClusterVirtualMachineData()
        {
        }

        /// <summary> Initializes a new instance of AvsPrivateCloudClusterVirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the VM. </param>
        /// <param name="moRefId"> Virtual machine managed object reference id. </param>
        /// <param name="folderPath"> Path to virtual machine&apos;s folder starting from datacenter virtual machine folder. </param>
        /// <param name="restrictMovement"> Whether VM DRS-driven movement is restricted (enabled) or not (disabled). </param>
        internal AvsPrivateCloudClusterVirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string moRefId, string folderPath, VirtualMachineRestrictMovementState? restrictMovement) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            MoRefId = moRefId;
            FolderPath = folderPath;
            RestrictMovement = restrictMovement;
        }

        /// <summary> Display name of the VM. </summary>
        public string DisplayName { get; }
        /// <summary> Virtual machine managed object reference id. </summary>
        public string MoRefId { get; }
        /// <summary> Path to virtual machine&apos;s folder starting from datacenter virtual machine folder. </summary>
        public string FolderPath { get; }
        /// <summary> Whether VM DRS-driven movement is restricted (enabled) or not (disabled). </summary>
        public VirtualMachineRestrictMovementState? RestrictMovement { get; }
    }
}
