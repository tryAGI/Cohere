#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.GenerateStreamedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.GenerateStreamText? textGeneration = default;
            if (discriminator?.EventType == global::Cohere.GenerateStreamedResponseDiscriminatorEventType.TextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.GenerateStreamText)}");
                textGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.GenerateStreamEnd? streamEnd = default;
            if (discriminator?.EventType == global::Cohere.GenerateStreamedResponseDiscriminatorEventType.StreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.GenerateStreamEnd)}");
                streamEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.GenerateStreamError? streamError = default;
            if (discriminator?.EventType == global::Cohere.GenerateStreamedResponseDiscriminatorEventType.StreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.GenerateStreamError)}");
                streamError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.GenerateStreamedResponse(
                discriminator?.EventType,
                textGeneration,
                streamEnd,
                streamError
                );

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

            if (value.IsTextGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGeneration, typeInfo);
            }
            else if (value.IsStreamEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamEnd, typeInfo);
            }
            else if (value.IsStreamError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamError, typeInfo);
            }
        }
    }
}