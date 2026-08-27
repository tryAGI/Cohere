#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class ParseBlocksPageVariantTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ParseBlocksPageVariantType>
    {
        /// <inheritdoc />
        public override global::Cohere.ParseBlocksPageVariantType Read(
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
                        return global::Cohere.ParseBlocksPageVariantTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.ParseBlocksPageVariantType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Cohere.ParseBlocksPageVariantType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ParseBlocksPageVariantType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cohere.ParseBlocksPageVariantTypeExtensions.ToValueString(value));
        }
    }
}
