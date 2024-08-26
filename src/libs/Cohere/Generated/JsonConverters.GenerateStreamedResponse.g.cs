#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.GenerateStreamedResponse>
    {
        /// <inheritdoc />
        public override global::Cohere.GenerateStreamedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Cohere.GenerateStreamText? streamText = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamText).Name}");
                streamText = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.GenerateStreamEnd? streamEnd = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEnd).Name}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Cohere.GenerateStreamError? streamError = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError).Name}");
                streamError = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Cohere.GenerateStreamedResponse(
                streamText,
                streamEnd,
                streamError
                );

            if (streamText != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamEnd != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEnd).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (streamError != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.GenerateStreamedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamText, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsStreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamError, typeInfo);
            }
        }
    }
}