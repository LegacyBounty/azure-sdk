// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary> A class representing the DnsCaaRecord data model. </summary>
    public partial class DnsCaaRecordData : DnsBaseRecordData
    {
        /// <summary> Initializes a new instance of DnsCaaRecordData. </summary>
        public DnsCaaRecordData()
        {
            DnsCaaRecords = new ChangeTrackingList<DnsCaaRecordInfo>();
        }

        /// <summary> Initializes a new instance of DnsCaaRecordData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> The etag of the record set. </param>
        /// <param name="metadata"> The metadata attached to the record set. </param>
        /// <param name="ttl"> The Ttl (time-to-live) of the records in the record set. </param>
        /// <param name="fqdn"> Fully qualified domain name of the record set. </param>
        /// <param name="provisioningState"> provisioning State of the record set. </param>
        /// <param name="targetResource"> A reference to an azure resource from where the dns resource value is taken. </param>
        /// <param name="caaRecords"> The list of CAA records in the record set. </param>
        internal DnsCaaRecordData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IDictionary<string, string> metadata, long? ttl, string fqdn, string provisioningState, WritableSubResource targetResource, IList<DnsCaaRecordInfo> caaRecords) : base(id, name, resourceType, systemData, etag, metadata, ttl, fqdn, provisioningState, targetResource)
        {
            DnsCaaRecords = caaRecords;
        }

        /// <summary> The list of CAA records in the record set. </summary>
        public IList<DnsCaaRecordInfo> DnsCaaRecords { get; }
    }
}
