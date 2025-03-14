// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the application server configuration. </summary>
    public partial class ApplicationServerConfiguration
    {
        /// <summary> Initializes a new instance of ApplicationServerConfiguration. </summary>
        /// <param name="subnetId"> The subnet id. </param>
        /// <param name="virtualMachineConfiguration"> Gets or sets the virtual machine configuration. </param>
        /// <param name="instanceCount"> The number of app server instances. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/> or <paramref name="virtualMachineConfiguration"/> is null. </exception>
        public ApplicationServerConfiguration(ResourceIdentifier subnetId, VirtualMachineConfiguration virtualMachineConfiguration, long instanceCount)
        {
            Argument.AssertNotNull(subnetId, nameof(subnetId));
            Argument.AssertNotNull(virtualMachineConfiguration, nameof(virtualMachineConfiguration));

            SubnetId = subnetId;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            InstanceCount = instanceCount;
        }

        /// <summary> The subnet id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Gets or sets the virtual machine configuration. </summary>
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        /// <summary> The number of app server instances. </summary>
        public long InstanceCount { get; set; }
    }
}
