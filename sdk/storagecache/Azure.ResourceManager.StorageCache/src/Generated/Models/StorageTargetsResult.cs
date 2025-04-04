// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> A list of Storage Targets. </summary>
    internal partial class StorageTargetsResult
    {
        /// <summary> Initializes a new instance of StorageTargetsResult. </summary>
        internal StorageTargetsResult()
        {
            Value = new ChangeTrackingList<StorageTargetData>();
        }

        /// <summary> Initializes a new instance of StorageTargetsResult. </summary>
        /// <param name="nextLink"> The URI to fetch the next page of Storage Targets. </param>
        /// <param name="value"> The list of Storage Targets defined for the Cache. </param>
        internal StorageTargetsResult(string nextLink, IReadOnlyList<StorageTargetData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URI to fetch the next page of Storage Targets. </summary>
        public string NextLink { get; }
        /// <summary> The list of Storage Targets defined for the Cache. </summary>
        public IReadOnlyList<StorageTargetData> Value { get; }
    }
}
