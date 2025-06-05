#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.StreamedChatResponse>
    {
        /// <inheritdoc />
        public override global::Cohere.StreamedChatResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.StreamedChatResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.StreamedChatResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.StreamedChatResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ChatStreamStartEvent? streamStart = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.StreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatStreamStartEvent)}");
                streamStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatSearchQueriesGenerationEvent? searchQueriesGeneration = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.SearchQueriesGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatSearchQueriesGenerationEvent)}");
                searchQueriesGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatSearchResultsEvent? searchResults = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.SearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatSearchResultsEvent)}");
                searchResults = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatTextGenerationEvent? textGeneration = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.TextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatTextGenerationEvent)}");
                textGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatCitationGenerationEvent? citationGeneration = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.CitationGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatCitationGenerationEvent)}");
                citationGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolCallsGenerationEvent? toolCallsGeneration = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.ToolCallsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolCallsGenerationEvent)}");
                toolCallsGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatStreamEndEvent? streamEnd = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.StreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatStreamEndEvent)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolCallsChunkEvent? toolCallsChunk = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.ToolCallsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolCallsChunkEvent)}");
                toolCallsChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatDebugEvent? debug = default;
            if (discriminator?.EventType == global::Cohere.StreamedChatResponseDiscriminatorEventType.Debug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatDebugEvent)}");
                debug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.StreamedChatResponse(
                discriminator?.EventType,
                streamStart,
                searchQueriesGeneration,
                searchResults,
                textGeneration,
                citationGeneration,
                toolCallsGeneration,
                streamEnd,
                toolCallsChunk,
                debug
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.StreamedChatResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatStreamStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamStart, typeInfo);
            }
            else if (value.IsSearchQueriesGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatSearchQueriesGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatSearchQueriesGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatSearchQueriesGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchQueriesGeneration, typeInfo);
            }
            else if (value.IsSearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatSearchResultsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatSearchResultsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatSearchResultsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResults, typeInfo);
            }
            else if (value.IsTextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatTextGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatTextGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatTextGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGeneration, typeInfo);
            }
            else if (value.IsCitationGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatCitationGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatCitationGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatCitationGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationGeneration, typeInfo);
            }
            else if (value.IsToolCallsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallsGenerationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallsGenerationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallsGenerationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsGeneration, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatStreamEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsToolCallsChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallsChunkEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallsChunkEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallsChunkEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallsChunk, typeInfo);
            }
            else if (value.IsDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatDebugEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Debug, typeInfo);
            }
        }
    }
}