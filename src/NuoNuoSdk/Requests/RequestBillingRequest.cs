namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas请求开具发票接口
/// <para>具备诺税通saas资质的企业用户（集团总公司可拿下面公司的税号来开票，但需要先授权）填写发票销方、购方、明细等信息并发起开票请求。</para>
/// </summary>
public class RequestBillingRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.requestBillingNew";

    /// <summary>
    /// 请求体
    /// <code> 必填: Y </code>
    /// <code> 长度:  </code>
    /// <code> 示例:  </code>
    /// </summary>
    [JsonPropertyName("order")]
    [JsonProperty("order", Required = Required.Always)]
    [NotNull, DisallowNull]
    public OrderDto Order { get; set; }

    public class OrderDto
    {
        /// <summary>
        /// 购方名称
        /// <code> 必填: Y </code>
        /// <code> 长度: 100 </code>
        /// <code> 示例: 企业名称/个人 </code>
        /// </summary>
        [JsonPropertyName("buyerName")]
        [JsonProperty("buyerName", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方税号（企业要填，个人可为空；数电专票、二手车销售统一发票时必填）
        /// <code> 必填: N </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 339901999999198 </code>
        /// </summary>
        [JsonPropertyName("buyerTaxNum")]
        [JsonProperty("buyerTaxNum")]
        [AllowNull]
        public string BuyerTaxNum { get; set; }

        /// <summary>
        /// 购方电话（购方地址+电话总共不超100字符；二手车销售统一发票时必填）
        /// <code> 必填: N </code>
        /// <code> 长度: 50 </code>
        /// <code> 示例: 0571-88888888 </code>
        /// </summary>
        [JsonPropertyName("buyerTel")]
        [JsonProperty("buyerTel")]
        [AllowNull]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 购方地址（购方地址+电话总共不超100字符；二手车销售统一发票时必填）
        /// <code> 必填: N </code>
        /// <code> 长度: 80 </code>
        /// <code> 示例: 杭州市 </code>
        /// </summary>
        [JsonPropertyName("buyerAddress")]
        [JsonProperty("buyerAddress")]
        [AllowNull]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行开户行及账号
        /// <code> 必填: N </code>
        /// <code> 长度: 100 </code>
        /// <code> 示例: 中国工商银行 111111111111 </code>
        /// </summary>
        [JsonPropertyName("buyerAccount")]
        [JsonProperty("buyerAccount")]
        [AllowNull]
        public string BuyerAccount { get; set; }

        /// <summary>
        /// 销方税号（使用沙箱环境请求时消息体参数salerTaxNum和消息头参数userTax填写339902999999789113）
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 339901999999199 </code>
        /// </summary>
        [JsonPropertyName("salerTaxNum")]
        [JsonProperty("salerTaxNum", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string SalerTaxNum { get; set; }

        /// <summary>
        /// 销方电话（在诺税通saas工作台配置过的可以不传，以传入的为准）
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 0571-77777777 </code>
        /// </summary>
        [JsonPropertyName("salerTel")]
        [JsonProperty("salerTel", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string SalerTel { get; set; }

        /// <summary>
        /// 销方地址（在诺税通saas工作台配置过的可以不传，以传入的为准）
        /// <code> 必填: Y </code>
        /// <code> 长度: 80 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("salerAddress")]
        [JsonProperty("salerAddress", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string SalerAddress { get; set; }

        /// <summary>
        /// 销方银行开户行及账号(二手车销售统一发票时必填)
        /// <code> 必填: N </code>
        /// <code> 长度: 100 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("salerAccount")]
        [JsonProperty("salerAccount")]
        [AllowNull]
        public string SalerAccount { get; set; }

        /// <summary>
        /// 不传默认为0：都不显示；传1：备注仅显示销方开户行及账号；传2：备注仅显示购方开户行及账号；传3：购销方开户行及账号都显示（此字段仅在数电普票和数电专票下生效）
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("showBankAccountType")]
        [JsonProperty("showBankAccountType")]
        [AllowNull]
        public string ShowBankAccountType { get; set; }

        /// <summary>
        /// 订单号（每个企业唯一）
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 201701053332079312313 </code>
        /// </summary>
        [JsonPropertyName("orderNo")]
        [JsonProperty("orderNo", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单时间
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 2022-01-13 12:30:00 </code>
        /// </summary>
        [JsonPropertyName("invoiceDate")]
        [JsonProperty("invoiceDate", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 冲红时填写的对应蓝票发票代码（红票必填 10位或12 位， 11位的时候请左补 0）
        /// <code> 必填: N </code>
        /// <code> 长度: 12 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceCode")]
        [JsonProperty("invoiceCode")]
        [AllowNull]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 冲红时填写的对应蓝票发票号码（红票必填，不满8位请左补0）
        /// <code> 必填: N </code>
        /// <code> 长度: 8 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceNum")]
        [JsonProperty("invoiceNum")]
        [AllowNull]
        public string InvoiceNum { get; set; }

        /// <summary>
        /// 冲红原因：1:销货退回;2:开票有误;3:服务中止;4:发生销售折让(开具红票时且票种为p,c,e,f,r需要传--成品油发票除外；不传时默认为 1)
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("redReason")]
        [JsonProperty("redReason")]
        [AllowNull]
        public string RedReason { get; set; }

        /// <summary>
        /// 红字信息表编号.专票冲红时此项必填，且必须在备注中注明“开具红字增值税专用发票信息表编号ZZZZZZZZZZZZZZZZ”字样，其 中“Z”为开具红字增值税专用发票所需要的长度为16位信息表编号（建议16位，最长可支持24位）。
        /// <code> 必填: N </code>
        /// <code> 长度: 24 </code>
        /// <code> 示例: 1403011904008472 </code>
        /// </summary>
        [JsonPropertyName("billInfoNo")]
        [JsonProperty("billInfoNo")]
        [AllowNull]
        public string BillInfoNo { get; set; }

        /// <summary>
        /// 部门门店id（诺诺系统中的id）
        /// <code> 必填: N </code>
        /// <code> 长度: 32 </code>
        /// <code> 示例: 9F7E9439CA8B4C60A2FFF3EA3290B088 </code>
        /// </summary>
        [JsonPropertyName("departmentId")]
        [JsonProperty("departmentId")]
        [AllowNull]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 开票员id（诺诺系统中的id）
        /// <code> 必填: N </code>
        /// <code> 长度: 32 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("clerkId")]
        [JsonProperty("clerkId")]
        [AllowNull]
        public string ClerkId { get; set; }

        /// <summary>
        /// 冲红时，在备注中注明“对应正数发票代码:XXXXXXXXX号码:YYYYYYYY”文案，其中“X”为发票代码，“Y”为发票号码，可以不填，接口会自动添加该文案；机动车发票蓝票时备注只能为空；数电票时最长为200字符
        /// <code> 必填: N </code>
        /// <code> 长度: 230 </code>
        /// <code> 示例: 备注信息 </code>
        /// </summary>
        [JsonPropertyName("remark")]
        [JsonProperty("remark")]
        [AllowNull]
        public string Remark { get; set; }

        /// <summary>
        /// 复核人（数电电票时若有值，会显示在生成的PDF/OFD备注栏中）
        /// <code> 必填: N </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 王五 </code>
        /// </summary>
        [JsonPropertyName("checker")]
        [JsonProperty("checker")]
        [AllowNull]
        public string Checker { get; set; }

        /// <summary>
        /// 收款人（数电电票时若有值，会显示在生成的PDF/OFD备注栏中）
        /// <code> 必填: N </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 李四 </code>
        /// </summary>
        [JsonPropertyName("payee")]
        [JsonProperty("payee")]
        [AllowNull]
        public string Payee { get; set; }

        /// <summary>
        /// 开票员（数电票时需要传入和开票登录账号对应的开票员姓名）
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 张三 </code>
        /// </summary>
        [JsonPropertyName("clerk")]
        [JsonProperty("clerk", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string Clerk { get; set; }

        /// <summary>
        /// 清单标志：非清单:0；清单:1，默认:0，电票固定为0
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("listFlag")]
        [JsonProperty("listFlag")]
        [AllowNull]
        public string ListFlag { get; set; }

        /// <summary>
        /// 清单项目名称：对应发票票面项目名称（listFlag为1时，必填，默认为“详见销货清单”）
        /// <code> 必填: N </code>
        /// <code> 长度: 92 </code>
        /// <code> 示例: 详见销货清单 </code>
        /// </summary>
        [JsonPropertyName("listName")]
        [JsonProperty("listName")]
        [AllowNull]
        public string ListName { get; set; }

        /// <summary>
        /// 推送方式：-1,不推送;0,邮箱;1,手机（默认）;2,邮箱、手机
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("pushMode")]
        [JsonProperty("pushMode")]
        [AllowNull]
        public string PushMode { get; set; }

        /// <summary>
        /// 购方手机（pushMode为1或2时，此项为必填，同时受企业资质是否必填控制）
        /// <code> 必填: Y </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例: 15858585858 </code>
        /// </summary>
        [JsonPropertyName("buyerPhone")]
        [JsonProperty("buyerPhone", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 推送邮箱（pushMode为0或2时，此项为必填，同时受企业资质是否必填控制）
        /// <code> 必填: Y </code>
        /// <code> 长度: 50 </code>
        /// <code> 示例: test@xx.com </code>
        /// </summary>
        [JsonPropertyName("email")]
        [JsonProperty("email", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string Email { get; set; }

        /// <summary>
        /// 抄送手机，多个时用英文逗号隔开，最多支持5个，必须在phone字段有值时，才支持传入
        /// <code> 必填: N </code>
        /// <code> 长度: 100 </code>
        /// <code> 示例: 18399887766,18399882211 </code>
        /// </summary>
        [JsonPropertyName("ccPhone")]
        [JsonProperty("ccPhone")]
        [AllowNull]
        public string CcPhone { get; set; }

        /// <summary>
        /// 抄送邮箱，多个时用英文逗号隔开，最多支持5个，必须在email字段有值时，才支持传入
        /// <code> 必填: N </code>
        /// <code> 长度: 250 </code>
        /// <code> 示例: nuonuowang@qq.com,hahaha@qq.com </code>
        /// </summary>
        [JsonPropertyName("ccEmail")]
        [JsonProperty("ccEmail")]
        [AllowNull]
        public string CcEmail { get; set; }

        /// <summary>
        /// 开票类型：1:蓝票;2:红票 （数电票冲红请对接数电快捷冲红接口）
        /// <code> 必填: Y </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("invoiceType")]
        [JsonProperty("invoiceType", Required = Required.Always)]
        [NotNull, DisallowNull]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票种类：p,普通发票(电票)(默认);c,普通发票(纸票);s,专用发票;e,收购发票(电票);f,收购发票(纸质);r,普通发票(卷式);b,增值税电子专用发票;j,机动车销售统一发票;u,二手车销售统一发票;bs:电子发票(增值税专用发票)-即数电专票(电子),pc:电子发票(普通发票)-即数电普票(电子),es:数电纸质发票(增值税专用发票)-即数电专票(纸质);ec:数电纸质发票(普通发票)-即数电普票(纸质)
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: p </code>
        /// </summary>
        [JsonPropertyName("invoiceLine")]
        [JsonProperty("invoiceLine")]
        [AllowNull]
        public string InvoiceLine { get; set; }

        /// <summary>
        /// 数电纸票类型(数电纸票时才需要传)：（票种为ec时，默认04；票种为es时，默认为1130）; 04 2016版增值税普通发票（二联折叠票）, 05 2016版增值税普通发票（五联折叠票), 1130 增值税专用发票（中文三联无金额限制版）, 1140 增值税专用发票（中文四联无金额限制版）, 1160 增值税专用发票（中文六联无金额限制版）, 1170 增值税专用发票（中文七联无金额限制版）
        /// <code> 必填: N </code>
        /// <code> 长度: 12 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("paperInvoiceType")]
        [JsonProperty("paperInvoiceType")]
        [AllowNull]
        public string PaperInvoiceType { get; set; }

        /// <summary>
        /// 特定要素：0普通发票（默认）、1 成品油 、2 稀土（仅支持c、s票种且编码必须为稀土产品目录中的商品）、3 建筑服务、4 货物运输服务、5 不动产销售、6 不动产经营租赁服务、9 旅客运输服务、16 农产品收购、31 建安发票 、 32 房地产销售发票、33 二手车发票反向开具、 34 电子烟、 35 矿产品
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("specificFactor")]
        [JsonProperty("specificFactor")]
        [AllowNull]
        public string SpecificFactor { get; set; }

        /// <summary>
        /// 是否强制开具标识：0 否、1 是 （发票种类为u，且特定要素为 33-二手车发票反向开具时才需要填； 默认为 0；若为1时，则不校验卖方自然人身份证号的合规性）
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("forceFlag")]
        [JsonProperty("forceFlag")]
        [AllowNull]
        public string ForceFlag { get; set; }

        /// <summary>
        /// 代开标志：0非代开;1代开。代开蓝票时备注要求填写文案：代开企业税号:***,代开企业名称:***；代开红票时备注要求填写文案：对应正数发票代码:***号码:***代开企业税号:***代开企业名称:***
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("proxyInvoiceFlag")]
        [JsonProperty("proxyInvoiceFlag")]
        [AllowNull]
        public string ProxyInvoiceFlag { get; set; }

        /// <summary>
        /// 代办退税标记：0否（默认），1是；仅代办退税资质企业可传1
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("taxRebateProxy")]
        [JsonProperty("taxRebateProxy")]
        [AllowNull]
        public string TaxRebateProxy { get; set; }

        /// <summary>
        /// 数电发票差额征税开具方式：01 全额开票（暂不支持），02 差额开票；非数电发票开具差额时，不传
        /// <code> 必填: N </code>
        /// <code> 长度: 2 </code>
        /// <code> 示例: 02 </code>
        /// </summary>
        [JsonPropertyName("invoiceDifferenceType")]
        [JsonProperty("invoiceDifferenceType")]
        [AllowNull]
        public string InvoiceDifferenceType { get; set; }

        /// <summary>
        /// 回传发票信息地址（开票完成、开票失败）
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例: http:127.0.0.1/invoice/callback/ </code>
        /// </summary>
        [JsonPropertyName("callBackUrl")]
        [JsonProperty("callBackUrl")]
        [AllowNull]
        public string CallBackUrl { get; set; }

        /// <summary>
        /// 分机号（只能为空或者数字）
        /// <code> 必填: N </code>
        /// <code> 长度: 5 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 终端号（开票终端号，只能 为空或数字）
        /// <code> 必填: N </code>
        /// <code> 长度: 4 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("terminalNumber")]
        [JsonProperty("terminalNumber")]
        [AllowNull]
        public string TerminalNumber { get; set; }

        /// <summary>
        /// 机器编号（12位盘号）
        /// <code> 必填: N </code>
        /// <code> 长度: 12 </code>
        /// <code> 示例: 123456789123 </code>
        /// </summary>
        [JsonPropertyName("machineCode")]
        [JsonProperty("machineCode")]
        [AllowNull]
        public string MachineCode { get; set; }

        /// <summary>
        /// 是否机动车类专票 0-否 1-是
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("vehicleFlag")]
        [JsonProperty("vehicleFlag")]
        [AllowNull]
        public string VehicleFlag { get; set; }

        /// <summary>
        /// 是否隐藏编码表版本号 0-否 1-是（默认0，在企业资质中也配置为是隐藏的时候，并且此字段传1的时候代开发票 税率显示***）
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("hiddenBmbbbh")]
        [JsonProperty("hiddenBmbbbh")]
        [AllowNull]
        public string HiddenBmbbbh { get; set; }

        /// <summary>
        /// 指定发票代码（票种为c普纸、f收购纸票时允许指定卷开具） 非必填
        /// <code> 必填: N </code>
        /// <code> 长度: 12 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("nextInvoiceCode")]
        [JsonProperty("nextInvoiceCode")]
        [AllowNull]
        public string NextInvoiceCode { get; set; }

        /// <summary>
        /// 发票起始号码，当指定代码有值时，发票起始号码必填
        /// <code> 必填: N </code>
        /// <code> 长度: 8 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("nextInvoiceNum")]
        [JsonProperty("nextInvoiceNum")]
        [AllowNull]
        public string NextInvoiceNum { get; set; }

        /// <summary>
        /// 发票终止号码，当指定代码有值时，发票终止号码必填
        /// <code> 必填: N </code>
        /// <code> 长度: 8 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceNumEnd")]
        [JsonProperty("invoiceNumEnd")]
        [AllowNull]
        public string InvoiceNumEnd { get; set; }

        /// <summary>
        /// 3%、1%税率开具理由（企业为小规模/点下户时才需要），对应值：1-开具发票为2022年3月31日前发生纳税义务的业务； 2-前期已开具相应征收率发票，发生销售折让、中止或者退回等情形需要开具红字发票，或者开票有误需要重新开具； 3-因为实际经营业务需要，放弃享受免征增值税政策
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("surveyAnswerType")]
        [JsonProperty("surveyAnswerType")]
        [AllowNull]
        public string SurveyAnswerType { get; set; }

        /// <summary>
        /// 购买方经办人姓名（数电票特有字段）
        /// <code> 必填: N </code>
        /// <code> 长度: 16 </code>
        /// <code> 示例: 张三 </code>
        /// </summary>
        [JsonPropertyName("buyerManagerName")]
        [JsonProperty("buyerManagerName")]
        [AllowNull]
        public string BuyerManagerName { get; set; }

        /// <summary>
        /// 经办人证件类型：101-组织机构代码证, 102-营业执照, 103-税务登记证, 199-其他单位证件, 201-居民身份证, 202-军官证, 203-武警警官证, 204-士兵证, 205-军队离退休干部证, 206-残疾人证, 207-残疾军人证（1-8级）, 208-外国护照, 210-港澳居民来往内地通行证, 212-中华人民共和国往来港澳通行证, 213-台湾居民来往大陆通行证, 214-大陆居民往来台湾通行证, 215-外国人居留证, 216-外交官证 299-其他个人证件(数电发票特有)
        /// <code> 必填: N </code>
        /// <code> 长度: 40 </code>
        /// <code> 示例: 201 </code>
        /// </summary>
        [JsonPropertyName("managerCardType")]
        [JsonProperty("managerCardType")]
        [AllowNull]
        public string ManagerCardType { get; set; }

        /// <summary>
        /// 经办人证件号码（数电票特有字段）
        /// <code> 必填: N </code>
        /// <code> 长度: 20 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("managerCardNo")]
        [JsonProperty("managerCardNo")]
        [AllowNull]
        public string ManagerCardNo { get; set; }

        /// <summary>
        /// 业务方自定义字段1，本应用只作保存
        /// <code> 必填: N </code>
        /// <code> 长度: 255 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField1")]
        [JsonProperty("bField1")]
        [AllowNull]
        public string BField1 { get; set; }

        /// <summary>
        /// 业务方自定义字段2，本应用只作保存
        /// <code> 必填: N </code>
        /// <code> 长度: 255 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField2")]
        [JsonProperty("bField2")]
        [AllowNull]
        public string BField2 { get; set; }

        /// <summary>
        /// 业务方自定义字段3，本应用只作保存
        /// <code> 必填: N </code>
        /// <code> 长度: 255 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField3")]
        [JsonProperty("bField3")]
        [AllowNull]
        public string BField3 { get; set; }

        /// <summary>
        /// 购买方自然人标志：0-否（默认），1-是；仅在开具数电普票(电子)时使用，如受票方（发票抬头）为自然人，并要求能将发票归集在个人票夹中展示，需提供姓名及身份证号（自然人纳税人识别号），此参数传入1；如受票方（发票抬头）为个体工商户，需提供社会统一信用代码或纳税人识别号，此参数传入0
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("naturalPersonFlag")]
        [JsonProperty("naturalPersonFlag")]
        [AllowNull]
        public string NaturalPersonFlag { get; set; }

        /// <summary>
        /// 数电农产品收购发票销售方证件类型，数电农产品收购必传，对应buyerTaxNum字段。103 税务登记证，201 居民身份证，208 外国护照，210 港澳居民来往内地通行证，213 台湾居民来往大陆通行证，215 外国人居留证，219 香港永久性居民身份证，220 台湾身份证，221 澳门特别行政区永久性居民身份证，233 外国人永久居留身份证（外国人永久居留证），299 其他个人证件
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例: 201 </code>
        /// </summary>
        [JsonPropertyName("certificateType")]
        [JsonProperty("certificateType")]
        [AllowNull]
        public string CertificateType { get; set; }

        /// <summary>
        /// 对购方税号校验（ 0-不校验 1-校验，仅对数电票有效，未传时则取企业配置的值；注：若开启校验，当购方税号未能在电子税局中找到时 则会开票失败）
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("taxNumVerifyFlag")]
        [JsonProperty("taxNumVerifyFlag")]
        [AllowNull]
        public string TaxNumVerifyFlag { get; set; }

        /// <summary>
        /// 对购方名称校验（ 0-不校验 1-校验，仅对数电普票（电子）有效，未传时则取企业配置的值；若开启校验，当开具非自然人标记的数电普票（电子）时，将限制对于“购买方名称长度小于等于4位”的发票的开具）
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("naturalPersonVerifyFlag")]
        [JsonProperty("naturalPersonVerifyFlag")]
        [AllowNull]
        public string NaturalPersonVerifyFlag { get; set; }

        /// <summary>
        /// 发票明细，支持填写商品明细最大2000行（包含折扣行、被折扣行）
        /// <code> 必填: Y </code>
        /// <code> 长度: 100 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceDetail")]
        [JsonProperty("invoiceDetail", Required = Required.Always)]
        [NotNull, DisallowNull]
        public IList<InvoiceDetailDto> InvoiceDetail { get; set; }

        public class InvoiceDetailDto
        {
            /// <summary>
            /// 商品名称（如invoiceLineProperty =1，则此商品行为折扣行，折扣行不允许多行折扣，折扣行必须紧邻被折扣行，商品名称必须与被折扣行一致）
            /// <code> 必填: Y </code>
            /// <code> 长度: 90 </code>
            /// <code> 示例: 电脑 </code>
            /// </summary>
            [JsonPropertyName("goodsName")]
            [JsonProperty("goodsName", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品编码（商品税收分类编码开发者自行填写）
            /// <code> 必填: N </code>
            /// <code> 长度: 19 </code>
            /// <code> 示例: 1090511030000000000 </code>
            /// </summary>
            [JsonPropertyName("goodsCode")]
            [JsonProperty("goodsCode")]
            [AllowNull]
            public string GoodsCode { get; set; }

            /// <summary>
            /// 自行编码（可不填）
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例: 130005426000000000 </code>
            /// </summary>
            [JsonPropertyName("selfCode")]
            [JsonProperty("selfCode")]
            [AllowNull]
            public string SelfCode { get; set; }

            /// <summary>
            /// 单价含税标志：0:不含税,1:含税
            /// <code> 必填: Y </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("withTaxFlag")]
            [JsonProperty("withTaxFlag", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string WithTaxFlag { get; set; }

            /// <summary>
            /// 单价（精确到小数点后8位），当单价(price)为空时，数量(num)也必须为空；(price)为空时，含税金额(taxIncludedAmount)、不含税金额(taxExcludedAmount)、税额(tax)都不能为空
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("price")]
            [JsonProperty("price")]
            [AllowNull]
            public string Price { get; set; }

            /// <summary>
            /// 数量（精确到小数点后8位，开具红票时数量为负数）
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("num")]
            [JsonProperty("num")]
            [AllowNull]
            public string Num { get; set; }

            /// <summary>
            /// 单位
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 台 </code>
            /// </summary>
            [JsonPropertyName("unit")]
            [JsonProperty("unit")]
            [AllowNull]
            public string Unit { get; set; }

            /// <summary>
            /// 规格型号
            /// <code> 必填: N </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例: y460 </code>
            /// </summary>
            [JsonPropertyName("specType")]
            [JsonProperty("specType")]
            [AllowNull]
            public string SpecType { get; set; }

            /// <summary>
            /// 税额（精确到小数点后2位），[不含税金额] * [税率] = [税额]；税额允许误差为 0.06。红票为负。不含税金额、税额、含税金额任何一个不传时，会根据传入的单价，数量进行计算，可能和实际数值存在误差，建议都传入
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例: 0.12 </code>
            /// </summary>
            [JsonPropertyName("tax")]
            [JsonProperty("tax")]
            [AllowNull]
            public string Tax { get; set; }

            /// <summary>
            /// 税率，注：1、纸票清单红票存在为null的情况；2、二手车发票税率为null或者0
            /// <code> 必填: Y </code>
            /// <code> 长度: 10 </code>
            /// <code> 示例: 0.13 </code>
            /// </summary>
            [JsonPropertyName("taxRate")]
            [JsonProperty("taxRate", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TaxRate { get; set; }

            /// <summary>
            /// 不含税金额（精确到小数点后2位）。红票为负。不含税金额、税额、含税金额任何一个不传时，会根据传入的单价，数量进行计算，可能和实际数值存在误差，建议都传入
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例: 0.88 </code>
            /// </summary>
            [JsonPropertyName("taxExcludedAmount")]
            [JsonProperty("taxExcludedAmount")]
            [AllowNull]
            public string TaxExcludedAmount { get; set; }

            /// <summary>
            /// 含税金额（精确到小数点后2位），[不含税金额] + [税额] = [含税金额]，红票为负。不含税金额、税额、含税金额任何一个不传时，会根据传入的单价，数量进行计算，可能和实际数值存在误差，建议都传入
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("taxIncludedAmount")]
            [JsonProperty("taxIncludedAmount")]
            [AllowNull]
            public string TaxIncludedAmount { get; set; }

            /// <summary>
            /// 发票行性质：0,正常行;1,折扣行;2,被折扣行，红票只有正常行
            /// <code> 必填: N </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("invoiceLineProperty")]
            [JsonProperty("invoiceLineProperty")]
            [AllowNull]
            public string InvoiceLineProperty { get; set; }

            /// <summary>
            /// 优惠政策标识：0,不使用;1,使用; 数电票时： 01：简易征收 02：稀土产品 03：免税 04：不征税 05：先征后退 06：100%先征后退 07：50%先征后退 08：按3%简易征收 09：按5%简易征收 10：按5%简易征收减按1.5%计征 11：即征即退30% 12：即征即退50% 13：即征即退70% 14：即征即退100% 15：超税负3%即征即退 16：超税负8%即征即退 17：超税负12%即征即退 18：超税负6%即征即退
            /// <code> 必填: N </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("favouredPolicyFlag")]
            [JsonProperty("favouredPolicyFlag")]
            [AllowNull]
            public string FavouredPolicyFlag { get; set; }

            /// <summary>
            /// 增值税特殊管理（优惠政策名称）,当favouredPolicyFlag为1时，此项必填 （数电票时为空）
            /// <code> 必填: N </code>
            /// <code> 长度: 50 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("favouredPolicyName")]
            [JsonProperty("favouredPolicyName")]
            [AllowNull]
            public string FavouredPolicyName { get; set; }

            /// <summary>
            /// 扣除额，差额征收时填写，目前只支持填写一项。 注意：当传0、空或字段不传时，都表示非差额征税；传0.00才表示差额征税：0.00 （数电票暂不支持）
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("deduction")]
            [JsonProperty("deduction")]
            [AllowNull]
            public string Deduction { get; set; }

            /// <summary>
            /// 零税率标识：空,非零税率;1,免税;2,不征税;3,普通零税率；1、当税率为：0%，且增值税特殊管理：为“免税”， 零税率标识：需传“1” 2、当税率为：0%，且增值税特殊管理：为"不征税" 零税率标识：需传“2” 3、当税率为：0%，且增值税特殊管理：为空 零税率标识：需传“3” （数电票时为空）
            /// <code> 必填: N </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("zeroRateFlag")]
            [JsonProperty("zeroRateFlag")]
            [AllowNull]
            public string ZeroRateFlag { get; set; }

            /// <summary>
            /// 业务方明细自定义字段1，本应用只作保存
            /// <code> 必填: Y </code>
            /// <code> 长度: 255 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField1")]
            [JsonProperty("dField1", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DField1 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段2，本应用只作保存
            /// <code> 必填: Y </code>
            /// <code> 长度: 255 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField2")]
            [JsonProperty("dField2", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DField2 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段3，本应用只作保存
            /// <code> 必填: Y </code>
            /// <code> 长度: 255 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField3")]
            [JsonProperty("dField3", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DField3 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段4，本应用只作保存
            /// <code> 必填: Y </code>
            /// <code> 长度: 255 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField4")]
            [JsonProperty("dField4", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DField4 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段5，本应用只作保存
            /// <code> 必填: Y </code>
            /// <code> 长度: 255 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField5")]
            [JsonProperty("dField5", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DField5 { get; set; }
        }
        /// <summary>
        /// 机动车销售统一发票才需要传
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("vehicleInfo")]
        [JsonProperty("vehicleInfo")]
        [AllowNull]
        public VehicleInfoDto VehicleInfo { get; set; }

        public class VehicleInfoDto
        {
            /// <summary>
            /// 车辆类型,同明细中商品名称，开具机动车发票时明细有且仅有一行，商品名称为车辆类型且不能为空
            /// <code> 必填: Y </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例: 轿车 </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 厂牌型号
            /// <code> 必填: Y </code>
            /// <code> 长度: 60 </code>
            /// <code> 示例: 宝马3系 </code>
            /// </summary>
            [JsonPropertyName("brandModel")]
            [JsonProperty("brandModel", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string BrandModel { get; set; }

            /// <summary>
            /// 原产地
            /// <code> 必填: Y </code>
            /// <code> 长度: 32 </code>
            /// <code> 示例: 北京 </code>
            /// </summary>
            [JsonPropertyName("productOrigin")]
            [JsonProperty("productOrigin", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string ProductOrigin { get; set; }

            /// <summary>
            /// 合格证号
            /// <code> 必填: N </code>
            /// <code> 长度: 50 </code>
            /// <code> 示例: WDL042613263551 </code>
            /// </summary>
            [JsonPropertyName("certificate")]
            [JsonProperty("certificate")]
            [AllowNull]
            public string Certificate { get; set; }

            /// <summary>
            /// 进出口证明书号
            /// <code> 必填: N </code>
            /// <code> 长度: 36 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("importCerNum")]
            [JsonProperty("importCerNum")]
            [AllowNull]
            public string ImportCerNum { get; set; }

            /// <summary>
            /// 商检单号
            /// <code> 必填: N </code>
            /// <code> 长度: 32 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("insOddNum")]
            [JsonProperty("insOddNum")]
            [AllowNull]
            public string InsOddNum { get; set; }

            /// <summary>
            /// 发动机号码
            /// <code> 必填: N </code>
            /// <code> 长度: 50 </code>
            /// <code> 示例: 10111011111 </code>
            /// </summary>
            [JsonPropertyName("engineNum")]
            [JsonProperty("engineNum")]
            [AllowNull]
            public string EngineNum { get; set; }

            /// <summary>
            /// 车辆识别号码/车架号
            /// <code> 必填: Y </code>
            /// <code> 长度: 23 </code>
            /// <code> 示例: LHGK43284342384234 </code>
            /// </summary>
            [JsonPropertyName("vehicleCode")]
            [JsonProperty("vehicleCode", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleCode { get; set; }

            /// <summary>
            /// 完税证明号码
            /// <code> 必填: N </code>
            /// <code> 长度: 32 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("intactCerNum")]
            [JsonProperty("intactCerNum")]
            [AllowNull]
            public string IntactCerNum { get; set; }

            /// <summary>
            /// 吨位
            /// <code> 必填: N </code>
            /// <code> 长度: 8 </code>
            /// <code> 示例: 2 </code>
            /// </summary>
            [JsonPropertyName("tonnage")]
            [JsonProperty("tonnage")]
            [AllowNull]
            public string Tonnage { get; set; }

            /// <summary>
            /// 限乘人数
            /// <code> 必填: N </code>
            /// <code> 长度: 12 </code>
            /// <code> 示例: 5 </code>
            /// </summary>
            [JsonPropertyName("maxCapacity")]
            [JsonProperty("maxCapacity")]
            [AllowNull]
            public string MaxCapacity { get; set; }

            /// <summary>
            /// 其他证件号码；该字段为空则为2021新版常规机动车发票，此时购方税号必填（个人在购方税号中填身份证号）；该字段有值，则为2021新版其他证件号码的机动车发票（可以录入汉字、大写字母、数字、全角括号等，此时购方税号需要为空；注：仅用于港澳台、国外等特殊身份/税号开机动车票时使用；国内个人身份证号码开具请勿传入该字段，需要传入到购方税号字段中）
            /// <code> 必填: N </code>
            /// <code> 长度: 30 </code>
            /// <code> 示例: 9114010034683511XD </code>
            /// </summary>
            [JsonPropertyName("idNumOrgCode")]
            [JsonProperty("idNumOrgCode")]
            [AllowNull]
            public string IdNumOrgCode { get; set; }

            /// <summary>
            /// 生产厂家（A9开票服务器类型可支持200）
            /// <code> 必填: N </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 华晨宝马汽车生产有限公司 </code>
            /// </summary>
            [JsonPropertyName("manufacturerName")]
            [JsonProperty("manufacturerName")]
            [AllowNull]
            public string ManufacturerName { get; set; }

            /// <summary>
            /// 主管税务机关名称（A9开票服务器类型必填）
            /// <code> 必填: N </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 杭州税务 </code>
            /// </summary>
            [JsonPropertyName("taxOfficeName")]
            [JsonProperty("taxOfficeName")]
            [AllowNull]
            public string TaxOfficeName { get; set; }

            /// <summary>
            /// 主管税务机关代码（A9开票服务器类型必填）
            /// <code> 必填: N </code>
            /// <code> 长度: 11 </code>
            /// <code> 示例: 13399000 </code>
            /// </summary>
            [JsonPropertyName("taxOfficeCode")]
            [JsonProperty("taxOfficeCode")]
            [AllowNull]
            public string TaxOfficeCode { get; set; }
        }
        /// <summary>
        /// 开具二手车销售统一发票才需要传
        /// <code> 必填: N </code>
        /// <code> 长度: 1 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("secondHandCarInfo")]
        [JsonProperty("secondHandCarInfo")]
        [AllowNull]
        public SecondHandCarInfoDto SecondHandCarInfo { get; set; }

        public class SecondHandCarInfoDto
        {
            /// <summary>
            /// 开票方类型 1：经营单位 2：拍卖单位 3：二手车市场 （只有传1-经营单位时，才支持 特定要素为33的 二手车发票反向开具）
            /// <code> 必填: Y </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("organizeType")]
            [JsonProperty("organizeType", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string OrganizeType { get; set; }

            /// <summary>
            /// 车辆类型,同明细中商品名称，开具机动车发票时明细有且仅有一行，商品名称为车辆类型且不能为空
            /// <code> 必填: Y </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例: 轿车 </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 厂牌型号
            /// <code> 必填: Y </code>
            /// <code> 长度: 60 </code>
            /// <code> 示例: 宝马3系 </code>
            /// </summary>
            [JsonPropertyName("brandModel")]
            [JsonProperty("brandModel", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string BrandModel { get; set; }

            /// <summary>
            /// 车辆识别号码/车架号
            /// <code> 必填: Y </code>
            /// <code> 长度: 23 </code>
            /// <code> 示例: LHGK43284342384234 </code>
            /// </summary>
            [JsonPropertyName("vehicleCode")]
            [JsonProperty("vehicleCode", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleCode { get; set; }

            /// <summary>
            /// 完税证明号码
            /// <code> 必填: N </code>
            /// <code> 长度: 32 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("intactCerNum")]
            [JsonProperty("intactCerNum")]
            [AllowNull]
            public string IntactCerNum { get; set; }

            /// <summary>
            /// 车牌照号
            /// <code> 必填: Y </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 浙A12345 </code>
            /// </summary>
            [JsonPropertyName("licenseNumber")]
            [JsonProperty("licenseNumber", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string LicenseNumber { get; set; }

            /// <summary>
            /// 登记证号
            /// <code> 必填: Y </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 330022123321 </code>
            /// </summary>
            [JsonPropertyName("registerCertNo")]
            [JsonProperty("registerCertNo", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string RegisterCertNo { get; set; }
        }
        /// <summary>
        /// 开具建筑服务特定要素的数电票才需要传（specificFactor 为 3时）；注：数电建筑服务发票 只能有 一条明细 且 规格型号、单位、数量、单价 都不能有值
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceBuildingInfo")]
        [JsonProperty("invoiceBuildingInfo")]
        [AllowNull]
        public InvoiceBuildingInfoDto InvoiceBuildingInfo { get; set; }

        public class InvoiceBuildingInfoDto
        {
            /// <summary>
            /// 建筑服务发生地（传对应省市区中文名称--需与行政区划名称一致）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 浙江省杭州市西湖区 </code>
            /// </summary>
            [JsonPropertyName("buildingAddress")]
            [JsonProperty("buildingAddress", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string BuildingAddress { get; set; }

            /// <summary>
            /// 详细地址（建筑服务发生地+详细地址 总长度最大120字符）
            /// <code> 必填: N </code>
            /// <code> 长度: 120 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("detailedAddress")]
            [JsonProperty("detailedAddress")]
            [AllowNull]
            public string DetailedAddress { get; set; }

            /// <summary>
            /// 土地增值税项目编号
            /// <code> 必填: N </code>
            /// <code> 长度: 16 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("landVatItemNo")]
            [JsonProperty("landVatItemNo")]
            [AllowNull]
            public string LandVatItemNo { get; set; }

            /// <summary>
            /// 建筑项目名称
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 宇宙城 </code>
            /// </summary>
            [JsonPropertyName("itemName")]
            [JsonProperty("itemName", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string ItemName { get; set; }

            /// <summary>
            /// 跨地（市）标志（0-否 1-是）
            /// <code> 必填: Y </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("crossCityFlag")]
            [JsonProperty("crossCityFlag", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string CrossCityFlag { get; set; }
        }
        /// <summary>
        /// 开具货物运输服务特定要素的数电票时才需要填（specificFactor = 4时）最多2000行，至少1行
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceGoodsTransports")]
        [JsonProperty("invoiceGoodsTransports")]
        [AllowNull]
        public IList<InvoiceGoodsTransportsDto> InvoiceGoodsTransports { get; set; }

        public class InvoiceGoodsTransportsDto
        {
            /// <summary>
            /// 运输工具种类：1 铁路运输、2 公路运输、3 水路运输、4 航空运输、5 管道运输
            /// <code> 必填: Y </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("transportTool")]
            [JsonProperty("transportTool", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TransportTool { get; set; }

            /// <summary>
            /// 运输工具牌号
            /// <code> 必填: Y </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例: 浙A12345 </code>
            /// </summary>
            [JsonPropertyName("transportToolNum")]
            [JsonProperty("transportToolNum", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TransportToolNum { get; set; }

            /// <summary>
            /// 起运地
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 上海 </code>
            /// </summary>
            [JsonPropertyName("origin")]
            [JsonProperty("origin", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string Origin { get; set; }

            /// <summary>
            /// 到达地
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 北京 </code>
            /// </summary>
            [JsonPropertyName("destination")]
            [JsonProperty("destination", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string Destination { get; set; }

            /// <summary>
            /// 货物运输名称
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例: 零配件 </code>
            /// </summary>
            [JsonPropertyName("goodsName")]
            [JsonProperty("goodsName", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string GoodsName { get; set; }
        }
        /// <summary>
        /// 实际变量名：invoiceTravellerTransportInfoList 开具旅客运输服务特定要素的数电票时才需要填（specificFactor 为 9时）最多2000行，可以为空
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceTravellerTransport")]
        [JsonProperty("invoiceTravellerTransport")]
        [AllowNull]
        public IList<InvoiceTravellerTransportDto> InvoiceTravellerTransport { get; set; }

        public class InvoiceTravellerTransportDto
        {
            /// <summary>
            /// 出行人
            /// <code> 必填: Y </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 张三 </code>
            /// </summary>
            [JsonPropertyName("traveller")]
            [JsonProperty("traveller", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string Traveller { get; set; }

            /// <summary>
            /// 出行日期（年-月-日）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 2023-01-01 </code>
            /// </summary>
            [JsonPropertyName("travelDate")]
            [JsonProperty("travelDate", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TravelDate { get; set; }

            /// <summary>
            /// 出行人证件类型（枚举值同经办人身份证件类型）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travellerCardType")]
            [JsonProperty("travellerCardType", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TravellerCardType { get; set; }

            /// <summary>
            /// 出行人证件号码
            /// <code> 必填: Y </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travellerCardNo")]
            [JsonProperty("travellerCardNo", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TravellerCardNo { get; set; }

            /// <summary>
            /// 出行地
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travelPlace")]
            [JsonProperty("travelPlace", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string TravelPlace { get; set; }

            /// <summary>
            /// 到达地
            /// <code> 必填: Y </code>
            /// <code> 长度: 80 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("arrivePlace")]
            [JsonProperty("arrivePlace", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string ArrivePlace { get; set; }

            /// <summary>
            /// 交通工具类型（1-飞机 2-火车 3-长途汽车 4-公共交通 5-出租车 6-汽车 7-船舶 9-其他）
            /// <code> 必填: Y </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 交通工具等级（当交通工具类型是火车、飞机、船舶时必填选择，其他交通工具时可选填；当选择火车时必须传"一等座","二等座","软席（软座、软卧）","硬席（硬座、硬卧）" 其中之一；当选择飞机时必须传"公务舱","头等舱","经济舱" 其中之一；当选择船舶时必须选择"一等舱","二等舱","三等舱" 其中之一）
            /// <code> 必填: Y </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 经济舱 </code>
            /// </summary>
            [JsonPropertyName("vehicleLevel")]
            [JsonProperty("vehicleLevel", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string VehicleLevel { get; set; }
        }
        /// <summary>
        /// 开具不动产经营租赁服务特定要素的数电票才需要传（specificFactor 为 6时）；注：此时 商品只能有 一条明细 且 规格型号、单位都不能有值
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("realPropertyRentInfo")]
        [JsonProperty("realPropertyRentInfo")]
        [AllowNull]
        public RealPropertyRentInfoDto RealPropertyRentInfo { get; set; }

        public class RealPropertyRentInfoDto
        {
            /// <summary>
            /// 不动产地址（传对应省市区中文名称--需与行政区划名称一致）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 浙江省杭州市西湖区 </code>
            /// </summary>
            [JsonPropertyName("realPropertyAddress")]
            [JsonProperty("realPropertyAddress", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string RealPropertyAddress { get; set; }

            /// <summary>
            /// 详细地址（不动产地址+详细地址 总长度最大120字符，且必须包含 街、路、村、乡、镇、道 关键词）
            /// <code> 必填: Y </code>
            /// <code> 长度: 120 </code>
            /// <code> 示例: 文一西路XXXX号 </code>
            /// </summary>
            [JsonPropertyName("detailAddress")]
            [JsonProperty("detailAddress", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DetailAddress { get; set; }

            /// <summary>
            /// 租赁开始日期（不能晚于租赁结束日期）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 2023-01-01 </code>
            /// </summary>
            [JsonPropertyName("rentStartDate")]
            [JsonProperty("rentStartDate", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string RentStartDate { get; set; }

            /// <summary>
            /// 租赁结束日期（不能早于租赁开始日期）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 2023-01-30 </code>
            /// </summary>
            [JsonPropertyName("rentEndDate")]
            [JsonProperty("rentEndDate", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string RentEndDate { get; set; }

            /// <summary>
            /// 跨地（市）标志（0-否 1-是）
            /// <code> 必填: Y </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("crossCityFlag")]
            [JsonProperty("crossCityFlag", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string CrossCityFlag { get; set; }

            /// <summary>
            /// 产权证书/不动产权证号
            /// <code> 必填: N </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("realPropertyCertificate")]
            [JsonProperty("realPropertyCertificate")]
            [AllowNull]
            public string RealPropertyCertificate { get; set; }

            /// <summary>
            /// 面积单位（只能选其中一种：1 平方千米、2 平方米、3 公顷、4 亩、5 hm²、6 km²、7 m²）
            /// <code> 必填: Y </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 2 </code>
            /// </summary>
            [JsonPropertyName("unit")]
            [JsonProperty("unit", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string Unit { get; set; }
        }
        /// <summary>
        /// 开具不动产销售特定要素的数电票才需要传（specificFactor 为 5时）；注：此时 商品只能有 一条明细 且 规格型号、单位都不能有值
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("realPropertySellInfo")]
        [JsonProperty("realPropertySellInfo")]
        [AllowNull]
        public RealPropertySellInfoDto RealPropertySellInfo { get; set; }

        public class RealPropertySellInfoDto
        {
            /// <summary>
            /// 实际为：realPropertyContractNumber；不动产单元代码/网签合同备案编号
            /// <code> 必填: N </code>
            /// <code> 长度: 28 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("realPropertyContractNumbe")]
            [JsonProperty("realPropertyContractNumbe")]
            [AllowNull]
            public string RealPropertyContractNumbe { get; set; }

            /// <summary>
            /// 不动产地址（传对应省市区中文名称--需与行政区划名称一致）
            /// <code> 必填: Y </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 浙江省杭州市西湖区 </code>
            /// </summary>
            [JsonPropertyName("realPropertyAddress")]
            [JsonProperty("realPropertyAddress", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string RealPropertyAddress { get; set; }

            /// <summary>
            /// 详细地址（不动产地址+详细地址 总长度最大120字符，且必须包含 街、路、村、乡、镇、道 关键词）
            /// <code> 必填: Y </code>
            /// <code> 长度: 120 </code>
            /// <code> 示例: 文一西路XXXX号 </code>
            /// </summary>
            [JsonPropertyName("detailAddress")]
            [JsonProperty("detailAddress", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string DetailAddress { get; set; }

            /// <summary>
            /// 跨地（市）标志（0-否 1-是）
            /// <code> 必填: Y </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("crossCityFlag")]
            [JsonProperty("crossCityFlag", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string CrossCityFlag { get; set; }

            /// <summary>
            /// 土地增值税项目编号
            /// <code> 必填: N </code>
            /// <code> 长度: 18 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("incrementTaxNumber")]
            [JsonProperty("incrementTaxNumber")]
            [AllowNull]
            public string IncrementTaxNumber { get; set; }

            /// <summary>
            /// 核定计税价格
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("price")]
            [JsonProperty("price")]
            [AllowNull]
            public string Price { get; set; }

            /// <summary>
            /// 实际成交含税金额（当核定计税价格有值时必填）
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("taxAmount")]
            [JsonProperty("taxAmount")]
            [AllowNull]
            public string TaxAmount { get; set; }

            /// <summary>
            /// 产权证书/不动产权证号
            /// <code> 必填: N </code>
            /// <code> 长度: 40 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("realPropertyCertificate")]
            [JsonProperty("realPropertyCertificate")]
            [AllowNull]
            public string RealPropertyCertificate { get; set; }

            /// <summary>
            /// 面积单位（只能选其中一种：1 平方千米、2 平方米、3 公顷、4 亩、5 hm²、6 km²、7 m²）
            /// <code> 必填: Y </code>
            /// <code> 长度: 2 </code>
            /// <code> 示例: 2 </code>
            /// </summary>
            [JsonPropertyName("unit")]
            [JsonProperty("unit", Required = Required.Always)]
            [NotNull, DisallowNull]
            public string Unit { get; set; }
        }
        /// <summary>
        /// 数电发票差额扣除凭证列表，开具数电差额征税-差额开票时，必传
        /// <code> 必填: N </code>
        /// <code> 长度:  </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("differenceVoucherInfo")]
        [JsonProperty("differenceVoucherInfo")]
        [AllowNull]
        public IList<DifferenceVoucherInfoDto> DifferenceVoucherInfo { get; set; }

        public class DifferenceVoucherInfoDto
        {
            /// <summary>
            /// 序号，从1开始依次增加
            /// <code> 必填: N </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("detailIndex")]
            [JsonProperty("detailIndex")]
            [AllowNull]
            public string DetailIndex { get; set; }

            /// <summary>
            /// 凭证类型（01 数电发票、02 增值税专用发票、03 增值税普通发票、04 营业税发票、05 财政票据、06 法院裁决书、07 契税完税凭证、08 其他发票类、09 其他扣除凭证）
            /// <code> 必填: N </code>
            /// <code> 长度:  </code>
            /// <code> 示例: 01 </code>
            /// </summary>
            [JsonPropertyName("voucherType")]
            [JsonProperty("voucherType")]
            [AllowNull]
            public string VoucherType { get; set; }

            /// <summary>
            /// allElectronicInvoiceNumber数电票号码，当voucherType传01时必传
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("allElectronicInvoiceNumbe")]
            [JsonProperty("allElectronicInvoiceNumbe")]
            [AllowNull]
            public string AllElectronicInvoiceNumbe { get; set; }

            /// <summary>
            /// 发票代码，当voucherType传02、03、04时必传
            /// <code> 必填: N </code>
            /// <code> 长度: 12 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("invoiceCode")]
            [JsonProperty("invoiceCode")]
            [AllowNull]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// 发票号码，当voucherType传02、03、04时必传
            /// <code> 必填: N </code>
            /// <code> 长度: 8 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("invoiceNumber")]
            [JsonProperty("invoiceNumber")]
            [AllowNull]
            public string InvoiceNumber { get; set; }

            /// <summary>
            /// 凭证号码
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("voucherNumber")]
            [JsonProperty("voucherNumber")]
            [AllowNull]
            public string VoucherNumber { get; set; }

            /// <summary>
            /// 开具日期，当voucherType传01、02、03、04时必传
            /// <code> 必填: N </code>
            /// <code> 长度: 18 </code>
            /// <code> 示例: 2023-04-13 </code>
            /// </summary>
            [JsonPropertyName("invoiceTime")]
            [JsonProperty("invoiceTime")]
            [AllowNull]
            public string InvoiceTime { get; set; }

            /// <summary>
            /// 凭证金额，必传
            /// <code> 必填: N </code>
            /// <code> 长度: 18 </code>
            /// <code> 示例: 103.14 </code>
            /// </summary>
            [JsonPropertyName("taxtotal")]
            [JsonProperty("taxtotal")]
            [AllowNull]
            public string Taxtotal { get; set; }

            /// <summary>
            /// 本次扣除金额，不能大于凭证金额，必传
            /// <code> 必填: N </code>
            /// <code> 长度: 18 </code>
            /// <code> 示例: 100.14 </code>
            /// </summary>
            [JsonPropertyName("differenceTaxtotal")]
            [JsonProperty("differenceTaxtotal")]
            [AllowNull]
            public string DifferenceTaxtotal { get; set; }

            /// <summary>
            /// 备注，当voucherType传08、09时必传
            /// <code> 必填: N </code>
            /// <code> 长度: 100 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("remark")]
            [JsonProperty("remark")]
            [AllowNull]
            public string Remark { get; set; }

            /// <summary>
            /// 凭证来源，必传，1 手工录入、2 勾选录入、3 模板录入；同一张发票内保持一致
            /// <code> 必填: N </code>
            /// <code> 长度: 1 </code>
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("voucherSource")]
            [JsonProperty("voucherSource")]
            [AllowNull]
            public string VoucherSource { get; set; }
        }
        /// <summary>
        /// 附加模版名称（数电电票特有字段，附加模版有值时需要添加附加要素信息列表对象，需要先在电子税局平台维护好模版）
        /// <code> 必填: N </code>
        /// <code> 长度: 50 </code>
        /// <code> 示例: 测试模版 </code>
        /// </summary>
        [JsonPropertyName("additionalElementName")]
        [JsonProperty("additionalElementName")]
        [AllowNull]
        public string AdditionalElementName { get; set; }

        /// <summary>
        /// 附加要素信息列表（数电电票特有字段，附加要素信息可以有多个，有值时需要附加模版名称也有值）
        /// <code> 必填: N </code>
        /// <code> 长度: 10 </code>
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("additionalElement")]
        [JsonProperty("additionalElement")]
        [AllowNull]
        public IList<AdditionalElementDto> AdditionalElement { get; set; }

        public class AdditionalElementDto
        {
            /// <summary>
            /// 信息名称（数电电票特有字段；需要与电子税局中的模版中的附加要素信息名称一致）
            /// <code> 必填: N </code>
            /// <code> 长度: 200 </code>
            /// <code> 示例: 信息名称 </code>
            /// </summary>
            [JsonPropertyName("elementName")]
            [JsonProperty("elementName")]
            [AllowNull]
            public string ElementName { get; set; }

            /// <summary>
            /// 信息类型（数电电票特有字段）
            /// <code> 必填: N </code>
            /// <code> 长度: 20 </code>
            /// <code> 示例: 信息类型 </code>
            /// </summary>
            [JsonPropertyName("elementType")]
            [JsonProperty("elementType")]
            [AllowNull]
            public string ElementType { get; set; }

            /// <summary>
            /// 信息值（数电电票特有字段）
            /// <code> 必填: N </code>
            /// <code> 长度: 200 </code>
            /// <code> 示例: 信息值 </code>
            /// </summary>
            [JsonPropertyName("elementValue")]
            [JsonProperty("elementValue")]
            [AllowNull]
            public string ElementValue { get; set; }
        }
    }
}
