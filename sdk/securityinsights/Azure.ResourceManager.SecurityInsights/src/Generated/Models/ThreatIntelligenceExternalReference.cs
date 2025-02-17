// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes external reference. </summary>
    public partial class ThreatIntelligenceExternalReference
    {
        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceExternalReference"/>. </summary>
        public ThreatIntelligenceExternalReference()
        {
            Hashes = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceExternalReference"/>. </summary>
        /// <param name="description"> External reference description. </param>
        /// <param name="externalId"> External reference ID. </param>
        /// <param name="sourceName"> External reference source name. </param>
        /// <param name="uri"> External reference URL. </param>
        /// <param name="hashes"> External reference hashes. </param>
        internal ThreatIntelligenceExternalReference(string description, string externalId, string sourceName, Uri uri, IDictionary<string, string> hashes)
        {
            Description = description;
            ExternalId = externalId;
            SourceName = sourceName;
            Uri = uri;
            Hashes = hashes;
        }

        /// <summary> External reference description. </summary>
        public string Description { get; set; }
        /// <summary> External reference ID. </summary>
        public string ExternalId { get; set; }
        /// <summary> External reference source name. </summary>
        public string SourceName { get; set; }
        /// <summary> External reference URL. </summary>
        public Uri Uri { get; set; }
        /// <summary> External reference hashes. </summary>
        public IDictionary<string, string> Hashes { get; }
    }
}
