
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Cohere
{
    /// <summary>
    /// A message from the system.
    /// </summary>
    public sealed partial class SystemMessageV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Cohere.JsonConverters.SystemMessageV2RoleJsonConverter))]
        public global::Cohere.SystemMessageV2Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessageV2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemMessageV2(
            global::Cohere.OneOf<string, global::System.Collections.Generic.IList<global::Cohere.ContentVariant2Item2>> content,
            global::Cohere.SystemMessageV2Role role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessageV2" /> class.
        /// </summary>
        public SystemMessageV2()
        {
        }
    }
}