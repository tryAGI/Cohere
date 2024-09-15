#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class MessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Message>
    {
        /// <inheritdoc />
        public override global::Cohere.Message Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.ChatMessage? chat = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessage).Name}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.ToolMessage? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.Message(
                chat,
                tool
                );

            if (chat != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}