#nullable enable

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssistantMessageContentVariant2ItemDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorType Read(
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
                        return global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Cohere.AssistantMessageContentVariant2ItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
