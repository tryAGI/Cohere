#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class SummarizeRequestExtractivenessNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.SummarizeRequestExtractiveness?>
    {
        /// <inheritdoc />
        public override global::Cohere.SummarizeRequestExtractiveness? Read(
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
                        return global::Cohere.SummarizeRequestExtractivenessExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.SummarizeRequestExtractiveness)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.SummarizeRequestExtractiveness?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.SummarizeRequestExtractiveness? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cohere.SummarizeRequestExtractivenessExtensions.ToValueString(value.Value));
            }
        }
    }
}
