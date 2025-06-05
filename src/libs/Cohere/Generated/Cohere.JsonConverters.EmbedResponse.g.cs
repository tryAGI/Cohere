#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class EmbedResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.EmbedResponse>
    {
        /// <inheritdoc />
        public override global::Cohere.EmbedResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.EmbedResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.EmbedResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.EmbedResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.EmbedFloatsResponse? embeddingsFloats = default;
            if (discriminator?.ResponseType == global::Cohere.EmbedResponseDiscriminatorResponseType.EmbeddingsFloats)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.EmbedFloatsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.EmbedFloatsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.EmbedFloatsResponse)}");
                embeddingsFloats = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.EmbedByTypeResponse? embeddingsByType = default;
            if (discriminator?.ResponseType == global::Cohere.EmbedResponseDiscriminatorResponseType.EmbeddingsByType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.EmbedByTypeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.EmbedByTypeResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.EmbedByTypeResponse)}");
                embeddingsByType = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.EmbedResponse(
                discriminator?.ResponseType,
                embeddingsFloats,
                embeddingsByType
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.EmbedResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingsFloats)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.EmbedFloatsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.EmbedFloatsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.EmbedFloatsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsFloats, typeInfo);
            }
            else if (value.IsEmbeddingsByType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.EmbedByTypeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.EmbedByTypeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.EmbedByTypeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsByType, typeInfo);
            }
        }
    }
}