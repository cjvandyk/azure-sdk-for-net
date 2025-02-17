// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyRuleTarget : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyRuleTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyRuleTarget>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleManagementPolicyRuleTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRuleTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyRuleTarget)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Caller))
            {
                writer.WritePropertyName("caller"u8);
                writer.WriteStringValue(Caller);
            }
            if (Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TargetObjects))
            {
                writer.WritePropertyName("targetObjects"u8);
                writer.WriteStartArray();
                foreach (var item in TargetObjects)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InheritableSettings))
            {
                writer.WritePropertyName("inheritableSettings"u8);
                writer.WriteStartArray();
                foreach (var item in InheritableSettings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnforcedSettings))
            {
                writer.WritePropertyName("enforcedSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnforcedSettings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RoleManagementPolicyRuleTarget IJsonModel<RoleManagementPolicyRuleTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRuleTarget>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyRuleTarget)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyRuleTarget(document.RootElement, options);
        }

        internal static RoleManagementPolicyRuleTarget DeserializeRoleManagementPolicyRuleTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> caller = default;
            Optional<IList<string>> operations = default;
            Optional<RoleManagementAssignmentLevel> level = default;
            Optional<IList<string>> targetObjects = default;
            Optional<IList<string>> inheritableSettings = default;
            Optional<IList<string>> enforcedSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("caller"u8))
                {
                    caller = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new RoleManagementAssignmentLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetObjects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    targetObjects = array;
                    continue;
                }
                if (property.NameEquals("inheritableSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inheritableSettings = array;
                    continue;
                }
                if (property.NameEquals("enforcedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    enforcedSettings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleManagementPolicyRuleTarget(caller.Value, Optional.ToList(operations), Optional.ToNullable(level), Optional.ToList(targetObjects), Optional.ToList(inheritableSettings), Optional.ToList(enforcedSettings), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleManagementPolicyRuleTarget>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRuleTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyRuleTarget)} does not support '{options.Format}' format.");
            }
        }

        RoleManagementPolicyRuleTarget IPersistableModel<RoleManagementPolicyRuleTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyRuleTarget>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleManagementPolicyRuleTarget(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyRuleTarget)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyRuleTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
