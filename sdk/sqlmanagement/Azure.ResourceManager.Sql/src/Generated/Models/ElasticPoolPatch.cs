// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An elastic pool update. </summary>
    public partial class ElasticPoolPatch
    {
        /// <summary> Initializes a new instance of <see cref="ElasticPoolPatch"/>. </summary>
        public ElasticPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ElasticPoolPatch"/>. </summary>
        /// <param name="sku"> An ARM Resource SKU. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="maxSizeBytes"> The storage limit for the database elastic pool in bytes. </param>
        /// <param name="minCapacity"> Minimal capacity that serverless pool will not shrink below, if not paused. </param>
        /// <param name="perDatabaseSettings"> The per database settings for the elastic pool. </param>
        /// <param name="isZoneRedundant"> Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be spread across multiple availability zones. </param>
        /// <param name="licenseType"> The license type to apply for this elastic pool. </param>
        /// <param name="maintenanceConfigurationId"> Maintenance configuration id assigned to the elastic pool. This configuration defines the period when the maintenance updates will will occur. </param>
        /// <param name="highAvailabilityReplicaCount"> The number of secondary replicas associated with the elastic pool that are used to provide high availability. Applicable only to Hyperscale elastic pools. </param>
        /// <param name="preferredEnclaveType"> Type of enclave requested on the elastic pool. </param>
        /// <param name="availabilityZone"> Specifies the availability zone the pool's primary replica is pinned to. </param>
        internal ElasticPoolPatch(SqlSku sku, IDictionary<string, string> tags, long? maxSizeBytes, double? minCapacity, ElasticPoolPerDatabaseSettings perDatabaseSettings, bool? isZoneRedundant, ElasticPoolLicenseType? licenseType, ResourceIdentifier maintenanceConfigurationId, int? highAvailabilityReplicaCount, SqlAlwaysEncryptedEnclaveType? preferredEnclaveType, SqlAvailabilityZoneType? availabilityZone)
        {
            Sku = sku;
            Tags = tags;
            MaxSizeBytes = maxSizeBytes;
            MinCapacity = minCapacity;
            PerDatabaseSettings = perDatabaseSettings;
            IsZoneRedundant = isZoneRedundant;
            LicenseType = licenseType;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            HighAvailabilityReplicaCount = highAvailabilityReplicaCount;
            PreferredEnclaveType = preferredEnclaveType;
            AvailabilityZone = availabilityZone;
        }

        /// <summary> An ARM Resource SKU. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The storage limit for the database elastic pool in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> Minimal capacity that serverless pool will not shrink below, if not paused. </summary>
        public double? MinCapacity { get; set; }
        /// <summary> The per database settings for the elastic pool. </summary>
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }
        /// <summary> Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be spread across multiple availability zones. </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary> The license type to apply for this elastic pool. </summary>
        public ElasticPoolLicenseType? LicenseType { get; set; }
        /// <summary> Maintenance configuration id assigned to the elastic pool. This configuration defines the period when the maintenance updates will will occur. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
        /// <summary> The number of secondary replicas associated with the elastic pool that are used to provide high availability. Applicable only to Hyperscale elastic pools. </summary>
        public int? HighAvailabilityReplicaCount { get; set; }
        /// <summary> Type of enclave requested on the elastic pool. </summary>
        public SqlAlwaysEncryptedEnclaveType? PreferredEnclaveType { get; set; }
        /// <summary> Specifies the availability zone the pool's primary replica is pinned to. </summary>
        public SqlAvailabilityZoneType? AvailabilityZone { get; set; }
    }
}
