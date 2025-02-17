// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringVolumeFreeSpacePolicyStatus
    {
        internal static CloudTieringVolumeFreeSpacePolicyStatus DeserializeCloudTieringVolumeFreeSpacePolicyStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<int> effectiveVolumeFreeSpacePolicy = default;
            Optional<int> currentVolumeFreeSpacePercent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("effectiveVolumeFreeSpacePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveVolumeFreeSpacePolicy = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentVolumeFreeSpacePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVolumeFreeSpacePercent = property.Value.GetInt32();
                    continue;
                }
            }
            return new CloudTieringVolumeFreeSpacePolicyStatus(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(effectiveVolumeFreeSpacePolicy), Optional.ToNullable(currentVolumeFreeSpacePercent));
        }
    }
}
