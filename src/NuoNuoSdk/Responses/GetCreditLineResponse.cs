namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas查询/刷新企业授信额度的接口
/// <para>1、操作类型：0-刷新（从税局更新库里授信额度）1-查询（查询库里的授信额度） 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 查询的时候 返回 result中的结构化信息 2、使用时可以先使用 刷新操作，等待一段时间后 使用查询操作 3、频率控制：每个税号下的每个账号 每天最多20次，每30秒最多1次 （仅刷新操作）</para>
/// </summary>
public class GetCreditLineResponse : NuoNuoResponse<GetCreditLineResponse.GetCreditLineDto>
{
    public class GetCreditLineDto
    {
        /// <summary>
        /// 0-查询中；1-成功；2-失败
        /// <code> 示例: <![CDATA[1]]> </code>
        /// </summary>
        [JsonPropertyName("requestStatus")]
        [JsonProperty("requestStatus")]
        [AllowNull]
        public string RequestStatus { get; set; }

        /// <summary>
        /// 结果信息（查询操作）
        /// <code> 示例: <![CDATA[OK]]> </code>
        /// </summary>
        [JsonPropertyName("message")]
        [JsonProperty("message")]
        [AllowNull]
        public string Message { get; set; }

        /// <summary>
        /// 税号
        /// <code> 示例: <![CDATA[339901999999199]]> </code>
        /// </summary>
        [JsonPropertyName("taxNum")]
        [JsonProperty("taxNum")]
        [AllowNull]
        public string TaxNum { get; set; }

        /// <summary>
        /// 分机号
        /// <code> 示例: <![CDATA[8888]]> </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 全电账号（脱敏处理）
        /// <code> 示例: <![CDATA[138****8888]]> </code>
        /// </summary>
        [JsonPropertyName("account")]
        [JsonProperty("account")]
        [AllowNull]
        public string Account { get; set; }

        /// <summary>
        /// 剩余可用授信额度（不含税金额，精确到小数点后两位）
        /// <code> 示例: <![CDATA[9000.12]]> </code>
        /// </summary>
        [JsonPropertyName("availableCreditLine")]
        [JsonProperty("availableCreditLine")]
        [AllowNull]
        public string AvailableCreditLine { get; set; }

        /// <summary>
        /// 已使用授信额度（不含税金额，精确到小数点后两位）
        /// <code> 示例: <![CDATA[1000.12]]> </code>
        /// </summary>
        [JsonPropertyName("usedCreditLine")]
        [JsonProperty("usedCreditLine")]
        [AllowNull]
        public string UsedCreditLine { get; set; }

        /// <summary>
        /// 总授信额度（不含税金额，精确到小数点后两位）
        /// <code> 示例: <![CDATA[10000.24]]> </code>
        /// </summary>
        [JsonPropertyName("totalCreditLine")]
        [JsonProperty("totalCreditLine")]
        [AllowNull]
        public string TotalCreditLine { get; set; }

        /// <summary>
        /// 剩余纸质发票张数（全电纸票）
        /// <code> 示例: <![CDATA[10]]> </code>
        /// </summary>
        [JsonPropertyName("availableCount")]
        [JsonProperty("availableCount")]
        [AllowNull]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 已使用发票张数（全电纸票-蓝票）
        /// <code> 示例: <![CDATA[10]]> </code>
        /// </summary>
        [JsonPropertyName("usedCount")]
        [JsonProperty("usedCount")]
        [AllowNull]
        public long UsedCount { get; set; }

        /// <summary>
        /// 已开具蓝票张数（全电纸票+全电电票）
        /// <code> 示例: <![CDATA[10]]> </code>
        /// </summary>
        [JsonPropertyName("invoicedBlueCount")]
        [JsonProperty("invoicedBlueCount")]
        [AllowNull]
        public long InvoicedBlueCount { get; set; }

        /// <summary>
        /// 已开发票合计金额（不含税金额，精确到小数点后两位）
        /// <code> 示例: <![CDATA[1000.12]]> </code>
        /// </summary>
        [JsonPropertyName("invoicedAmount")]
        [JsonProperty("invoicedAmount")]
        [AllowNull]
        public string InvoicedAmount { get; set; }

        /// <summary>
        /// 已开发票累计税额（精确到小数点后两位）
        /// <code> 示例: <![CDATA[100.1]]> </code>
        /// </summary>
        [JsonPropertyName("invoicedTax")]
        [JsonProperty("invoicedTax")]
        [AllowNull]
        public string InvoicedTax { get; set; }

        /// <summary>
        /// 授信额度更新时间
        /// <code> 示例: <![CDATA[2023-03-23 09:12:20]]> </code>
        /// </summary>
        [JsonPropertyName("amountUpdateTime")]
        [JsonProperty("amountUpdateTime")]
        [AllowNull]
        public string AmountUpdateTime { get; set; }
    }
}
