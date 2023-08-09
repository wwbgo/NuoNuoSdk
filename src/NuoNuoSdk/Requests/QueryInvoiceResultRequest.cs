namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas发票详情查询接口
/// <para>调用该接口获取发票开票结果等有关发票信息，部分字段需要配置才返回</para>
/// </summary>
public class QueryInvoiceResultRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.queryInvoiceResult";

    /// <summary>
    /// 发票流水号，两字段二选一，同时存在以流水号为准（最多查50个订单号）
    /// <code> 必填: N </code>
    /// <code> 长度: 50 </code>
    /// <code> 示例: <![CDATA[22021114442603319271]]> </code>
    /// </summary>
    [JsonPropertyName("serialNos")]
    [JsonProperty("serialNos")]
    [AllowNull]
    public IList<string> SerialNos { get; set; }

    /// <summary>
    /// 订单编号（最多查50个订单号）
    /// <code> 必填: N </code>
    /// <code> 长度: 50 </code>
    /// <code> 示例: <![CDATA[-]]> </code>
    /// </summary>
    [JsonPropertyName("orderNos")]
    [JsonProperty("orderNos")]
    [AllowNull]
    public IList<string> OrderNos { get; set; }

    /// <summary>
    /// 是否需要提供明细 1-是, 0-否(不填默认 0)
    /// <code> 必填: N </code>
    /// <code> 长度: 1 </code>
    /// <code> 示例: <![CDATA[1]]> </code>
    /// </summary>
    [JsonPropertyName("isOfferInvoiceDetail")]
    [JsonProperty("isOfferInvoiceDetail")]
    [AllowNull]
    public string IsOfferInvoiceDetail { get; set; }
}
