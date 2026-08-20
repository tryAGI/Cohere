#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ParseBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ParseBlock>
    {
        /// <inheritdoc />
        public override global::Cohere.ParseBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.ParseTextContentBlock? text = default;
            if (discriminator?.Type == global::Cohere.ParseBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseTextContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseTextContentBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseTextContentBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ParseImageContentBlock? image = default;
            if (discriminator?.Type == global::Cohere.ParseBlockDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseImageContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseImageContentBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseImageContentBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ParseTableContentBlock? table = default;
            if (discriminator?.Type == global::Cohere.ParseBlockDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseTableContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseTableContentBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ParseTableContentBlock)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Cohere.ParseBlock(
                discriminator?.Type,
                text,

                image,

                table
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ParseBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseTextContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseTextContentBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ParseTextContentBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseImageContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseImageContentBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ParseImageContentBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsTable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ParseTableContentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ParseTableContentBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ParseTableContentBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table!, typeInfo);
            }
        }
    }
}