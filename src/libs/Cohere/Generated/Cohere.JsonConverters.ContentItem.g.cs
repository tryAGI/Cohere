#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ContentItem>
    {
        /// <inheritdoc />
        public override global::Cohere.ContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessageResponseContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessageResponseContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.AssistantMessageResponseContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ChatTextContent? text = default;
            if (discriminator?.Type == global::Cohere.AssistantMessageResponseContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatTextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatTextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.ContentItem(
                discriminator?.Type,
                text
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatTextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatTextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatTextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}