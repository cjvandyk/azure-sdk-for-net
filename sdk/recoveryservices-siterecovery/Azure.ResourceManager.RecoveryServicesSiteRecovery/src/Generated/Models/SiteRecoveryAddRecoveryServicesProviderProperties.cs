// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an add provider request. </summary>
    public partial class SiteRecoveryAddRecoveryServicesProviderProperties
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddRecoveryServicesProviderProperties"/>. </summary>
        /// <param name="machineName"> The name of the machine where the provider is getting added. </param>
        /// <param name="authenticationIdentityContent"> The identity provider input for DRA authentication. </param>
        /// <param name="resourceAccessIdentityContent"> The identity provider input for resource access. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/>, <paramref name="authenticationIdentityContent"/> or <paramref name="resourceAccessIdentityContent"/> is null. </exception>
        public SiteRecoveryAddRecoveryServicesProviderProperties(string machineName, IdentityProviderContent authenticationIdentityContent, IdentityProviderContent resourceAccessIdentityContent)
        {
            Argument.AssertNotNull(machineName, nameof(machineName));
            Argument.AssertNotNull(authenticationIdentityContent, nameof(authenticationIdentityContent));
            Argument.AssertNotNull(resourceAccessIdentityContent, nameof(resourceAccessIdentityContent));

            MachineName = machineName;
            AuthenticationIdentityContent = authenticationIdentityContent;
            ResourceAccessIdentityContent = resourceAccessIdentityContent;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddRecoveryServicesProviderProperties"/>. </summary>
        /// <param name="machineName"> The name of the machine where the provider is getting added. </param>
        /// <param name="machineId"> The Id of the machine where the provider is getting added. </param>
        /// <param name="biosId"> The Bios Id of the machine. </param>
        /// <param name="authenticationIdentityContent"> The identity provider input for DRA authentication. </param>
        /// <param name="resourceAccessIdentityContent"> The identity provider input for resource access. </param>
        /// <param name="dataPlaneAuthenticationIdentityContent"> The identity provider input for data plane authentication. </param>
        internal SiteRecoveryAddRecoveryServicesProviderProperties(string machineName, string machineId, string biosId, IdentityProviderContent authenticationIdentityContent, IdentityProviderContent resourceAccessIdentityContent, IdentityProviderContent dataPlaneAuthenticationIdentityContent)
        {
            MachineName = machineName;
            MachineId = machineId;
            BiosId = biosId;
            AuthenticationIdentityContent = authenticationIdentityContent;
            ResourceAccessIdentityContent = resourceAccessIdentityContent;
            DataPlaneAuthenticationIdentityContent = dataPlaneAuthenticationIdentityContent;
        }

        /// <summary> The name of the machine where the provider is getting added. </summary>
        public string MachineName { get; }
        /// <summary> The Id of the machine where the provider is getting added. </summary>
        public string MachineId { get; set; }
        /// <summary> The Bios Id of the machine. </summary>
        public string BiosId { get; set; }
        /// <summary> The identity provider input for DRA authentication. </summary>
        public IdentityProviderContent AuthenticationIdentityContent { get; }
        /// <summary> The identity provider input for resource access. </summary>
        public IdentityProviderContent ResourceAccessIdentityContent { get; }
        /// <summary> The identity provider input for data plane authentication. </summary>
        public IdentityProviderContent DataPlaneAuthenticationIdentityContent { get; set; }
    }
}
