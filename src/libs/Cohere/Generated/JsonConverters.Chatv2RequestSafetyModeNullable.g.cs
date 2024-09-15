#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class Chatv2RequestSafetyModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Chatv2RequestSafetyMode?>
    {
        /// <inheritdoc />
        public override global::Cohere.Chatv2RequestSafetyMode? Read(
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
                        return global::Cohere.Chatv2RequestSafetyModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.Chatv2RequestSafetyMode)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Chatv2RequestSafetyMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cohere.Chatv2RequestSafetyModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
