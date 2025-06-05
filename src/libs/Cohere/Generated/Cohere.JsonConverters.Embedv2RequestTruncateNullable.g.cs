#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class Embedv2RequestTruncateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Embedv2RequestTruncate?>
    {
        /// <inheritdoc />
        public override global::Cohere.Embedv2RequestTruncate? Read(
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
                        return global::Cohere.Embedv2RequestTruncateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.Embedv2RequestTruncate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.Embedv2RequestTruncate?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Embedv2RequestTruncate? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cohere.Embedv2RequestTruncateExtensions.ToValueString(value.Value));
            }
        }
    }
}
