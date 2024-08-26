#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
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

            var
            readerCopy = reader;
            global::Cohere.ToolSource? tool = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolSource).Name}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.DocumentSource? document = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.DocumentSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.DocumentSource).Name}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.Source(
                tool,
                document
                );

            if (tool != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolSource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (document != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.DocumentSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.DocumentSource).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.DocumentSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.DocumentSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
        }
    }
}