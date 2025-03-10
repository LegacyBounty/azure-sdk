// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Platform specific packet core control plane version properties. </summary>
    public partial class Platform
    {
        /// <summary> Initializes a new instance of Platform. </summary>
        public Platform()
        {
        }

        /// <summary> Initializes a new instance of Platform. </summary>
        /// <param name="platformType"> The platform type where this version can be deployed. </param>
        /// <param name="versionState"> The state of this packet core control plane version on this platform. </param>
        /// <param name="minimumPlatformSoftwareVersion"> The minimum software version of the platform where this packet core version can be deployed. </param>
        /// <param name="maximumPlatformSoftwareVersion"> The maximum software version of the platform where this packet core version can be deployed. </param>
        /// <param name="recommendedVersion"> Indicates whether this is the recommended version for this platform. </param>
        /// <param name="obsoleteVersion"> Indicates whether this version is obsoleted for this platform. </param>
        internal Platform(PlatformType? platformType, VersionState? versionState, string minimumPlatformSoftwareVersion, string maximumPlatformSoftwareVersion, RecommendedVersion? recommendedVersion, ObsoleteVersion? obsoleteVersion)
        {
            PlatformType = platformType;
            VersionState = versionState;
            MinimumPlatformSoftwareVersion = minimumPlatformSoftwareVersion;
            MaximumPlatformSoftwareVersion = maximumPlatformSoftwareVersion;
            RecommendedVersion = recommendedVersion;
            ObsoleteVersion = obsoleteVersion;
        }

        /// <summary> The platform type where this version can be deployed. </summary>
        public PlatformType? PlatformType { get; set; }
        /// <summary> The state of this packet core control plane version on this platform. </summary>
        public VersionState? VersionState { get; set; }
        /// <summary> The minimum software version of the platform where this packet core version can be deployed. </summary>
        public string MinimumPlatformSoftwareVersion { get; set; }
        /// <summary> The maximum software version of the platform where this packet core version can be deployed. </summary>
        public string MaximumPlatformSoftwareVersion { get; set; }
        /// <summary> Indicates whether this is the recommended version for this platform. </summary>
        public RecommendedVersion? RecommendedVersion { get; set; }
        /// <summary> Indicates whether this version is obsoleted for this platform. </summary>
        public ObsoleteVersion? ObsoleteVersion { get; set; }
    }
}
