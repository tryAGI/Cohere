#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ResponseFormatV2>
    {
        /// <inheritdoc />
        public override global::Cohere.ResponseFormatV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.TextResponseFormatV2? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextResponseFormatV2).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.JsonResponseFormatV2? json = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.JsonResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.JsonResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.JsonResponseFormatV2).Name}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.ResponseFormatV2(
                text,
                json
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextResponseFormatV2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (json != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.JsonResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.JsonResponseFormatV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.JsonResponseFormatV2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ResponseFormatV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.TextResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.TextResponseFormatV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.TextResponseFormatV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.JsonResponseFormatV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.JsonResponseFormatV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.JsonResponseFormatV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeInfo);
            }
        }
    }
}