
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The possible stages of a batch life-cycle.<br/>
    ///  - BATCH_STATUS_UNSPECIFIED: Unspecified status.<br/>
    ///  - BATCH_STATUS_QUEUED: The batch has been queued.<br/>
    ///  - BATCH_STATUS_IN_PROGRESS: The batch is in-progress.<br/>
    ///  - BATCH_STATUS_CANCELING: The batch is being canceled.<br/>
    ///  - BATCH_STATUS_COMPLETED: The batch has been completed.<br/>
    ///  - BATCH_STATUS_FAILED: The batch has failed.<br/>
    ///  - BATCH_STATUS_CANCELED: The batch has been canceled.<br/>
    /// Default Value: BATCH_STATUS_UNSPECIFIED<br/>
    /// Included only in responses
    /// </summary>
    public enum BatchStatus
    {
        /// <summary>
        /// Unspecified status.
        /// </summary>
        Unspecified,
        /// <summary>
        /// The batch has been queued.
        /// </summary>
        Queued,
        /// <summary>
        /// The batch is in-progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The batch is being canceled.
        /// </summary>
        Canceling,
        /// <summary>
        /// The batch has been completed.
        /// </summary>
        Completed,
        /// <summary>
        /// The batch has failed.
        /// </summary>
        Failed,
        /// <summary>
        /// The batch has been canceled.
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Unspecified => "BATCH_STATUS_UNSPECIFIED",
                BatchStatus.Queued => "BATCH_STATUS_QUEUED",
                BatchStatus.InProgress => "BATCH_STATUS_IN_PROGRESS",
                BatchStatus.Canceling => "BATCH_STATUS_CANCELING",
                BatchStatus.Completed => "BATCH_STATUS_COMPLETED",
                BatchStatus.Failed => "BATCH_STATUS_FAILED",
                BatchStatus.Canceled => "BATCH_STATUS_CANCELED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "BATCH_STATUS_UNSPECIFIED" => BatchStatus.Unspecified,
                "BATCH_STATUS_QUEUED" => BatchStatus.Queued,
                "BATCH_STATUS_IN_PROGRESS" => BatchStatus.InProgress,
                "BATCH_STATUS_CANCELING" => BatchStatus.Canceling,
                "BATCH_STATUS_COMPLETED" => BatchStatus.Completed,
                "BATCH_STATUS_FAILED" => BatchStatus.Failed,
                "BATCH_STATUS_CANCELED" => BatchStatus.Canceled,
                _ => null,
            };
        }
    }
}