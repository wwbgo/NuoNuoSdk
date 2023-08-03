namespace NuoNuoSdk;

/// <summary>
/// 诺诺开放平台SDK
/// </summary>
public partial class NuoNuoSdk : INuoNuoSdk
{
    /// <summary>
    /// nuonuo.OpeMplatform.requestBillingNew(诺税通saas请求开具发票接口)
    /// <para>具备诺税通saas资质的企业用户（集团总公司可拿下面公司的税号来开票，但需要先授权）填写发票销方、购方、明细等信息并发起开票请求。</para>
    /// </summary>
    /// <param name="request"><see cref="RequestBillingRequest"/></param>
    /// <returns><see cref="RequestBillingResponse"/></returns>
    public Task<RequestBillingResponse> RequestBillingAsync(RequestBillingRequest request)
    {
        return ExecuteAsync<RequestBillingRequest, RequestBillingResponse>(request);
    }

    /// <summary>
    /// nuonuo.OpeMplatform.getInvoiceStock(诺税通saas企业发票余量查询接口)
    /// <para>企业发票库存查询接口： 都传入的时候，各参数优先级：分机号>机器编号>分机号+机器编号的联合查询>部门ID</para>
    /// </summary>
    /// <param name="request"><see cref="GetInvoiceStockRequest"/></param>
    /// <returns><see cref="GetInvoiceStockResponse"/></returns>
    public Task<GetInvoiceStockResponse> GetInvoiceStockAsync(GetInvoiceStockRequest request)
    {
        return ExecuteAsync<GetInvoiceStockRequest, GetInvoiceStockResponse>(request);
    }

    /// <summary>
    /// nuonuo.OpeMplatform.deliveryInvoice(诺税通saas发票重新交付接口)
    /// <para>通过该接口重新交付平台开具的发票至消费者短信、邮箱</para>
    /// </summary>
    /// <param name="request"><see cref="DeliveryInvoiceRequest"/></param>
    /// <returns><see cref="DeliveryInvoiceResponse"/></returns>
    public Task<DeliveryInvoiceResponse> DeliveryInvoiceAsync(DeliveryInvoiceRequest request)
    {
        return ExecuteAsync<DeliveryInvoiceRequest, DeliveryInvoiceResponse>(request);
    }

    /// <summary>
    /// nuonuo.OpeMplatform.invoiceCancellation(诺税通saas发票作废接口)
    /// <para>用户作废已开票成功的发票</para>
    /// </summary>
    /// <param name="request"><see cref="InvoiceCancellationRequest"/></param>
    /// <returns><see cref="InvoiceCancellationResponse"/></returns>
    public Task<InvoiceCancellationResponse> InvoiceCancellationAsync(InvoiceCancellationRequest request)
    {
        return ExecuteAsync<InvoiceCancellationRequest, InvoiceCancellationResponse>(request);
    }

    /// <summary>
    /// nuonuo.OpeMplatform.queryInvoiceResult(诺税通saas发票详情查询接口)
    /// <para>调用该接口获取发票开票结果等有关发票信息，部分字段需要配置才返回</para>
    /// </summary>
    /// <param name="request"><see cref="QueryInvoiceResultRequest"/></param>
    /// <returns><see cref="QueryInvoiceResultResponse"/></returns>
    public Task<QueryInvoiceResultResponse> QueryInvoiceResultAsync(QueryInvoiceResultRequest request)
    {
        return ExecuteAsync<QueryInvoiceResultRequest, QueryInvoiceResultResponse>(request);
    }

    /// <summary>
    /// nuonuo.OpeMplatform.reInvoice(诺税通saas开票重试接口)
    /// <para>发票开票失败时，可使用该接口进行重推开票，发票订单号、流水号与原请求一致 1、对于开票成功状态的发票（发票生成、开票完成），调用该接口，提示：发票已生成，无需再重试开票 2、对于开票中状态的发票，调用该接口，提示：开票中（重试中），请耐心等待开票结果</para>
    /// </summary>
    /// <param name="request"><see cref="ReInvoiceRequest"/></param>
    /// <returns><see cref="ReInvoiceResponse"/></returns>
    public Task<ReInvoiceResponse> ReInvoiceAsync(ReInvoiceRequest request)
    {
        return ExecuteAsync<ReInvoiceRequest, ReInvoiceResponse>(request);
    }
}
