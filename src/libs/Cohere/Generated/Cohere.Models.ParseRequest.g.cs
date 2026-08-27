
#nullable enable

namespace Cohere
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ParseRequest
    {
        /// <summary>
        /// The name of a compatible Cohere parse model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Document to parse. Currently only `image_url` documents are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.ParseDocument Document { get; set; }

        /// <summary>
        /// Selects the page payload shape in the response. Defaults to `"markdown"`.<br/>
        /// - `"markdown"`: each page includes markdown content. Tables are inlined as<br/>
        ///   HTML, and images are referenced as `![&lt;description&gt;](&lt;image_id&gt;)` with<br/>
        ///   matching entries in `page.markdown.images`.<br/>
        /// - `"blocks"`: each page includes an ordered `blocks` array of text, image,<br/>
        ///   and table content regions, including bounding boxes where available.<br/>
        /// Default Value: markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.ParseOutputFormatJsonConverter))]
        public global::Cohere.ParseOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of a compatible Cohere parse model.
        /// </param>
        /// <param name="document">
        /// Document to parse. Currently only `image_url` documents are supported.
        /// </param>
        /// <param name="outputFormat">
        /// Selects the page payload shape in the response. Defaults to `"markdown"`.<br/>
        /// - `"markdown"`: each page includes markdown content. Tables are inlined as<br/>
        ///   HTML, and images are referenced as `![&lt;description&gt;](&lt;image_id&gt;)` with<br/>
        ///   matching entries in `page.markdown.images`.<br/>
        /// - `"blocks"`: each page includes an ordered `blocks` array of text, image,<br/>
        ///   and table content regions, including bounding boxes where available.<br/>
        /// Default Value: markdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseRequest(
            string model,
            global::Cohere.ParseDocument document,
            global::Cohere.ParseOutputFormat? outputFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequest" /> class.
        /// </summary>
        public ParseRequest()
        {
        }

    }
}