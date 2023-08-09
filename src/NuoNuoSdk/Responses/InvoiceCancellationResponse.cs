namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas发票作废接口
/// <para>用户作废已开票成功的发票</para>
/// </summary>
public class InvoiceCancellationResponse : NuoNuoResponse<InvoiceCancellationResponse.InvoiceCancellationDto>
{
    public class InvoiceCancellationDto
    {
        /// <summary>
        /// 发票流水号(提交成功则返回发票请求流水号)
        /// <code> 示例: <![CDATA[11121212121212]]> </code>
        /// </summary>
        [JsonPropertyName("invoiceId")]
        [JsonProperty("invoiceId")]
        [AllowNull]
        public string InvoiceId { get; set; }
    }
}
