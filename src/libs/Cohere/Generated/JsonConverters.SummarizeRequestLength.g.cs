#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class SummarizeRequestLengthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.SummarizeRequestLength>
    {
        /// <inheritdoc />
        public override global::Cohere.SummarizeRequestLength Read(
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
                        return global::Cohere.SummarizeRequestLengthExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.SummarizeRequestLength)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.SummarizeRequestLength);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.SummarizeRequestLength value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cohere.SummarizeRequestLengthExtensions.ToValueString(value));
        }
    }
}
