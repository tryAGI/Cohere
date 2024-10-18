#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ToolContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ToolContent>
    {
        /// <inheritdoc />
        public override global::Cohere.ToolContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ToolContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.TextContent? text = default;
            if (discriminator?.Type == global::Cohere.ToolContentDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.TextContent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.DocumentContent? document = default;
            if (discriminator?.Type == global::Cohere.ToolContentDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.DocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.DocumentContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.DocumentContent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.ToolContent(
                discriminator?.Type,
                text,
                document
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ToolContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.DocumentContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.DocumentContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.DocumentContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
        }
    }
}