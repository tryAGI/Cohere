#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class V2EmbedRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.V2EmbedRequest>
    {
        /// <inheritdoc />
        public override global::Cohere.V2EmbedRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.Texts? texts = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Texts), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Texts> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Texts).Name}");
                texts = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.Images? images = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Images), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Images> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Images).Name}");
                images = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.V2EmbedRequest(
                texts,
                images
                );

            if (texts != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Texts), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Texts> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Texts).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (images != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Images), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Images> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Images).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.V2EmbedRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTexts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Texts), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Texts?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Texts).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Texts, typeInfo);
            }
            else if (value.IsImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.Images), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.Images?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.Images).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Images, typeInfo);
            }
        }
    }
}