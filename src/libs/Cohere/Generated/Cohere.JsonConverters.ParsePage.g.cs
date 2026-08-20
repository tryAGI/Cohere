#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ParsePageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ParsePage>
    {
        /// <inheritdoc />
        public override global::Cohere.ParsePage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParsePageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParsePageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParsePageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ParseBlocksPageVariant? blocks = default;
            if (discriminator?.Type == global::Cohere.ParsePageDiscriminatorType.Blocks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseBlocksPageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseBlocksPageVariant> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseBlocksPageVariant)}");
                blocks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ParseMarkdownPageVariant? markdown = default;
            if (discriminator?.Type == global::Cohere.ParsePageDiscriminatorType.Markdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseMarkdownPageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseMarkdownPageVariant> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseMarkdownPageVariant)}");
                markdown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cohere.ParsePage(
                discriminator?.Type,
                blocks,

                markdown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ParsePage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBlocks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseBlocksPageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseBlocksPageVariant?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ParseBlocksPageVariant).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Blocks!, typeInfo);
            }
            else if (value.IsMarkdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseMarkdownPageVariant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseMarkdownPageVariant?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ParseMarkdownPageVariant).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Markdown!, typeInfo);
            }
        }
    }
}