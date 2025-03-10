// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Integration runtime status response. </summary>
    public partial class SynapseIntegrationRuntimeStatusResult
    {
        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeStatusResult. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal SynapseIntegrationRuntimeStatusResult(SynapseIntegrationRuntimeStatus properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeStatusResult. </summary>
        /// <param name="name"> The integration runtime name. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        internal SynapseIntegrationRuntimeStatusResult(string name, SynapseIntegrationRuntimeStatus properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> The integration runtime name. </summary>
        public string Name { get; }
        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntimeStatus"/> and <see cref="SynapseSelfHostedIntegrationRuntimeStatus"/>.
        /// </summary>
        public SynapseIntegrationRuntimeStatus Properties { get; }
    }
}
