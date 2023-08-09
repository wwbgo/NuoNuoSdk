namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas发票作废接口
/// <para>用户作废已开票成功的发票</para>
/// </summary>
public class InvoiceCancellationRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.invoiceCancellation";

    /// <summary>
    /// 发票流水号
    /// <code> 必填: Y </code>
    /// <code> 长度: 25 </code>
    /// <code> 示例: <![CDATA[20052622361801000032]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceId")]
    [JsonProperty("invoiceId", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string InvoiceId { get; set; }

    /// <summary>
    /// 发票代码
    /// <code> 必填: Y </code>
    /// <code> 长度: 12 </code>
    /// <code> 示例: <![CDATA[5000201530]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceCode")]
    [JsonProperty("invoiceCode", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string InvoiceCode { get; set; }

    /// <summary>
    /// 发票号码
    /// <code> 必填: Y </code>
    /// <code> 长度: 8 </code>
    /// <code> 示例: <![CDATA[23501899]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceNo")]
    [JsonProperty("invoiceNo", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string InvoiceNo { get; set; }

    /// <summary>
    /// 作废原因（全电纸票时需要传（1:销货退回;2:开票有误;3:服务中止;4:其他），默认 2）
    /// <code> 必填: N </code>
    /// <code> 长度: 1 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("invalidReason")]
    [JsonProperty("invalidReason")]
    [AllowNull]
    public string InvalidReason { get; set; }

    /// <summary>
    /// 其他作废原因详情（全电纸票且作废原因选择4-其他时需要传）
    /// <code> 必填: N </code>
    /// <code> 长度: 255 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("specificReason")]
    [JsonProperty("specificReason")]
    [AllowNull]
    public string SpecificReason { get; set; }
}
