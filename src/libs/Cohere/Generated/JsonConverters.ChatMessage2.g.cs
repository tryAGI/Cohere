#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessage2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ChatMessage2>
    {
        /// <inheritdoc />
        public override global::Cohere.ChatMessage2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.UserMessage? userMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.UserMessage).Name}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.AssistantMessage? assistantMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.AssistantMessage).Name}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.SystemMessage? systemMessage = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.SystemMessage).Name}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.ToolMessage2? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage2).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.ChatMessage2(
                userMessage,
                assistantMessage,
                systemMessage,
                tool
                );

            if (userMessage != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.UserMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (assistantMessage != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.AssistantMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (systemMessage != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.SystemMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ChatMessage2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
            else if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}