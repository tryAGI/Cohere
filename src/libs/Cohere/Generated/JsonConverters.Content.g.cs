#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Content>
    {
        /// <inheritdoc />
        public override global::Cohere.Content Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.TextContent? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextContent).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.Content(
                text
                );

            if (text != null)
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
            global::Cohere.Content value,
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
        }
    }
}