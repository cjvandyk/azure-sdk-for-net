// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Indicates whether the kubernetes version image is ready or not. </summary>
    public partial class KubernetesVersionReadiness
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesVersionReadiness"/>. </summary>
        internal KubernetesVersionReadiness()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionReadiness"/>. </summary>
        /// <param name="osType"> The particular KubernetesVersion Image OS Type (Linux, Windows). </param>
        /// <param name="osSku"> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </param>
        /// <param name="ready"> Whether the kubernetes version image is ready or not. </param>
        /// <param name="errorMessage"> The error message for version not being ready. </param>
        internal KubernetesVersionReadiness(HybridContainerServiceOSType? osType, HybridContainerServiceOSSku? osSku, bool? ready, string errorMessage)
        {
            OSType = osType;
            OSSku = osSku;
            Ready = ready;
            ErrorMessage = errorMessage;
        }

        /// <summary> The particular KubernetesVersion Image OS Type (Linux, Windows). </summary>
        public HybridContainerServiceOSType? OSType { get; }
        /// <summary> Specifies the OS SKU used by the agent pool. The default is CBLMariner if OSType is Linux. The default is Windows2019 when OSType is Windows. </summary>
        public HybridContainerServiceOSSku? OSSku { get; }
        /// <summary> Whether the kubernetes version image is ready or not. </summary>
        public bool? Ready { get; }
        /// <summary> The error message for version not being ready. </summary>
        public string ErrorMessage { get; }
    }
}
