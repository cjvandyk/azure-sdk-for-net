// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SecretConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("uri"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(WorkspaceSecretName))
            {
                if (WorkspaceSecretName != null)
                {
                    writer.WritePropertyName("workspaceSecretName"u8);
                    writer.WriteStringValue(WorkspaceSecretName);
                }
                else
                {
                    writer.WriteNull("workspaceSecretName");
                }
            }
            writer.WriteEndObject();
        }

        internal static SecretConfiguration DeserializeSecretConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> uri = default;
            Optional<string> workspaceSecretName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workspaceSecretName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workspaceSecretName = null;
                        continue;
                    }
                    workspaceSecretName = property.Value.GetString();
                    continue;
                }
            }
            return new SecretConfiguration(uri.Value, workspaceSecretName.Value);
        }
    }
}
