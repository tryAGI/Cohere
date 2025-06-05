#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class StreamedChatResponseV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.StreamedChatResponseV2>
    {
        /// <inheritdoc />
        public override global::Cohere.StreamedChatResponseV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.StreamedChatResponseV2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.StreamedChatResponseV2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.StreamedChatResponseV2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ChatMessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatMessageStartEvent)}");
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatContentStartEvent? contentStart = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ContentStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatContentStartEvent)}");
                contentStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatContentDeltaEvent? contentDelta = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatContentDeltaEvent)}");
                contentDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatContentEndEvent? contentEnd = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ContentEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatContentEndEvent)}");
                contentEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolPlanDeltaEvent? toolPlanDelta = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ToolPlanDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolPlanDeltaEvent)}");
                toolPlanDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolCallStartEvent? toolCallStart = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ToolCallStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolCallStartEvent)}");
                toolCallStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolCallDeltaEvent? toolCallDelta = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ToolCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolCallDeltaEvent)}");
                toolCallDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolCallEndEvent? toolCallEnd = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.ToolCallEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolCallEndEvent)}");
                toolCallEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatMessageEndEvent? messageEnd = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.MessageEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatMessageEndEvent)}");
                messageEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatDebugEvent? debug = default;
            if (discriminator?.Type == global::Cohere.StreamedChatResponseV2DiscriminatorType.Debug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatDebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatDebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatDebugEvent)}");
                debug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.StreamedChatResponseV2(
                discriminator?.Type,
                messageStart,
                contentStart,
                contentDelta,
                contentEnd,
                toolPlanDelta,
                toolCallStart,
                toolCallDelta,
                toolCallEnd,
                messageEnd,
                debug
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.StreamedChatResponseV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeInfo);
            }
            else if (value.IsContentStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatContentStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentStart, typeInfo);
            }
            else if (value.IsContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatContentDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDelta, typeInfo);
            }
            else if (value.IsContentEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatContentEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatContentEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatContentEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentEnd, typeInfo);
            }
            else if (value.IsToolPlanDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolPlanDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolPlanDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolPlanDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPlanDelta, typeInfo);
            }
            else if (value.IsToolCallStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallStart, typeInfo);
            }
            else if (value.IsToolCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallDelta, typeInfo);
            }
            else if (value.IsToolCallEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallEnd, typeInfo);
            }
            else if (value.IsMessageEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessageEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessageEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessageEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageEnd, typeInfo);
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