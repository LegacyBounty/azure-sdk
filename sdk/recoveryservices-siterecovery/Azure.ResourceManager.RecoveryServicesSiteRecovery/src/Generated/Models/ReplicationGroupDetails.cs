// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication group details. This will be used in case of San. </summary>
    public partial class ReplicationGroupDetails : ConfigurationSettings
    {
        /// <summary> Initializes a new instance of ReplicationGroupDetails. </summary>
        internal ReplicationGroupDetails()
        {
            InstanceType = "ReplicationGroupDetails";
        }

        /// <summary> Initializes a new instance of ReplicationGroupDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal ReplicationGroupDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "ReplicationGroupDetails";
        }
    }
}
