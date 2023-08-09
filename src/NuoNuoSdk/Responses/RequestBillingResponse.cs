namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas请求开具发票接口
/// <para>具备诺税通saas资质的企业用户（集团总公司可拿下面公司的税号来开票，但需要先授权）填写发票销方、购方、明细等信息并发起开票请求。</para>
/// </summary>
public class RequestBillingResponse : NuoNuoResponse<RequestBillingResponse.RequestBillingDto>
{
    public class RequestBillingDto
    {
        /// <summary>
        /// 发票流水号
        /// <code> 示例: <![CDATA[17102510461601000165]]> </code>
        /// </summary>
        [JsonPropertyName("invoiceSerialNum")]
        [JsonProperty("invoiceSerialNum")]
        [AllowNull]
        public string InvoiceSerialNum { get; set; }
    }
}
