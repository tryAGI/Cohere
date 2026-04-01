#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class ChatToolCallEndEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.ChatToolCallEndEvent>
    {
        /// <inheritdoc />
        public override global::Cohere.ChatToolCallEndEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("index")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Cohere.ChatStreamEventType? value1 = default;
            global::Cohere.ChatToolCallEndEventT6ph9s? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamEventType> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatStreamEventType).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallEndEventT6ph9s), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallEndEventT6ph9s> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallEndEventT6ph9s).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamEventType> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatStreamEventType).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallEndEventT6ph9s), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallEndEventT6ph9s> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallEndEventT6ph9s).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Cohere.ChatToolCallEndEvent(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.ChatToolCallEndEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatStreamEventType), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatStreamEventType?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatStreamEventType).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.ChatToolCallEndEventT6ph9s), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.ChatToolCallEndEventT6ph9s?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.ChatToolCallEndEventT6ph9s).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
        }
    }
}