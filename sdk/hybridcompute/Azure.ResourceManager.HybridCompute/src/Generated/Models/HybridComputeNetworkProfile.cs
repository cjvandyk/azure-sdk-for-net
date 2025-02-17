// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the network information on this machine. </summary>
    public partial class HybridComputeNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputeNetworkProfile"/>. </summary>
        internal HybridComputeNetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<HybridComputeNetworkInterface>();
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> The list of network interfaces. </param>
        internal HybridComputeNetworkProfile(IReadOnlyList<HybridComputeNetworkInterface> networkInterfaces)
        {
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> The list of network interfaces. </summary>
        public IReadOnlyList<HybridComputeNetworkInterface> NetworkInterfaces { get; }
    }
}
