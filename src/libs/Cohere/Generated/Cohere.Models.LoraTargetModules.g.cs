
#nullable enable

namespace Cohere
{
    /// <summary>
    /// The possible combinations of LoRA modules to target.<br/>
    ///  - LORA_TARGET_MODULES_UNSPECIFIED: Unspecified LoRA target modules.<br/>
    ///  - LORA_TARGET_MODULES_QV: LoRA adapts the query and value matrices in transformer attention layers.<br/>
    ///  - LORA_TARGET_MODULES_QKVO: LoRA adapts query, key, value, and output matrices in attention layers.<br/>
    ///  - LORA_TARGET_MODULES_QKVO_FFN: LoRA adapts attention projection matrices and feed-forward networks (FFN).<br/>
    /// Default Value: LORA_TARGET_MODULES_UNSPECIFIED
    /// </summary>
    public enum LoraTargetModules
    {
        /// <summary>
        /// 
        /// </summary>
        LORATARGETMODULESUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        LORATARGETMODULESQV,
        /// <summary>
        /// 
        /// </summary>
        LORATARGETMODULESQKVO,
        /// <summary>
        /// 
        /// </summary>
        LORATARGETMODULESQKVOFFN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoraTargetModulesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoraTargetModules value)
        {
            return value switch
            {
                LoraTargetModules.LORATARGETMODULESUNSPECIFIED => "LORA_TARGET_MODULES_UNSPECIFIED",
                LoraTargetModules.LORATARGETMODULESQV => "LORA_TARGET_MODULES_QV",
                LoraTargetModules.LORATARGETMODULESQKVO => "LORA_TARGET_MODULES_QKVO",
                LoraTargetModules.LORATARGETMODULESQKVOFFN => "LORA_TARGET_MODULES_QKVO_FFN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoraTargetModules? ToEnum(string value)
        {
            return value switch
            {
                "LORA_TARGET_MODULES_UNSPECIFIED" => LoraTargetModules.LORATARGETMODULESUNSPECIFIED,
                "LORA_TARGET_MODULES_QV" => LoraTargetModules.LORATARGETMODULESQV,
                "LORA_TARGET_MODULES_QKVO" => LoraTargetModules.LORATARGETMODULESQKVO,
                "LORA_TARGET_MODULES_QKVO_FFN" => LoraTargetModules.LORATARGETMODULESQKVOFFN,
                _ => null,
            };
        }
    }
}