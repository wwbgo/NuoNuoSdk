namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas开票重试接口
/// <para>发票开票失败时，可使用该接口进行重推开票，发票订单号、流水号与原请求一致 1、对于开票成功状态的发票（发票生成、开票完成），调用该接口，提示：发票已生成，无需再重试开票 2、对于开票中状态的发票，调用该接口，提示：开票中（重试中），请耐心等待开票结果</para>
/// </summary>
public class ReInvoiceResponse : NuoNuoResponse<string>
{
}
