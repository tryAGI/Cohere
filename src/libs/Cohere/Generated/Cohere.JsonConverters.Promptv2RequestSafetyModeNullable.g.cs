#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class Promptv2RequestSafetyModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.Promptv2RequestSafetyMode?>
    {
        /// <inheritdoc />
        public override global::Cohere.Promptv2RequestSafetyMode? Read(
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
                        return global::Cohere.Promptv2RequestSafetyModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.Promptv2RequestSafetyMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.Promptv2RequestSafetyMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.Promptv2RequestSafetyMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Cohere.Promptv2RequestSafetyModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
