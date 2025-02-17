// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Kubernetes version profile for given major.minor release. </summary>
    public partial class KubernetesVersionProperties
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesVersionProperties"/>. </summary>
        internal KubernetesVersionProperties()
        {
            PatchVersions = new ChangeTrackingDictionary<string, KubernetesPatchVersions>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionProperties"/>. </summary>
        /// <param name="version"> major.minor version of Kubernetes release. </param>
        /// <param name="isPreview"> Whether this version is in preview mode. </param>
        /// <param name="patchVersions"> Patch versions of a Kubernetes release. </param>
        internal KubernetesVersionProperties(string version, bool? isPreview, IReadOnlyDictionary<string, KubernetesPatchVersions> patchVersions)
        {
            Version = version;
            IsPreview = isPreview;
            PatchVersions = patchVersions;
        }

        /// <summary> major.minor version of Kubernetes release. </summary>
        public string Version { get; }
        /// <summary> Whether this version is in preview mode. </summary>
        public bool? IsPreview { get; }
        /// <summary> Patch versions of a Kubernetes release. </summary>
        public IReadOnlyDictionary<string, KubernetesPatchVersions> PatchVersions { get; }
    }
}
