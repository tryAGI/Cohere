#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Source>
    {
        /// <inheritdoc />
        public override global::Cohere.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.SourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ChatToolSource? tool = default;
            if (discriminator?.Type == global::Cohere.SourceDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatToolSource)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ChatDocumentSource? document = default;
            if (discriminator?.Type == global::Cohere.SourceDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatDocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatDocumentSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatDocumentSource)}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cohere.Source(
                discriminator?.Type,
                tool,

                document
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatDocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatDocumentSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatDocumentSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document!, typeInfo);
            }
        }
    }
}