// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownDataDeletionDetectionPolicy. </summary>
    internal partial class UnknownDataDeletionDetectionPolicy : DataDeletionDetectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataDeletionDetectionPolicy"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of data deletion detection policy. </param>
        internal UnknownDataDeletionDetectionPolicy(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
