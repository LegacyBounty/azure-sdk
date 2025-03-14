// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Azure backup recoveryPoint
    /// Please note <see cref="DataProtectionBackupRecoveryPointProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionBackupDiscreteRecoveryPointProperties"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupRecoveryPointProperties
    {
        /// <summary> Initializes a new instance of DataProtectionBackupRecoveryPointProperties. </summary>
        protected DataProtectionBackupRecoveryPointProperties()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionBackupRecoveryPointProperties. </summary>
        /// <param name="objectType"></param>
        internal DataProtectionBackupRecoveryPointProperties(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Gets or sets the object type. </summary>
        internal string ObjectType { get; set; }
    }
}
