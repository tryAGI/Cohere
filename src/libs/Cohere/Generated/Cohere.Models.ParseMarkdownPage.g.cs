
#nullable enable

namespace Cohere
{
    /// <summary>
    /// Markdown output payload for a parsed page.
    /// </summary>
    public sealed partial class ParseMarkdownPage
    {
        /// <summary>
        /// Page content as markdown. Images are embedded as<br/>
        /// `![&lt;description&gt;](&lt;image_id&gt;)`. Tables are inlined as HTML.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Image metadata referenced from `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Cohere.ParseImageBlock>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseMarkdownPage" /> class.
        /// </summary>
        /// <param name="content">
        /// Page content as markdown. Images are embedded as<br/>
        /// `![&lt;description&gt;](&lt;image_id&gt;)`. Tables are inlined as HTML.
        /// </param>
        /// <param name="images">
        /// Image metadata referenced from `content`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseMarkdownPage(
            string content,
            global::System.Collections.Generic.IList<global::Cohere.ParseImageBlock>? images)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseMarkdownPage" /> class.
        /// </summary>
        public ParseMarkdownPage()
        {
        }

    }
}