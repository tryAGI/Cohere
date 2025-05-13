#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbedRequestTruncateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.EmbedRequestTruncate>
    {
        /// <inheritdoc />
        public override global::Cohere.EmbedRequestTruncate Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Cohere.EmbedRequestTruncateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.EmbedRequestTruncate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.EmbedRequestTruncate);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.EmbedRequestTruncate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cohere.EmbedRequestTruncateExtensions.ToValueString(value));
        }
    }
}
