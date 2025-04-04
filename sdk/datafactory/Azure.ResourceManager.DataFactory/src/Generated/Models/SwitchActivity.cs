// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> This activity evaluates an expression and executes activities under the cases property that correspond to the expression evaluation expected in the equals property. </summary>
    public partial class SwitchActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of SwitchActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="on"> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="on"/> is null. </exception>
        public SwitchActivity(string name, FactoryExpressionDefinition @on) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(@on, nameof(@on));

            On = @on;
            Cases = new ChangeTrackingList<SwitchCaseActivity>();
            DefaultActivities = new ChangeTrackingList<PipelineActivity>();
            ActivityType = "Switch";
        }

        /// <summary> Initializes a new instance of SwitchActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="on"> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </param>
        /// <param name="cases"> List of cases that correspond to expected values of the &apos;on&apos; property. This is an optional property and if not provided, the activity will execute activities provided in defaultActivities. </param>
        /// <param name="defaultActivities">
        /// List of activities to execute if no case condition is satisfied. This is an optional property and if not provided, the activity will exit without any action.
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        internal SwitchActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryExpressionDefinition @on, IList<SwitchCaseActivity> cases, IList<PipelineActivity> defaultActivities) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            On = @on;
            Cases = cases;
            DefaultActivities = defaultActivities;
            ActivityType = activityType ?? "Switch";
        }

        /// <summary> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </summary>
        public FactoryExpressionDefinition On { get; set; }
        /// <summary> List of cases that correspond to expected values of the &apos;on&apos; property. This is an optional property and if not provided, the activity will execute activities provided in defaultActivities. </summary>
        public IList<SwitchCaseActivity> Cases { get; }
        /// <summary>
        /// List of activities to execute if no case condition is satisfied. This is an optional property and if not provided, the activity will exit without any action.
        /// Please note <see cref="PipelineActivity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetDatasetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<PipelineActivity> DefaultActivities { get; }
    }
}
