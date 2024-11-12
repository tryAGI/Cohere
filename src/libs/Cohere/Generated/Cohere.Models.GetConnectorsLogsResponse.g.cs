
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
        /// Total number of connector logs<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double Total { get; set; } = default!;

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
        /// Total number of connector logs<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetConnectorsLogsResponse(
            global::System.Collections.Generic.IList<global::Cohere.ConnectorLog> connectorLogs,
            double total = default!)
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