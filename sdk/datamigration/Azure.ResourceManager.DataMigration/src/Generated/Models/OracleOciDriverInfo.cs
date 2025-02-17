// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Information about an Oracle OCI driver. </summary>
    public partial class OracleOciDriverInfo
    {
        /// <summary> Initializes a new instance of <see cref="OracleOciDriverInfo"/>. </summary>
        internal OracleOciDriverInfo()
        {
            SupportedOracleVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="OracleOciDriverInfo"/>. </summary>
        /// <param name="driverName"> The name of the driver package. </param>
        /// <param name="driverSize"> The size in bytes of the driver package. </param>
        /// <param name="archiveChecksum"> The MD5 Base64 encoded checksum for the driver package. </param>
        /// <param name="oracleChecksum"> The checksum for the driver package provided by Oracle. </param>
        /// <param name="assemblyVersion"> Version listed in the OCI assembly 'oci.dll'. </param>
        /// <param name="supportedOracleVersions"> List of Oracle database versions supported by this driver. Only major minor of the version is listed. </param>
        internal OracleOciDriverInfo(string driverName, string driverSize, string archiveChecksum, string oracleChecksum, string assemblyVersion, IReadOnlyList<string> supportedOracleVersions)
        {
            DriverName = driverName;
            DriverSize = driverSize;
            ArchiveChecksum = archiveChecksum;
            OracleChecksum = oracleChecksum;
            AssemblyVersion = assemblyVersion;
            SupportedOracleVersions = supportedOracleVersions;
        }

        /// <summary> The name of the driver package. </summary>
        public string DriverName { get; }
        /// <summary> The size in bytes of the driver package. </summary>
        public string DriverSize { get; }
        /// <summary> The MD5 Base64 encoded checksum for the driver package. </summary>
        public string ArchiveChecksum { get; }
        /// <summary> The checksum for the driver package provided by Oracle. </summary>
        public string OracleChecksum { get; }
        /// <summary> Version listed in the OCI assembly 'oci.dll'. </summary>
        public string AssemblyVersion { get; }
        /// <summary> List of Oracle database versions supported by this driver. Only major minor of the version is listed. </summary>
        public IReadOnlyList<string> SupportedOracleVersions { get; }
    }
}
