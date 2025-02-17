// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Http logs configuration. </summary>
    public partial class AppServiceHttpLogsConfig
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceHttpLogsConfig"/>. </summary>
        public AppServiceHttpLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpLogsConfig"/>. </summary>
        /// <param name="fileSystem"> Http logs to file system configuration. </param>
        /// <param name="azureBlobStorage"> Http logs to azure blob storage configuration. </param>
        internal AppServiceHttpLogsConfig(FileSystemHttpLogsConfig fileSystem, AppServiceBlobStorageHttpLogsConfig azureBlobStorage)
        {
            FileSystem = fileSystem;
            AzureBlobStorage = azureBlobStorage;
        }

        /// <summary> Http logs to file system configuration. </summary>
        public FileSystemHttpLogsConfig FileSystem { get; set; }
        /// <summary> Http logs to azure blob storage configuration. </summary>
        public AppServiceBlobStorageHttpLogsConfig AzureBlobStorage { get; set; }
    }
}
