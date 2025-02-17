// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Reprotect agent details. </summary>
    public partial class ReprotectAgentDetails
    {
        /// <summary> Initializes a new instance of <see cref="ReprotectAgentDetails"/>. </summary>
        internal ReprotectAgentDetails()
        {
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
            AccessibleDatastores = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ReprotectAgentDetails"/>. </summary>
        /// <param name="id"> The reprotect agent Id. </param>
        /// <param name="name"> The reprotect agent name. </param>
        /// <param name="biosId"> The reprotect agent Bios Id. </param>
        /// <param name="fabricObjectId"> The fabric object Id. </param>
        /// <param name="fqdn"> The reprotect agent Fqdn. </param>
        /// <param name="version"> The version. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the reprotect agent. </param>
        /// <param name="health"> The health of the reprotect agent. </param>
        /// <param name="healthErrors"> The health errors. </param>
        /// <param name="protectedItemCount"> The protected item count. </param>
        /// <param name="accessibleDatastores"> The list of accessible datastores fetched from discovery. </param>
        /// <param name="vCenterId"> The Vcenter Id. </param>
        /// <param name="last"> The last time when SDS information discovered in SRS. </param>
        internal ReprotectAgentDetails(string id, string name, string biosId, ResourceIdentifier fabricObjectId, string fqdn, string version, DateTimeOffset? lastHeartbeatReceivedOn, SiteRecoveryProtectionHealth? health, IReadOnlyList<SiteRecoveryHealthError> healthErrors, int? protectedItemCount, IReadOnlyList<string> accessibleDatastores, string vCenterId, DateTimeOffset? last)
        {
            Id = id;
            Name = name;
            BiosId = biosId;
            FabricObjectId = fabricObjectId;
            Fqdn = fqdn;
            Version = version;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            Health = health;
            HealthErrors = healthErrors;
            ProtectedItemCount = protectedItemCount;
            AccessibleDatastores = accessibleDatastores;
            VCenterId = vCenterId;
            Last = last;
        }

        /// <summary> The reprotect agent Id. </summary>
        public string Id { get; }
        /// <summary> The reprotect agent name. </summary>
        public string Name { get; }
        /// <summary> The reprotect agent Bios Id. </summary>
        public string BiosId { get; }
        /// <summary> The fabric object Id. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The reprotect agent Fqdn. </summary>
        public string Fqdn { get; }
        /// <summary> The version. </summary>
        public string Version { get; }
        /// <summary> The last heartbeat received from the reprotect agent. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> The health of the reprotect agent. </summary>
        public SiteRecoveryProtectionHealth? Health { get; }
        /// <summary> The health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
        /// <summary> The protected item count. </summary>
        public int? ProtectedItemCount { get; }
        /// <summary> The list of accessible datastores fetched from discovery. </summary>
        public IReadOnlyList<string> AccessibleDatastores { get; }
        /// <summary> The Vcenter Id. </summary>
        public string VCenterId { get; }
        /// <summary> The last time when SDS information discovered in SRS. </summary>
        public DateTimeOffset? Last { get; }
    }
}
