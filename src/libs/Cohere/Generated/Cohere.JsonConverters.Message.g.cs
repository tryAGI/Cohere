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

            global::Cohere.ChatMessage? cHATBOT = default;
            if (discriminator?.Role == global::Cohere.MessageDiscriminatorRole.CHATBOT)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatMessage)}");
                cHATBOT = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ToolMessage? tOOL = default;
            if (discriminator?.Role == global::Cohere.MessageDiscriminatorRole.TOOL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ToolMessage)}");
                tOOL = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.Message(
                discriminator?.Role,
                cHATBOT,
                tOOL
                );

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

            if (value.IsCHATBOT)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CHATBOT, typeInfo);
            }
            else if (value.IsTOOL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TOOL, typeInfo);
            }
        }
    }
}