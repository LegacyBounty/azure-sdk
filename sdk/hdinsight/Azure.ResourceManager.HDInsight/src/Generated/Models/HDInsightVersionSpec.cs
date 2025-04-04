// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The version properties. </summary>
    public partial class HDInsightVersionSpec
    {
        /// <summary> Initializes a new instance of HDInsightVersionSpec. </summary>
        internal HDInsightVersionSpec()
        {
            ComponentVersions = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HDInsightVersionSpec. </summary>
        /// <param name="friendlyName"> The friendly name. </param>
        /// <param name="displayName"> The display name. </param>
        /// <param name="isDefault"> Whether or not the version is the default version. </param>
        /// <param name="componentVersions"> The component version property. </param>
        internal HDInsightVersionSpec(string friendlyName, string displayName, bool? isDefault, IReadOnlyDictionary<string, string> componentVersions)
        {
            FriendlyName = friendlyName;
            DisplayName = displayName;
            IsDefault = isDefault;
            ComponentVersions = componentVersions;
        }

        /// <summary> The friendly name. </summary>
        public string FriendlyName { get; }
        /// <summary> The display name. </summary>
        public string DisplayName { get; }
        /// <summary> Whether or not the version is the default version. </summary>
        public bool? IsDefault { get; }
        /// <summary> The component version property. </summary>
        public IReadOnlyDictionary<string, string> ComponentVersions { get; }
    }
}
