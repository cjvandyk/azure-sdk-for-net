// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Input for InstallPatches as directly received by the API. </summary>
    public partial class MachineInstallPatchesContent
    {
        /// <summary> Initializes a new instance of <see cref="MachineInstallPatchesContent"/>. </summary>
        /// <param name="maximumDuration"> Specifies the maximum amount of time that the operation will run. It must be an ISO 8601-compliant duration string such as PT4H (4 hours). </param>
        /// <param name="rebootSetting"> Defines when it is acceptable to reboot a VM during a software update operation. </param>
        public MachineInstallPatchesContent(TimeSpan maximumDuration, VmGuestPatchRebootSetting rebootSetting)
        {
            MaximumDuration = maximumDuration;
            RebootSetting = rebootSetting;
        }

        /// <summary> Initializes a new instance of <see cref="MachineInstallPatchesContent"/>. </summary>
        /// <param name="maximumDuration"> Specifies the maximum amount of time that the operation will run. It must be an ISO 8601-compliant duration string such as PT4H (4 hours). </param>
        /// <param name="rebootSetting"> Defines when it is acceptable to reboot a VM during a software update operation. </param>
        /// <param name="windowsParameters"> Input for InstallPatches on a Windows VM, as directly received by the API. </param>
        /// <param name="linuxParameters"> Input for InstallPatches on a Linux VM, as directly received by the API. </param>
        internal MachineInstallPatchesContent(TimeSpan maximumDuration, VmGuestPatchRebootSetting rebootSetting, HybridComputeWindowsParameters windowsParameters, HybridComputeLinuxParameters linuxParameters)
        {
            MaximumDuration = maximumDuration;
            RebootSetting = rebootSetting;
            WindowsParameters = windowsParameters;
            LinuxParameters = linuxParameters;
        }

        /// <summary> Specifies the maximum amount of time that the operation will run. It must be an ISO 8601-compliant duration string such as PT4H (4 hours). </summary>
        public TimeSpan MaximumDuration { get; }
        /// <summary> Defines when it is acceptable to reboot a VM during a software update operation. </summary>
        public VmGuestPatchRebootSetting RebootSetting { get; }
        /// <summary> Input for InstallPatches on a Windows VM, as directly received by the API. </summary>
        public HybridComputeWindowsParameters WindowsParameters { get; set; }
        /// <summary> Input for InstallPatches on a Linux VM, as directly received by the API. </summary>
        public HybridComputeLinuxParameters LinuxParameters { get; set; }
    }
}
