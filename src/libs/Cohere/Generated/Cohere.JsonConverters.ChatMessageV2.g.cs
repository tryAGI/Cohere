#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessageV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ChatMessageV2>
    {
        /// <inheritdoc />
        public override global::Cohere.ChatMessageV2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatMessageV2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatMessageV2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ChatMessageV2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Cohere.UserMessageV2? user = default;
            if (discriminator?.Role == global::Cohere.ChatMessageV2DiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.UserMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.UserMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.UserMessageV2)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.AssistantMessageV2? assistant = default;
            if (discriminator?.Role == global::Cohere.ChatMessageV2DiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.AssistantMessageV2)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.SystemMessageV2? system = default;
            if (discriminator?.Role == global::Cohere.ChatMessageV2DiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SystemMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SystemMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.SystemMessageV2)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Cohere.ToolMessageV2? tool = default;
            if (discriminator?.Role == global::Cohere.ChatMessageV2DiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Cohere.ToolMessageV2)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Cohere.ChatMessageV2(
                discriminator?.Role,
                user,
                assistant,
                system,
                tool
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ChatMessageV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.UserMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.UserMessageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.UserMessageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.AssistantMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.AssistantMessageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.AssistantMessageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.SystemMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.SystemMessageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.SystemMessageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ToolMessageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ToolMessageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ToolMessageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}