// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the LogicWorkflowRunActionRepetitionDefinition data model. </summary>
    public partial class LogicWorkflowRunActionRepetitionDefinitionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of LogicWorkflowRunActionRepetitionDefinitionData. </summary>
        /// <param name="location"> The location. </param>
        public LogicWorkflowRunActionRepetitionDefinitionData(AzureLocation location) : base(location)
        {
            RetryHistory = new ChangeTrackingList<LogicWorkRetryHistory>();
            RepetitionIndexes = new ChangeTrackingList<LogicWorkflowRepetitionIndex>();
        }

        /// <summary> Initializes a new instance of LogicWorkflowRunActionRepetitionDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="startOn"> The start time of the workflow scope repetition. </param>
        /// <param name="endOn"> The end time of the workflow scope repetition. </param>
        /// <param name="correlation"> The correlation properties. </param>
        /// <param name="status"> The status of the workflow scope repetition. </param>
        /// <param name="code"> The workflow scope repetition code. </param>
        /// <param name="error"> Anything. </param>
        /// <param name="trackingId"> Gets the tracking id. </param>
        /// <param name="inputs"> Gets the inputs. </param>
        /// <param name="inputsLink"> Gets the link to inputs. </param>
        /// <param name="outputs"> Gets the outputs. </param>
        /// <param name="outputsLink"> Gets the link to outputs. </param>
        /// <param name="trackedProperties"> Gets the tracked properties. </param>
        /// <param name="retryHistory"> Gets the retry histories. </param>
        /// <param name="iterationCount"></param>
        /// <param name="repetitionIndexes"> The repetition indexes. </param>
        internal LogicWorkflowRunActionRepetitionDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DateTimeOffset? startOn, DateTimeOffset? endOn, LogicWorkflowRunActionCorrelation correlation, LogicWorkflowStatus? status, string code, BinaryData error, Guid? trackingId, BinaryData inputs, LogicContentLink inputsLink, BinaryData outputs, LogicContentLink outputsLink, BinaryData trackedProperties, IList<LogicWorkRetryHistory> retryHistory, int? iterationCount, IList<LogicWorkflowRepetitionIndex> repetitionIndexes) : base(id, name, resourceType, systemData, tags, location)
        {
            StartOn = startOn;
            EndOn = endOn;
            Correlation = correlation;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Inputs = inputs;
            InputsLink = inputsLink;
            Outputs = outputs;
            OutputsLink = outputsLink;
            TrackedProperties = trackedProperties;
            RetryHistory = retryHistory;
            IterationCount = iterationCount;
            RepetitionIndexes = repetitionIndexes;
        }

        /// <summary> The start time of the workflow scope repetition. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time of the workflow scope repetition. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The correlation properties. </summary>
        public LogicWorkflowRunActionCorrelation Correlation { get; set; }
        /// <summary> The status of the workflow scope repetition. </summary>
        public LogicWorkflowStatus? Status { get; set; }
        /// <summary> The workflow scope repetition code. </summary>
        public string Code { get; set; }
        /// <summary>
        /// Anything
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Error { get; set; }
        /// <summary> Gets the tracking id. </summary>
        public Guid? TrackingId { get; }
        /// <summary>
        /// Gets the inputs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Inputs { get; }
        /// <summary> Gets the link to inputs. </summary>
        public LogicContentLink InputsLink { get; }
        /// <summary>
        /// Gets the outputs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Outputs { get; }
        /// <summary> Gets the link to outputs. </summary>
        public LogicContentLink OutputsLink { get; }
        /// <summary>
        /// Gets the tracked properties.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData TrackedProperties { get; }
        /// <summary> Gets the retry histories. </summary>
        public IList<LogicWorkRetryHistory> RetryHistory { get; }
        /// <summary> Gets or sets the iteration count. </summary>
        public int? IterationCount { get; set; }
        /// <summary> The repetition indexes. </summary>
        public IList<LogicWorkflowRepetitionIndex> RepetitionIndexes { get; }
    }
}
