#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateEmbedJobRequestTruncateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.CreateEmbedJobRequestTruncate>
    {
        /// <inheritdoc />
        public override global::Cohere.CreateEmbedJobRequestTruncate Read(
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
                        return global::Cohere.CreateEmbedJobRequestTruncateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.CreateEmbedJobRequestTruncate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.CreateEmbedJobRequestTruncate);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.CreateEmbedJobRequestTruncate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cohere.CreateEmbedJobRequestTruncateExtensions.ToValueString(value));
        }
    }
}
