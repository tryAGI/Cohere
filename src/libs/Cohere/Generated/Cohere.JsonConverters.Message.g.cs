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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.MessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.MessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.MessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ChatMessage? chatbot = default;
            if (discriminator?.Role == global::Cohere.MessageDiscriminatorRole.Chatbot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatMessage)}");
                chatbot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatToolMessage? tool = default;
            if (discriminator?.Role == global::Cohere.MessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cohere.Message(
                discriminator?.Role,
                chatbot,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatbot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chatbot!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
        }
    }
}