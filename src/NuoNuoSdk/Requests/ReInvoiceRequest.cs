namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas开票重试接口
/// <para>发票开票失败时，可使用该接口进行重推开票，发票订单号、流水号与原请求一致 1、对于开票成功状态的发票（发票生成、开票完成），调用该接口，提示：发票已生成，无需再重试开票 2、对于开票中状态的发票，调用该接口，提示：开票中（重试中），请耐心等待开票结果</para>
/// </summary>
public class ReInvoiceRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.reInvoice";

    /// <summary>
    /// 发票流水号，流水号和订单号两字段二选一，同时存在以流水号为准
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[20052515495203513451]]> </code>
    /// </summary>
    [JsonPropertyName("fpqqlsh")]
    [JsonProperty("fpqqlsh")]
    [AllowNull]
    public string Fpqqlsh { get; set; }

    /// <summary>
    /// 订单
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[1231231]]> </code>
    /// </summary>
    [JsonPropertyName("orderno")]
    [JsonProperty("orderno")]
    [AllowNull]
    public string Orderno { get; set; }

    /// <summary>
    /// 指定发票代码（票种为c普纸、f收购纸票时可以指定卷开票） 非必填
    /// <code> 必填: N </code>
    /// <code> 长度: 12 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("nextInvoiceCode")]
    [JsonProperty("nextInvoiceCode")]
    [AllowNull]
    public string NextInvoiceCode { get; set; }

    /// <summary>
    /// 发票起始号码（票种为c普纸、f收购纸票） 当指定代码有值时，发票起始号码必填
    /// <code> 必填: N </code>
    /// <code> 长度: 8 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceNumStart")]
    [JsonProperty("invoiceNumStart")]
    [AllowNull]
    public string InvoiceNumStart { get; set; }

    /// <summary>
    /// 发票终止号码（票种为c普纸、f收购纸票） 当指定代码有值时，发票终止号码必填
    /// <code> 必填: N </code>
    /// <code> 长度: 8 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceNumEnd")]
    [JsonProperty("invoiceNumEnd")]
    [AllowNull]
    public string InvoiceNumEnd { get; set; }
}
