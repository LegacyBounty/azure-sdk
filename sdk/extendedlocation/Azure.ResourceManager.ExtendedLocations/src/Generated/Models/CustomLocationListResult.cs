// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ExtendedLocations;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> The List Custom Locations operation response. </summary>
    internal partial class CustomLocationListResult
    {
        /// <summary> Initializes a new instance of CustomLocationListResult. </summary>
        internal CustomLocationListResult()
        {
            Value = new ChangeTrackingList<CustomLocationData>();
        }

        /// <summary> Initializes a new instance of CustomLocationListResult. </summary>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="value"> The list of Custom Locations. </param>
        internal CustomLocationListResult(string nextLink, IReadOnlyList<CustomLocationData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
        /// <summary> The list of Custom Locations. </summary>
        public IReadOnlyList<CustomLocationData> Value { get; }
    }
}
