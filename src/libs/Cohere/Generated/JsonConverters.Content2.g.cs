#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class Content2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Content2>
    {
        /// <inheritdoc />
        public override global::Cohere.Content2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.TextContent? textContent = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextContent).Name}");
                textContent = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.Content2(
                textContent
                );

            if (textContent != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextContent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Content2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextContent, typeInfo);
            }
        }
    }
}