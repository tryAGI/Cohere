
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A message from the user.
    /// </summary>
    public sealed partial class UserMessageV2
    {
        /// <summary>
        /// The content of the message. This can be a string or a list of content blocks.<br/>
        /// If a string is provided, it will be treated as a text content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.MessageContent>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.MessageContent>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.UserMessageV2RoleJsonConverter))]
        public global::Cohere.UserMessageV2Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageV2" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message. This can be a string or a list of content blocks.<br/>
        /// If a string is provided, it will be treated as a text content block.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageV2(
            global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.MessageContent>> content,
            global::Cohere.UserMessageV2Role role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageV2" /> class.
        /// </summary>
        public UserMessageV2()
        {
        }
    }
}