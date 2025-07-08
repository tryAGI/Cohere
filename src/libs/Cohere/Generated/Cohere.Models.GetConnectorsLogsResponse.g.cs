
#nullable enable

namespace Cohere
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectorsLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Cohere.ConnectorLog> ConnectorLogs { get; set; }

        /// <summary>
        /// Total number of connector logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorsLogsResponse" /> class.
        /// </summary>
        /// <param name="connectorLogs"></param>
        /// <param name="total">
        /// Total number of connector logs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectorsLogsResponse(
            global::System.Collections.Generic.IList<global::Cohere.ConnectorLog> connectorLogs,
            double total)
        {
            this.ConnectorLogs = connectorLogs ?? throw new global::System.ArgumentNullException(nameof(connectorLogs));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorsLogsResponse" /> class.
        /// </summary>
        public GetConnectorsLogsResponse()
        {
        }
    }
}