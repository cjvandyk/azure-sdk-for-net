// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The profile for the underlying cloud infrastructure provider for the provisioned cluster. </summary>
    internal partial class ProvisionedClusterCloudProviderProfile
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterCloudProviderProfile"/>. </summary>
        public ProvisionedClusterCloudProviderProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterCloudProviderProfile"/>. </summary>
        /// <param name="infraNetworkProfile"> The profile for the infrastructure networks used by the provisioned cluster. </param>
        internal ProvisionedClusterCloudProviderProfile(ProvisionedClusterInfraNetworkProfile infraNetworkProfile)
        {
            InfraNetworkProfile = infraNetworkProfile;
        }

        /// <summary> The profile for the infrastructure networks used by the provisioned cluster. </summary>
        internal ProvisionedClusterInfraNetworkProfile InfraNetworkProfile { get; set; }
        /// <summary> List of ARM resource Ids (maximum 1) for the infrastructure network object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/logicalNetworks/{logicalNetworkName}. </summary>
        public IList<ResourceIdentifier> InfraNetworkVnetSubnetIds
        {
            get
            {
                if (InfraNetworkProfile is null)
                    InfraNetworkProfile = new ProvisionedClusterInfraNetworkProfile();
                return InfraNetworkProfile.VnetSubnetIds;
            }
        }
    }
}
