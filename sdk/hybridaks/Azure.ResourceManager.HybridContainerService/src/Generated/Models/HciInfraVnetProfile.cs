// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Infrastructure network profile for HCI platform. </summary>
    public partial class HciInfraVnetProfile
    {
        /// <summary> Initializes a new instance of <see cref="HciInfraVnetProfile"/>. </summary>
        public HciInfraVnetProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciInfraVnetProfile"/>. </summary>
        /// <param name="mocGroup"> Group in MOC(Microsoft On-premises Cloud). </param>
        /// <param name="mocLocation"> Location in MOC(Microsoft On-premises Cloud). </param>
        /// <param name="mocVnetName"> Virtual Network name in MOC(Microsoft On-premises Cloud). </param>
        internal HciInfraVnetProfile(string mocGroup, string mocLocation, string mocVnetName)
        {
            MocGroup = mocGroup;
            MocLocation = mocLocation;
            MocVnetName = mocVnetName;
        }

        /// <summary> Group in MOC(Microsoft On-premises Cloud). </summary>
        public string MocGroup { get; set; }
        /// <summary> Location in MOC(Microsoft On-premises Cloud). </summary>
        public string MocLocation { get; set; }
        /// <summary> Virtual Network name in MOC(Microsoft On-premises Cloud). </summary>
        public string MocVnetName { get; set; }
    }
}
