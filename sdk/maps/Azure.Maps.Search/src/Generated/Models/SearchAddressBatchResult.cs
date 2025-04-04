// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search Address Batch service call. </summary>
    public partial class SearchAddressBatchResult : BatchResult
    {
        /// <summary> Initializes a new instance of SearchAddressBatchResult. </summary>
        internal SearchAddressBatchResult()
        {
            BatchItems = new ChangeTrackingList<SearchAddressBatchItem>();
        }
    }
}
