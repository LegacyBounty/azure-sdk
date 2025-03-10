// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameters supplied to the Create Redis operation. </summary>
    public partial class RedisCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of RedisCreateOrUpdateContent. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="sku"> The SKU of the Redis cache to deploy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public RedisCreateOrUpdateContent(AzureLocation location, RedisSku sku)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Zones = new ChangeTrackingList<string>();
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            TenantSettings = new ChangeTrackingDictionary<string, string>();
            Sku = sku;
        }

        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation Location { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. </summary>
        public RedisCommonConfiguration RedisConfiguration { get; set; }
        /// <summary> Redis version. This should be in the form &apos;major[.minor]&apos; (only &apos;major&apos; is required) or the value &apos;latest&apos; which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value is &apos;latest&apos;. </summary>
        public string RedisVersion { get; set; }
        /// <summary> Specifies whether the non-ssl Redis server port (6379) is enabled. </summary>
        public bool? EnableNonSslPort { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        public int? ReplicasPerMaster { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        public int? ReplicasPerPrimary { get; set; }
        /// <summary> A dictionary of tenant settings. </summary>
        public IDictionary<string, string> TenantSettings { get; }
        /// <summary> The number of shards to be created on a Premium Cluster Cache. </summary>
        public int? ShardCount { get; set; }
        /// <summary> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;). </summary>
        public RedisTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access method. Default value is &apos;Enabled&apos;. </summary>
        public RedisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The SKU of the Redis cache to deploy. </summary>
        public RedisSku Sku { get; }
        /// <summary> The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual Network; auto assigned by default. </summary>
        public IPAddress StaticIP { get; set; }
    }
}
