// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchUserAccount : IUtf8JsonSerializable, IJsonModel<BatchUserAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchUserAccount>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchUserAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchUserAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchUserAccount)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("password"u8);
            writer.WriteStringValue(Password);
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel"u8);
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            if (Optional.IsDefined(LinuxUserConfiguration))
            {
                writer.WritePropertyName("linuxUserConfiguration"u8);
                writer.WriteObjectValue(LinuxUserConfiguration);
            }
            if (Optional.IsDefined(WindowsUserConfiguration))
            {
                writer.WritePropertyName("windowsUserConfiguration"u8);
                writer.WriteObjectValue(WindowsUserConfiguration);
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

        BatchUserAccount IJsonModel<BatchUserAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchUserAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchUserAccount)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchUserAccount(document.RootElement, options);
        }

        internal static BatchUserAccount DeserializeBatchUserAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string password = default;
            Optional<BatchUserAccountElevationLevel> elevationLevel = default;
            Optional<BatchLinuxUserConfiguration> linuxUserConfiguration = default;
            Optional<BatchWindowsUserConfiguration> windowsUserConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elevationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToBatchUserAccountElevationLevel();
                    continue;
                }
                if (property.NameEquals("linuxUserConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxUserConfiguration = BatchLinuxUserConfiguration.DeserializeBatchLinuxUserConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsUserConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsUserConfiguration = BatchWindowsUserConfiguration.DeserializeBatchWindowsUserConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchUserAccount(name, password, Optional.ToNullable(elevationLevel), linuxUserConfiguration.Value, windowsUserConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchUserAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchUserAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchUserAccount)} does not support '{options.Format}' format.");
            }
        }

        BatchUserAccount IPersistableModel<BatchUserAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchUserAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchUserAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchUserAccount)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchUserAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
