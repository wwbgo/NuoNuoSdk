namespace NuoNuoSdk;

/// <summary>
/// 诺诺开放平台SDK
/// </summary>
public partial interface INuoNuoSdk
{
    /// <summary>
    /// nuonuo.OpeMplatform.requestBillingNew(诺税通saas请求开具发票接口)
    /// <para>具备诺税通saas资质的企业用户（集团总公司可拿下面公司的税号来开票，但需要先授权）填写发票销方、购方、明细等信息并发起开票请求。</para>
    /// </summary>
    /// <param name="request"><see cref="RequestBillingRequest"/></param>
    /// <returns><see cref="RequestBillingResponse"/></returns>
    Task<RequestBillingResponse> RequestBillingAsync(RequestBillingRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.getInvoiceStock(诺税通saas企业发票余量查询接口)
    /// <para>企业发票库存查询接口： 都传入的时候，各参数优先级：分机号>机器编号>分机号+机器编号的联合查询>部门ID</para>
    /// </summary>
    /// <param name="request"><see cref="GetInvoiceStockRequest"/></param>
    /// <returns><see cref="GetInvoiceStockResponse"/></returns>
    Task<GetInvoiceStockResponse> GetInvoiceStockAsync(GetInvoiceStockRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.deliveryInvoice(诺税通saas发票重新交付接口)
    /// <para>通过该接口重新交付平台开具的发票至消费者短信、邮箱</para>
    /// </summary>
    /// <param name="request"><see cref="DeliveryInvoiceRequest"/></param>
    /// <returns><see cref="DeliveryInvoiceResponse"/></returns>
    Task<DeliveryInvoiceResponse> DeliveryInvoiceAsync(DeliveryInvoiceRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.invoiceCancellation(诺税通saas发票作废接口)
    /// <para>用户作废已开票成功的发票</para>
    /// </summary>
    /// <param name="request"><see cref="InvoiceCancellationRequest"/></param>
    /// <returns><see cref="InvoiceCancellationResponse"/></returns>
    Task<InvoiceCancellationResponse> InvoiceCancellationAsync(InvoiceCancellationRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.queryInvoiceResult(诺税通saas发票详情查询接口)
    /// <para>调用该接口获取发票开票结果等有关发票信息，部分字段需要配置才返回</para>
    /// </summary>
    /// <param name="request"><see cref="QueryInvoiceResultRequest"/></param>
    /// <returns><see cref="QueryInvoiceResultResponse"/></returns>
    Task<QueryInvoiceResultResponse> QueryInvoiceResultAsync(QueryInvoiceResultRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.reInvoice(诺税通saas开票重试接口)
    /// <para>发票开票失败时，可使用该接口进行重推开票，发票订单号、流水号与原请求一致 1、对于开票成功状态的发票（发票生成、开票完成），调用该接口，提示：发票已生成，无需再重试开票 2、对于开票中状态的发票，调用该接口，提示：开票中（重试中），请耐心等待开票结果</para>
    /// </summary>
    /// <param name="request"><see cref="ReInvoiceRequest"/></param>
    /// <returns><see cref="ReInvoiceResponse"/></returns>
    Task<ReInvoiceResponse> ReInvoiceAsync(ReInvoiceRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.getQrCode(诺税通saas查询/刷新扫码登录及风控后扫码认证的二维码接口)
    /// <para>用于开票时扫码登录 或 需要实名认证的时候，进行查询或刷新扫码登录或开票实人认证的二维码 1、当开票返回错误需要扫码登录时： 1.1、先进行 3-查询获取诺诺已获取登录认证二维码 1.2、若1.1 中没有返回对应二维码字符，则进行2-刷新获取登录认证二维码 操作，再进行 1.1 的操作（二维码有效期为5分钟） 2、当开票返回错误需要开票实人认证时： 2.1、先进行 1-查询获取诺诺已获取的开票实人认证二维码 2.2、若2.1 中没有返回对应二维码字符，则进行 0-刷新获取税局当前开票实人认证二维码 操作，再进行 2.1 的操作（二维码有效期为5分钟） 3、查询的时候 返回 result中的结构化信息 4、频率控制：每个税号下的每个账号 每天最多20次，每60秒最多1次 （刷新获取税局当前开票实人认证二维码/刷新获取登录认证二维码 操作类型 时）</para>
    /// </summary>
    /// <param name="request"><see cref="GetQrCodeRequest"/></param>
    /// <returns><see cref="GetQrCodeResponse"/></returns>
    Task<GetQrCodeResponse> GetQrCodeAsync(GetQrCodeRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.verifyComplete(诺税通saas-全电平台扫码登录确认接口)
    /// <para>使用步骤： 1、先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 获取二维码给用户后 2、用户通过微信/税务app扫码（根据获取的二维码类型），在手机端上完成认证 3、调用该接口执行全电扫码登录的确认动作 4、短信验证码登录时，先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 发送短信验证码，然后通过该接口传入对应的短信验证码 注：用户扫码操作的全电账号 和 执行该登录确认的全电账号（分机号）必须是同一个</para>
    /// </summary>
    /// <param name="request"><see cref="VerifyCompleteRequest"/></param>
    /// <returns><see cref="VerifyCompleteResponse"/></returns>
    Task<VerifyCompleteResponse> VerifyCompleteAsync(VerifyCompleteRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.getCreditLine(诺税通saas查询/刷新企业授信额度的接口)
    /// <para>1、操作类型：0-刷新（从税局更新库里授信额度）1-查询（查询库里的授信额度） 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 查询的时候 返回 result中的结构化信息 2、使用时可以先使用 刷新操作，等待一段时间后 使用查询操作 3、频率控制：每个税号下的每个账号 每天最多20次，每30秒最多1次 （仅刷新操作）</para>
    /// </summary>
    /// <param name="request"><see cref="GetCreditLineRequest"/></param>
    /// <returns><see cref="GetCreditLineResponse"/></returns>
    Task<GetCreditLineResponse> GetCreditLineAsync(GetCreditLineRequest request);

    /// <summary>
    /// nuonuo.OpeMplatform.getCertificationStatus(诺税通saas查询/刷新全电账号登录及开票认证状态的接口)
    /// <para>1、操作类型：0-刷新开票认证状态（刷新认证状态）1-查询开票认证状态（查询库里的认证状态）2-查询全电登录状态（查询库里的全电登录状态） 1.1 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 1.2 查询的时候 返回 result中的结构化信息 2、频率控制：刷新操作 每个税号下的每个账号 每天最多20次，每30秒最多1次</para>
    /// </summary>
    /// <param name="request"><see cref="GetCertificationStatusRequest"/></param>
    /// <returns><see cref="GetCertificationStatusResponse"/></returns>
    Task<GetCertificationStatusResponse> GetCertificationStatusAsync(GetCertificationStatusRequest request);
}
