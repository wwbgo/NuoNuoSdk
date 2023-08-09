namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas发票重新交付接口
/// <para>通过该接口重新交付平台开具的发票至消费者短信、邮箱</para>
/// </summary>
public class DeliveryInvoiceRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.deliveryInvoice";

    /// <summary>
    /// 销方税号
    /// <code> 必填: Y </code>
    /// <code> 长度: 20 </code>
    /// <code> 示例: <![CDATA[339901999999199]]> </code>
    /// </summary>
    [JsonPropertyName("taxnum")]
    [JsonProperty("taxnum", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string Taxnum { get; set; }

    /// <summary>
    /// 发票代码（全电发票时可为空）
    /// <code> 必填: N </code>
    /// <code> 长度: 12 </code>
    /// <code> 示例: <![CDATA[131880930199]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceCode")]
    [JsonProperty("invoiceCode")]
    [AllowNull]
    public string InvoiceCode { get; set; }

    /// <summary>
    /// 发票号码（全电发票时为20位，其他发票时为8位）
    /// <code> 必填: Y </code>
    /// <code> 长度: 8 </code>
    /// <code> 示例: <![CDATA[19902647]]> </code>
    /// </summary>
    [JsonPropertyName("invoiceNum")]
    [JsonProperty("invoiceNum", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string InvoiceNum { get; set; }

    /// <summary>
    /// 交付手机号，和交付邮箱至少有一个不为空
    /// <code> 必填: N </code>
    /// <code> 长度: 11 </code>
    /// <code> 示例: <![CDATA[133333333333]]> </code>
    /// </summary>
    [JsonPropertyName("phone")]
    [JsonProperty("phone")]
    [AllowNull]
    public string Phone { get; set; }

    /// <summary>
    /// 交付邮箱，和交付手机号至少有一个不为空
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("mail")]
    [JsonProperty("mail")]
    [AllowNull]
    public string Mail { get; set; }
}
