#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cohere.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Cohere.GenerateStreamError>
    {
        /// <inheritdoc />
        public override global::Cohere.GenerateStreamError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Cohere.GenerateStreamEvent? @event = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEvent).Name}");
                @event = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Cohere.GenerateStreamError49d5xw? error49d5xw = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError49d5xw), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError49d5xw> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError49d5xw).Name}");
                error49d5xw = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Cohere.GenerateStreamError(
                @event,

                error49d5xw
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Cohere.GenerateStreamError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamEvent).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Event!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsError49d5xw)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Cohere.GenerateStreamError49d5xw), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Cohere.GenerateStreamError49d5xw?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Cohere.GenerateStreamError49d5xw).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Error49d5xw!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}