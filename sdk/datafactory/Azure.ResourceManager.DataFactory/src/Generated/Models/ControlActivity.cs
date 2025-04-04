// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Base class for all control activities like IfCondition, ForEach , Until.
    /// Please note <see cref="ControlActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="IfConditionActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/> and <see cref="WebHookActivity"/>.
    /// </summary>
    public partial class ControlActivity : PipelineActivity
    {
        /// <summary> Initializes a new instance of ControlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ControlActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ActivityType = "Container";
        }

        /// <summary> Initializes a new instance of ControlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ControlActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            ActivityType = activityType ?? "Container";
        }
    }
}
