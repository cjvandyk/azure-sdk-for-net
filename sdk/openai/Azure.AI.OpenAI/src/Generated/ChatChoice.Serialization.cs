// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatChoice
    {
        internal static ChatChoice DeserializeChatChoice(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ChatResponseMessage> message = default;
            int index = default;
            CompletionsFinishReason? finishReason = default;
            Optional<ChatFinishDetails> finishDetails = default;
            Optional<ChatResponseMessage> delta = default;
            Optional<ContentFilterResultsForChoice> contentFilterResults = default;
            Optional<AzureChatEnhancements> enhancements = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = ChatResponseMessage.DeserializeChatResponseMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishReason = null;
                        continue;
                    }
                    finishReason = new CompletionsFinishReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("finish_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishDetails = ChatFinishDetails.DeserializeChatFinishDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delta = ChatResponseMessage.DeserializeChatResponseMessage(property.Value);
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ContentFilterResultsForChoice.DeserializeContentFilterResultsForChoice(property.Value);
                    continue;
                }
                if (property.NameEquals("enhancements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancements = AzureChatEnhancements.DeserializeAzureChatEnhancements(property.Value);
                    continue;
                }
            }
            return new ChatChoice(message.Value, index, finishReason, finishDetails.Value, delta.Value, contentFilterResults.Value, enhancements.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatChoice FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatChoice(document.RootElement);
        }
    }
}
