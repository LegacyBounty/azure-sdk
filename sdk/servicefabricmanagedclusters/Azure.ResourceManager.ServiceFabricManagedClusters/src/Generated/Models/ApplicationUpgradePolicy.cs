// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the policy for a monitored application upgrade. </summary>
    public partial class ApplicationUpgradePolicy
    {
        /// <summary> Initializes a new instance of ApplicationUpgradePolicy. </summary>
        public ApplicationUpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of ApplicationUpgradePolicy. </summary>
        /// <param name="applicationHealthPolicy">
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        /// 
        /// </param>
        /// <param name="forceRestart"> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </param>
        /// <param name="rollingUpgradeMonitoringPolicy"> The policy used for monitoring the application upgrade. </param>
        /// <param name="instanceCloseDelayDurationInSeconds"> Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully. This would be effective when the instance is closing during the application/cluster upgrade, only for those instances which have a non-zero delay duration configured in the service description. </param>
        /// <param name="upgradeMode"> The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto. </param>
        /// <param name="upgradeReplicaSetCheckTimeout"> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). </param>
        /// <param name="recreateApplication"> Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed. </param>
        internal ApplicationUpgradePolicy(ApplicationHealthPolicy applicationHealthPolicy, bool? forceRestart, RollingUpgradeMonitoringPolicy rollingUpgradeMonitoringPolicy, long? instanceCloseDelayDurationInSeconds, RollingUpgradeMode? upgradeMode, long? upgradeReplicaSetCheckTimeout, bool? recreateApplication)
        {
            ApplicationHealthPolicy = applicationHealthPolicy;
            ForceRestart = forceRestart;
            RollingUpgradeMonitoringPolicy = rollingUpgradeMonitoringPolicy;
            InstanceCloseDelayDurationInSeconds = instanceCloseDelayDurationInSeconds;
            UpgradeMode = upgradeMode;
            UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            RecreateApplication = recreateApplication;
        }

        /// <summary>
        /// Defines a health policy used to evaluate the health of an application or one of its children entities.
        /// 
        /// </summary>
        public ApplicationHealthPolicy ApplicationHealthPolicy { get; set; }
        /// <summary> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </summary>
        public bool? ForceRestart { get; set; }
        /// <summary> The policy used for monitoring the application upgrade. </summary>
        public RollingUpgradeMonitoringPolicy RollingUpgradeMonitoringPolicy { get; set; }
        /// <summary> Duration in seconds, to wait before a stateless instance is closed, to allow the active requests to drain gracefully. This would be effective when the instance is closing during the application/cluster upgrade, only for those instances which have a non-zero delay duration configured in the service description. </summary>
        public long? InstanceCloseDelayDurationInSeconds { get; set; }
        /// <summary> The mode used to monitor health during a rolling upgrade. The values are Monitored, and UnmonitoredAuto. </summary>
        public RollingUpgradeMode? UpgradeMode { get; set; }
        /// <summary> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. Valid values are between 0 and 42949672925 inclusive. (unsigned 32-bit integer). </summary>
        public long? UpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary> Determines whether the application should be recreated on update. If value=true, the rest of the upgrade policy parameters are not allowed. </summary>
        public bool? RecreateApplication { get; set; }
    }
}
