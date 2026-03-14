
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The type of the dataset
    /// </summary>
    public enum DatasetType
    {
        /// <summary>
        /// 
        /// </summary>
        EmbedInput,
        /// <summary>
        /// 
        /// </summary>
        EmbedResult,
        /// <summary>
        /// 
        /// </summary>
        ClusterResult,
        /// <summary>
        /// 
        /// </summary>
        ClusterOutliers,
        /// <summary>
        /// 
        /// </summary>
        RerankerFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        SingleLabelClassificationFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        ChatFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        MultiLabelClassificationFinetuneInput,
        /// <summary>
        /// 
        /// </summary>
        BatchChatInput,
        /// <summary>
        /// 
        /// </summary>
        BatchOpenaiChatInput,
        /// <summary>
        /// 
        /// </summary>
        BatchEmbedV2Input,
        /// <summary>
        /// 
        /// </summary>
        BatchChatV2Input,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetType value)
        {
            return value switch
            {
                DatasetType.EmbedInput => "embed-input",
                DatasetType.EmbedResult => "embed-result",
                DatasetType.ClusterResult => "cluster-result",
                DatasetType.ClusterOutliers => "cluster-outliers",
                DatasetType.RerankerFinetuneInput => "reranker-finetune-input",
                DatasetType.SingleLabelClassificationFinetuneInput => "single-label-classification-finetune-input",
                DatasetType.ChatFinetuneInput => "chat-finetune-input",
                DatasetType.MultiLabelClassificationFinetuneInput => "multi-label-classification-finetune-input",
                DatasetType.BatchChatInput => "batch-chat-input",
                DatasetType.BatchOpenaiChatInput => "batch-openai-chat-input",
                DatasetType.BatchEmbedV2Input => "batch-embed-v2-input",
                DatasetType.BatchChatV2Input => "batch-chat-v2-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetType? ToEnum(string value)
        {
            return value switch
            {
                "embed-input" => DatasetType.EmbedInput,
                "embed-result" => DatasetType.EmbedResult,
                "cluster-result" => DatasetType.ClusterResult,
                "cluster-outliers" => DatasetType.ClusterOutliers,
                "reranker-finetune-input" => DatasetType.RerankerFinetuneInput,
                "single-label-classification-finetune-input" => DatasetType.SingleLabelClassificationFinetuneInput,
                "chat-finetune-input" => DatasetType.ChatFinetuneInput,
                "multi-label-classification-finetune-input" => DatasetType.MultiLabelClassificationFinetuneInput,
                "batch-chat-input" => DatasetType.BatchChatInput,
                "batch-openai-chat-input" => DatasetType.BatchOpenaiChatInput,
                "batch-embed-v2-input" => DatasetType.BatchEmbedV2Input,
                "batch-chat-v2-input" => DatasetType.BatchChatV2Input,
                _ => null,
            };
        }
    }
}