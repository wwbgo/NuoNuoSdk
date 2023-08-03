namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas发票详情查询接口
/// <para>调用该接口获取发票开票结果等有关发票信息，部分字段需要配置才返回</para>
/// </summary>
public class QueryInvoiceResultResponse : NuoNuoResponse<IList<QueryInvoiceResultResponse.QueryInvoiceResultDto>>
{
    public class QueryInvoiceResultDto
    {
        /// <summary>
        /// 发票请求流水号
        /// <code> 示例: 19010211130401000006 </code>
        /// </summary>
        [JsonPropertyName("serialNo")]
        [JsonProperty("serialNo")]
        [AllowNull]
        public string SerialNo { get; set; }

        /// <summary>
        /// 订单编号
        /// <code> 示例: 1001000011161 </code>
        /// </summary>
        [JsonPropertyName("orderNo")]
        [JsonProperty("orderNo")]
        [AllowNull]
        public string OrderNo { get; set; }

        /// <summary>
        /// 发票状态： 2 :开票完成（ 最终状 态），其他状态分别为: 20:开票中; 21:开票成功签章中;22:开票失败;24: 开票成功签章失败;3:发票已作废 31: 发票作废中 备注：22、24状态时，无需再查询，请确认开票失败原因以及签章失败原因； 注：请以该状态码区分发票状态
        /// <code> 示例: 2 </code>
        /// </summary>
        [JsonPropertyName("status")]
        [JsonProperty("status")]
        [AllowNull]
        public string Status { get; set; }

        /// <summary>
        /// 发票状态描述
        /// <code> 示例: 开票完成（最终状态） </code>
        /// </summary>
        [JsonPropertyName("statusMsg")]
        [JsonProperty("statusMsg")]
        [AllowNull]
        public string StatusMsg { get; set; }

        /// <summary>
        /// 失败原因
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("failCause")]
        [JsonProperty("failCause")]
        [AllowNull]
        public string FailCause { get; set; }

        /// <summary>
        /// 发票pdf地址（若同时返回了ofdUrl与pdfUrl，则pdf文件不能做为原始凭证，请用ofd文件做为原始凭证）
        /// <code> 示例: https://invtest.jss.com.cn/group1/M00/0D/A4/wKjScVwsK6CAFzLgAABsVO-OKaE630.pdf </code>
        /// </summary>
        [JsonPropertyName("pdfUrl")]
        [JsonProperty("pdfUrl")]
        [AllowNull]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 发票图片地址
        /// <code> 示例: nnfpkf.jss.com.cn/ArQ6dFE3-9o5x4B </code>
        /// </summary>
        [JsonPropertyName("pictureUrl")]
        [JsonProperty("pictureUrl")]
        [AllowNull]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 开票时间
        /// <code> 示例: 1546398919000 </code>
        /// </summary>
        [JsonPropertyName("invoiceTime")]
        [JsonProperty("invoiceTime")]
        [AllowNull]
        public long InvoiceTime { get; set; }

        /// <summary>
        /// 发票代码（数电电票时为空，数电纸票时有值）
        /// <code> 示例: 131880930199 </code>
        /// </summary>
        [JsonPropertyName("invoiceCode")]
        [JsonProperty("invoiceCode")]
        [AllowNull]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码（数电电票时返回原来的20位数电票号码，数电纸票时为8位的纸票号码）
        /// <code> 示例: 19902643 </code>
        /// </summary>
        [JsonPropertyName("invoiceNo")]
        [JsonProperty("invoiceNo")]
        [AllowNull]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// allElectronicInvoiceNumber 数电票号码（数电电票、数电纸票时均返回20位数电票号码）
        /// <code> 示例: 22310000000000000001 </code>
        /// </summary>
        [JsonPropertyName("allElectronicInvoiceNumbe")]
        [JsonProperty("allElectronicInvoiceNumbe")]
        [AllowNull]
        public string AllElectronicInvoiceNumbe { get; set; }

        /// <summary>
        /// 不含税金额
        /// <code> 示例: 0.38 </code>
        /// </summary>
        [JsonPropertyName("exTaxAmount")]
        [JsonProperty("exTaxAmount")]
        [AllowNull]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 合计税额
        /// <code> 示例: 0.02 </code>
        /// </summary>
        [JsonPropertyName("taxAmount")]
        [JsonProperty("taxAmount")]
        [AllowNull]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 价税合计
        /// <code> 示例: 0.40 </code>
        /// </summary>
        [JsonPropertyName("orderAmount")]
        [JsonProperty("orderAmount")]
        [AllowNull]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 购方名称（付款方名称）
        /// <code> 示例: 个人2 </code>
        /// </summary>
        [JsonPropertyName("payerName")]
        [JsonProperty("payerName")]
        [AllowNull]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号（付款方税号）
        /// <code> 示例: 110101TRDX8RQU1 </code>
        /// </summary>
        [JsonPropertyName("payerTaxNo")]
        [JsonProperty("payerTaxNo")]
        [AllowNull]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// 购方地址
        /// <code> 示例: 杭州西湖区 </code>
        /// </summary>
        [JsonPropertyName("address")]
        [JsonProperty("address")]
        [AllowNull]
        public string Address { get; set; }

        /// <summary>
        /// 购方电话
        /// <code> 示例: 13000000000 </code>
        /// </summary>
        [JsonPropertyName("telephone")]
        [JsonProperty("telephone")]
        [AllowNull]
        public string Telephone { get; set; }

        /// <summary>
        /// 购方开户行及账号
        /// <code> 示例: 中国工商银行000001 </code>
        /// </summary>
        [JsonPropertyName("bankAccount")]
        [JsonProperty("bankAccount")]
        [AllowNull]
        public string BankAccount { get; set; }

        /// <summary>
        /// 发票种类，包含：增值税电子普通发票、增值税普通发票、专用发票(电子)、增值税专用发票、收购发票(电子)、收购发票(纸质)、增值税普通发票(卷式)、机动车销售统一发票、二手车销售统一发票、电子发票(增值税专用发票)、电子发票(普通发票)、全电纸质发票(增值税专用发票)、全电纸质发票(普通发票)； 备注：电子发票(增值税专用发票)即 数电专票(电子)，电子发票(普通发票)即 数电普票(电子)
        /// <code> 示例: 增值税电子普通发票 </code>
        /// </summary>
        [JsonPropertyName("invoiceKind")]
        [JsonProperty("invoiceKind")]
        [AllowNull]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 校验码（数电票时为空）
        /// <code> 示例: 72969719882523170140 </code>
        /// </summary>
        [JsonPropertyName("checkCode")]
        [JsonProperty("checkCode")]
        [AllowNull]
        public string CheckCode { get; set; }

        /// <summary>
        /// 二维码
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("qrCode")]
        [JsonProperty("qrCode")]
        [AllowNull]
        public string QrCode { get; set; }

        /// <summary>
        /// 税控设备号（机器编码）；数电票时为空
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("machineCode")]
        [JsonProperty("machineCode")]
        [AllowNull]
        public string MachineCode { get; set; }

        /// <summary>
        /// 发票密文（数电票时为空）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("cipherText")]
        [JsonProperty("cipherText")]
        [AllowNull]
        public string CipherText { get; set; }

        /// <summary>
        /// 含底图纸票pdf地址
        /// <code> 示例: http://invtest.nntest.cn/group1/M00/01/8B/wKjScV6-P0aAKKPHAAH965KBApQ812.pdf </code>
        /// </summary>
        [JsonPropertyName("paperPdfUrl")]
        [JsonProperty("paperPdfUrl")]
        [AllowNull]
        public string PaperPdfUrl { get; set; }

        /// <summary>
        /// 发票ofd地址（公共服务平台签章及数电电票时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("ofdUrl")]
        [JsonProperty("ofdUrl")]
        [AllowNull]
        public string OfdUrl { get; set; }

        /// <summary>
        /// 发票xml地址（数电电票且企业配置成支持获取xml时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("xmlUrl")]
        [JsonProperty("xmlUrl")]
        [AllowNull]
        public string XmlUrl { get; set; }

        /// <summary>
        /// 开票员
        /// <code> 示例: 张三 </code>
        /// </summary>
        [JsonPropertyName("clerk")]
        [JsonProperty("clerk")]
        [AllowNull]
        public string Clerk { get; set; }

        /// <summary>
        /// 收款人
        /// <code> 示例: 李四 </code>
        /// </summary>
        [JsonPropertyName("payee")]
        [JsonProperty("payee")]
        [AllowNull]
        public string Payee { get; set; }

        /// <summary>
        /// 复核人
        /// <code> 示例: 王五 </code>
        /// </summary>
        [JsonPropertyName("checker")]
        [JsonProperty("checker")]
        [AllowNull]
        public string Checker { get; set; }

        /// <summary>
        /// 销方银行账号
        /// <code> 示例: 2000098287777 </code>
        /// </summary>
        [JsonPropertyName("salerAccount")]
        [JsonProperty("salerAccount")]
        [AllowNull]
        public string SalerAccount { get; set; }

        /// <summary>
        /// 销方电话
        /// <code> 示例: 0937-9384 </code>
        /// </summary>
        [JsonPropertyName("salerTel")]
        [JsonProperty("salerTel")]
        [AllowNull]
        public string SalerTel { get; set; }

        /// <summary>
        /// 销方地址
        /// <code> 示例: 杭州西湖 </code>
        /// </summary>
        [JsonPropertyName("salerAddress")]
        [JsonProperty("salerAddress")]
        [AllowNull]
        public string SalerAddress { get; set; }

        /// <summary>
        /// 销方税号
        /// <code> 示例: 150301199811285326 </code>
        /// </summary>
        [JsonPropertyName("salerTaxNum")]
        [JsonProperty("salerTaxNum")]
        [AllowNull]
        public string SalerTaxNum { get; set; }

        /// <summary>
        /// 销方名称
        /// <code> 示例: 浙江诺诺网 </code>
        /// </summary>
        [JsonPropertyName("saleName")]
        [JsonProperty("saleName")]
        [AllowNull]
        public string SaleName { get; set; }

        /// <summary>
        /// 备注
        /// <code> 示例: 备注mlk </code>
        /// </summary>
        [JsonPropertyName("remark")]
        [JsonProperty("remark")]
        [AllowNull]
        public string Remark { get; set; }

        /// <summary>
        /// 成品油标志：0非成品油，1成品油
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("productOilFlag")]
        [JsonProperty("productOilFlag")]
        [AllowNull]
        public string ProductOilFlag { get; set; }

        /// <summary>
        /// 图片地址（多个图片以逗号隔开）
        /// <code> 示例: http://invtest.nntest.cn/group1/M00/01/8B/wKjScV6-P0WAHjKkAAC17-oX9RE037.jpg </code>
        /// </summary>
        [JsonPropertyName("imgUrls")]
        [JsonProperty("imgUrls")]
        [AllowNull]
        public string ImgUrls { get; set; }

        /// <summary>
        /// 分机号
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 终端号
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("terminalNumber")]
        [JsonProperty("terminalNumber")]
        [AllowNull]
        public string TerminalNumber { get; set; }

        /// <summary>
        /// 部门门店id（诺诺系统中的id）
        /// <code> 示例: 001 </code>
        /// </summary>
        [JsonPropertyName("deptId")]
        [JsonProperty("deptId")]
        [AllowNull]
        public string DeptId { get; set; }

        /// <summary>
        /// 开票员id（诺诺系统中的id）
        /// <code> 示例: 001 </code>
        /// </summary>
        [JsonPropertyName("clerkId")]
        [JsonProperty("clerkId")]
        [AllowNull]
        public string ClerkId { get; set; }

        /// <summary>
        /// 对应蓝票发票代码，红票时有值（蓝票为数电电票时为空，数电纸票时有值）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("oldInvoiceCode")]
        [JsonProperty("oldInvoiceCode")]
        [AllowNull]
        public string OldInvoiceCode { get; set; }

        /// <summary>
        /// 对应蓝票发票号码，红票时有值（蓝票为数电电票时返回原来的20位数电票号码，数电纸票时为8位的纸票号码）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("oldInvoiceNo")]
        [JsonProperty("oldInvoiceNo")]
        [AllowNull]
        public string OldInvoiceNo { get; set; }

        /// <summary>
        /// 对应蓝票数电票号码，红票时有值（蓝票为数电票（电子+纸质）时 20位）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("oldEleInvoiceNumber")]
        [JsonProperty("oldEleInvoiceNumber")]
        [AllowNull]
        public string OldEleInvoiceNumber { get; set; }

        /// <summary>
        /// 清单标志:0,非清单;1,清单票
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("listFlag")]
        [JsonProperty("listFlag")]
        [AllowNull]
        public string ListFlag { get; set; }

        /// <summary>
        /// 清单项目名称:打印清单时对应发票票面项目名称，注意：税总要求清单项目名称为（详见销货清单）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("listName")]
        [JsonProperty("listName")]
        [AllowNull]
        public string ListName { get; set; }

        /// <summary>
        /// 购方手机(开票成功会短信提醒购方)
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonProperty("phone")]
        [AllowNull]
        public string Phone { get; set; }

        /// <summary>
        /// 购方邮箱推送邮箱(开票成功会邮件提醒购方)
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("notifyEmail")]
        [JsonProperty("notifyEmail")]
        [AllowNull]
        public string NotifyEmail { get; set; }

        /// <summary>
        /// 是否机动车类专票 0-否 1-是
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("vehicleFlag")]
        [JsonProperty("vehicleFlag")]
        [AllowNull]
        public string VehicleFlag { get; set; }

        /// <summary>
        /// 数据创建时间（回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("createTime")]
        [JsonProperty("createTime")]
        [AllowNull]
        public string CreateTime { get; set; }

        /// <summary>
        /// 数据更新时间（回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("updateTime")]
        [JsonProperty("updateTime")]
        [AllowNull]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 发票状态更新时间（回传其他信息时返回；涉及状态：开票中、开票失败、开票成功签章中、开票成功签章失败、开票完成、发票作废中、发票已作废）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("stateUpdateTime")]
        [JsonProperty("stateUpdateTime")]
        [AllowNull]
        public string StateUpdateTime { get; set; }

        /// <summary>
        /// 代开标志 0-非代开 1-代开（回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("proxyInvoiceFlag")]
        [JsonProperty("proxyInvoiceFlag")]
        [AllowNull]
        public string ProxyInvoiceFlag { get; set; }

        /// <summary>
        /// 用于开票的订单的时间（回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceDate")]
        [JsonProperty("invoiceDate")]
        [AllowNull]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 开票类型 1-蓝票 2-红票（回传其他信息时返回）
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("invoiceType")]
        [JsonProperty("invoiceType")]
        [AllowNull]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 冲红原因 1:销货退回;2:开票有误;3:服务中止;4:发生销售折让（红票且票种为p、c、e、f、r（成品油发票除外）且回传其他信息时返回）
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("redReason")]
        [JsonProperty("redReason")]
        [AllowNull]
        public string RedReason { get; set; }

        /// <summary>
        /// 作废时间（已作废状态下的发票，且回传其他信息时返回）
        /// <code> 示例: 1625475746 </code>
        /// </summary>
        [JsonPropertyName("invalidTime")]
        [JsonProperty("invalidTime")]
        [AllowNull]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 作废来源 1-诺诺工作台 2-API接口 3-开票软件 4-验签失败作废 5-其他（已作废状态下的发票，且回传其他信息时返回）
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("invalidSource")]
        [JsonProperty("invalidSource")]
        [AllowNull]
        public string InvalidSource { get; set; }

        /// <summary>
        /// 数电纸票作废原因 1:销货退回;2:开票有误;3:服务中止;4:其他（已作废状态下的发票，且票为数电纸票且回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invalidReason")]
        [JsonProperty("invalidReason")]
        [AllowNull]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 其他作废原因详情（作废原因为4 且回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("specificReason")]
        [JsonProperty("specificReason")]
        [AllowNull]
        public string SpecificReason { get; set; }

        /// <summary>
        /// 发票特定要素：（后续枚举值会有扩展，回传其他信息时返回）0-普通 1-成品油发票 3-建筑服务 4-货物运输服务 6-不动产经营租赁服务 9-旅客运输服务 16-农产品收购 31-建安发票 32-房地产销售发票 33-二手车发票反向开具 34-电子烟 35-矿产品
        /// <code> 示例: 0 </code>
        /// </summary>
        [JsonPropertyName("specificFactor")]
        [JsonProperty("specificFactor")]
        [AllowNull]
        public string SpecificFactor { get; set; }

        /// <summary>
        /// 邮箱交付状态（0-未交付，1-交付成功，2-交付失败，3-交付中，4-不会交付；注：回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("emailNotifyStatus")]
        [JsonProperty("emailNotifyStatus")]
        [AllowNull]
        public string EmailNotifyStatus { get; set; }

        /// <summary>
        /// 手机交付状态（0-未交付，1-交付成功，2-交付失败，3-交付中，4-不会交付；注：回传其他信息时返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("phoneNotifyStatus")]
        [JsonProperty("phoneNotifyStatus")]
        [AllowNull]
        public string PhoneNotifyStatus { get; set; }

        /// <summary>
        /// 购买方经办人姓名（数电票特有字段）
        /// <code> 示例: 张三 </code>
        /// </summary>
        [JsonPropertyName("buyerManagerName")]
        [JsonProperty("buyerManagerName")]
        [AllowNull]
        public string BuyerManagerName { get; set; }

        /// <summary>
        /// 经办人证件类型：101-组织机构代码证, 102-营业执照, 103-税务登记证, 199-其他单位证件, 201-居民身份证, 202-军官证, 203-武警警官证, 204-士兵证, 205-军队离退休干部证, 206-残疾人证, 207-残疾军人证（1-8级）, 208-外国护照, 210-港澳居民来往内地通行证, 212-中华人民共和国往来港澳通行证, 213-台湾居民来往大陆通行证, 214-大陆居民往来台湾通行证, 215-外国人居留证, 216-外交官证 299-其他个人证件(数电票特有)
        /// <code> 示例: 201 </code>
        /// </summary>
        [JsonPropertyName("managerCardType")]
        [JsonProperty("managerCardType")]
        [AllowNull]
        public string ManagerCardType { get; set; }

        /// <summary>
        /// 经办人证件号码（数电票特有字段）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("managerCardNo")]
        [JsonProperty("managerCardNo")]
        [AllowNull]
        public string ManagerCardNo { get; set; }

        /// <summary>
        /// 业务方自定义字段1
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField1")]
        [JsonProperty("bField1")]
        [AllowNull]
        public string BField1 { get; set; }

        /// <summary>
        /// 业务方自定义字段2
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField2")]
        [JsonProperty("bField2")]
        [AllowNull]
        public string BField2 { get; set; }

        /// <summary>
        /// 业务方自定义字段3
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("bField3")]
        [JsonProperty("bField3")]
        [AllowNull]
        public string BField3 { get; set; }

        /// <summary>
        /// 购买方自然人标志：0-否，1-是（数电普票（电子）时才有可能返回，为1时，版式文件上在购方名称最后面会额外显示 （个人） ）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("naturalPersonFlag")]
        [JsonProperty("naturalPersonFlag")]
        [AllowNull]
        public string NaturalPersonFlag { get; set; }

        /// <summary>
        /// 发票明细集合
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceItems")]
        [JsonProperty("invoiceItems")]
        [AllowNull]
        public IList<InvoiceItemsDto> InvoiceItems { get; set; }

        public class InvoiceItemsDto
        {
            /// <summary>
            /// 商品名称(项目名称)
            /// <code> 示例: 门票 </code>
            /// </summary>
            [JsonPropertyName("itemName")]
            [JsonProperty("itemName")]
            [AllowNull]
            public string ItemName { get; set; }

            /// <summary>
            /// 简称
            /// <code> 示例: 旅游服务 </code>
            /// </summary>
            [JsonPropertyName("itemCodeAbb")]
            [JsonProperty("itemCodeAbb")]
            [AllowNull]
            public string ItemCodeAbb { get; set; }

            /// <summary>
            /// 单位
            /// <code> 示例: 张 </code>
            /// </summary>
            [JsonPropertyName("itemUnit")]
            [JsonProperty("itemUnit")]
            [AllowNull]
            public string ItemUnit { get; set; }

            /// <summary>
            /// 单价（isIncludeTax=true，是含税单价；isIncludeTax=false，是不含税单价）
            /// <code> 示例: 0.300000000000000000 </code>
            /// </summary>
            [JsonPropertyName("itemPrice")]
            [JsonProperty("itemPrice")]
            [AllowNull]
            public string ItemPrice { get; set; }

            /// <summary>
            /// 税率，注：纸票清单红票存在为null的情况
            /// <code> 示例: 0.06 </code>
            /// </summary>
            [JsonPropertyName("itemTaxRate")]
            [JsonProperty("itemTaxRate")]
            [AllowNull]
            public string ItemTaxRate { get; set; }

            /// <summary>
            /// 数量
            /// <code> 示例: 2.000000000000000000 </code>
            /// </summary>
            [JsonPropertyName("itemNum")]
            [JsonProperty("itemNum")]
            [AllowNull]
            public string ItemNum { get; set; }

            /// <summary>
            /// 金额（isIncludeTax=true，是含税金额；isIncludeTax=false，是不含税金额）
            /// <code> 示例: 0.60 </code>
            /// </summary>
            [JsonPropertyName("itemAmount")]
            [JsonProperty("itemAmount")]
            [AllowNull]
            public string ItemAmount { get; set; }

            /// <summary>
            /// 税额
            /// <code> 示例: 0.03 </code>
            /// </summary>
            [JsonPropertyName("itemTaxAmount")]
            [JsonProperty("itemTaxAmount")]
            [AllowNull]
            public string ItemTaxAmount { get; set; }

            /// <summary>
            /// 规格型号
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("itemSpec")]
            [JsonProperty("itemSpec")]
            [AllowNull]
            public string ItemSpec { get; set; }

            /// <summary>
            /// 商品编码
            /// <code> 示例: 3070101000000000000 </code>
            /// </summary>
            [JsonPropertyName("itemCode")]
            [JsonProperty("itemCode")]
            [AllowNull]
            public string ItemCode { get; set; }

            /// <summary>
            /// 自行编码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("itemSelfCode")]
            [JsonProperty("itemSelfCode")]
            [AllowNull]
            public string ItemSelfCode { get; set; }

            /// <summary>
            /// 含税标识 true：含税 false：不含税
            /// <code> 示例: true </code>
            /// </summary>
            [JsonPropertyName("isIncludeTax")]
            [JsonProperty("isIncludeTax")]
            [AllowNull]
            public string IsIncludeTax { get; set; }

            /// <summary>
            /// 发票行性质0, 正常行;1,折扣行;2,被扣行
            /// <code> 示例: 2 </code>
            /// </summary>
            [JsonPropertyName("invoiceLineProperty")]
            [JsonProperty("invoiceLineProperty")]
            [AllowNull]
            public string InvoiceLineProperty { get; set; }

            /// <summary>
            /// 零税率标识:空：非零税率，1：免税，2：不征税，3：普通零税率；（数电票时为空）
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("zeroRateFlag")]
            [JsonProperty("zeroRateFlag")]
            [AllowNull]
            public string ZeroRateFlag { get; set; }

            /// <summary>
            /// 优惠政策名称（增值税特殊管理）；数电票时为空
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("favouredPolicyName")]
            [JsonProperty("favouredPolicyName")]
            [AllowNull]
            public string FavouredPolicyName { get; set; }

            /// <summary>
            /// 优惠政策标识:0：不使用;1：使用；（数电票时： 01：简易征收 02：稀土产品 03：免税 04：不征税 05：先征后退 06：100%先征后退 07：50%先征后退 08：按3%简易征收 09：按5%简易征收 10：按5%简易征收减按1.5%计征 11：即征即退30% 12：即征即退50% 13：即征即退70% 14：即征即退100% 15：超税负3%即征即退 16：超税负8%即征即退 17：超税负12%即征即退 18：超税负6%即征即退）
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("favouredPolicyFlag")]
            [JsonProperty("favouredPolicyFlag")]
            [AllowNull]
            public string FavouredPolicyFlag { get; set; }

            /// <summary>
            /// 扣除额，小数点后两位。差额票时有值
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("deduction")]
            [JsonProperty("deduction")]
            [AllowNull]
            public string Deduction { get; set; }

            /// <summary>
            /// 业务方明细自定义字段1
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField1")]
            [JsonProperty("dField1")]
            [AllowNull]
            public string DField1 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段2
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField2")]
            [JsonProperty("dField2")]
            [AllowNull]
            public string DField2 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段3
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField3")]
            [JsonProperty("dField3")]
            [AllowNull]
            public string DField3 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段4
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField4")]
            [JsonProperty("dField4")]
            [AllowNull]
            public string DField4 { get; set; }

            /// <summary>
            /// 业务方明细自定义字段5
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("dField5")]
            [JsonProperty("dField5")]
            [AllowNull]
            public string DField5 { get; set; }
        }
        /// <summary>
        /// 机动车销售统一发票中机动车相关信息（只有机动车销售统一发票才会返回）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("vehicleInfo")]
        [JsonProperty("vehicleInfo")]
        [AllowNull]
        public IList<VehicleInfoDto> VehicleInfo { get; set; }

        public class VehicleInfoDto
        {
            /// <summary>
            /// 机动车类型
            /// <code> 示例: 轿车 </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType")]
            [AllowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 厂牌型号
            /// <code> 示例: 宝马3系 </code>
            /// </summary>
            [JsonPropertyName("brandModel")]
            [JsonProperty("brandModel")]
            [AllowNull]
            public string BrandModel { get; set; }

            /// <summary>
            /// 原产地
            /// <code> 示例: 北京 </code>
            /// </summary>
            [JsonPropertyName("productOrigin")]
            [JsonProperty("productOrigin")]
            [AllowNull]
            public string ProductOrigin { get; set; }

            /// <summary>
            /// 合格证号
            /// <code> 示例: WDL042613263551 </code>
            /// </summary>
            [JsonPropertyName("certificate")]
            [JsonProperty("certificate")]
            [AllowNull]
            public string Certificate { get; set; }

            /// <summary>
            /// 进出口证明书号
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("importCerNum")]
            [JsonProperty("importCerNum")]
            [AllowNull]
            public string ImportCerNum { get; set; }

            /// <summary>
            /// 商检单码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("insOddNum")]
            [JsonProperty("insOddNum")]
            [AllowNull]
            public string InsOddNum { get; set; }

            /// <summary>
            /// 发动机号码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("engineNum")]
            [JsonProperty("engineNum")]
            [AllowNull]
            public string EngineNum { get; set; }

            /// <summary>
            /// 车辆识别号码/机动车号码（车架号）
            /// <code> 示例: LHGK43284342384234 </code>
            /// </summary>
            [JsonPropertyName("vehicleCode")]
            [JsonProperty("vehicleCode")]
            [AllowNull]
            public string VehicleCode { get; set; }

            /// <summary>
            /// 完税证明号码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("intactCerNum")]
            [JsonProperty("intactCerNum")]
            [AllowNull]
            public string IntactCerNum { get; set; }

            /// <summary>
            /// 吨位
            /// <code> 示例: 3 </code>
            /// </summary>
            [JsonPropertyName("tonnage")]
            [JsonProperty("tonnage")]
            [AllowNull]
            public string Tonnage { get; set; }

            /// <summary>
            /// 限乘人数
            /// <code> 示例: 5 </code>
            /// </summary>
            [JsonPropertyName("maxCapacity")]
            [JsonProperty("maxCapacity")]
            [AllowNull]
            public string MaxCapacity { get; set; }

            /// <summary>
            /// 主管税务机关代码
            /// <code> 示例: 13399000 </code>
            /// </summary>
            [JsonPropertyName("taxOfficeCode")]
            [JsonProperty("taxOfficeCode")]
            [AllowNull]
            public string TaxOfficeCode { get; set; }

            /// <summary>
            /// 主管税务机关名称
            /// <code> 示例: 杭州税务 </code>
            /// </summary>
            [JsonPropertyName("taxOfficeName")]
            [JsonProperty("taxOfficeName")]
            [AllowNull]
            public string TaxOfficeName { get; set; }

            /// <summary>
            /// 身份证号码或组织机构代码（2021新版机动车发票时为空）
            /// <code> 示例: 9114010034683511XD </code>
            /// </summary>
            [JsonPropertyName("idNumOrgCode")]
            [JsonProperty("idNumOrgCode")]
            [AllowNull]
            public string IdNumOrgCode { get; set; }

            /// <summary>
            /// 生产厂家
            /// <code> 示例: 华晨宝马汽车生产有限公司 </code>
            /// </summary>
            [JsonPropertyName("manufacturerName")]
            [JsonProperty("manufacturerName")]
            [AllowNull]
            public string ManufacturerName { get; set; }
        }
        /// <summary>
        /// 二手车销售统一发票时才有值返回
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("secondHandCarInfo")]
        [JsonProperty("secondHandCarInfo")]
        [AllowNull]
        public IList<SecondHandCarInfoDto> SecondHandCarInfo { get; set; }

        public class SecondHandCarInfoDto
        {
            /// <summary>
            /// 开票方类型 1：经营单位 2：拍卖单位 3：二手车市场
            /// <code> 示例: 1 </code>
            /// </summary>
            [JsonPropertyName("organizeType")]
            [JsonProperty("organizeType")]
            [AllowNull]
            public string OrganizeType { get; set; }

            /// <summary>
            /// 车辆类型,同明细中商品名称，开具二手车发票时明细有且仅有一行
            /// <code> 示例: 轿车 </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType")]
            [AllowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 厂牌型号
            /// <code> 示例: 宝马3系 </code>
            /// </summary>
            [JsonPropertyName("brandModel")]
            [JsonProperty("brandModel")]
            [AllowNull]
            public string BrandModel { get; set; }

            /// <summary>
            /// 车辆识别号码/车架号
            /// <code> 示例: LHGK43284342384234 </code>
            /// </summary>
            [JsonPropertyName("vehicleCode")]
            [JsonProperty("vehicleCode")]
            [AllowNull]
            public string VehicleCode { get; set; }

            /// <summary>
            /// 完税证明号码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("intactCerNum")]
            [JsonProperty("intactCerNum")]
            [AllowNull]
            public string IntactCerNum { get; set; }

            /// <summary>
            /// 车牌照号
            /// <code> 示例: 浙A12345 </code>
            /// </summary>
            [JsonPropertyName("licenseNumber")]
            [JsonProperty("licenseNumber")]
            [AllowNull]
            public string LicenseNumber { get; set; }

            /// <summary>
            /// 登记证号
            /// <code> 示例: 330022123321 </code>
            /// </summary>
            [JsonPropertyName("registerCertNo")]
            [JsonProperty("registerCertNo")]
            [AllowNull]
            public string RegisterCertNo { get; set; }

            /// <summary>
            /// 转入地车管所名称
            /// <code> 示例: 杭州 </code>
            /// </summary>
            [JsonPropertyName("vehicleManagementName")]
            [JsonProperty("vehicleManagementName")]
            [AllowNull]
            public string VehicleManagementName { get; set; }

            /// <summary>
            /// 卖方单位/个人名称（开票方类型为1、2时，与销方名称一致）
            /// <code> 示例: 张三 </code>
            /// </summary>
            [JsonPropertyName("sellerName")]
            [JsonProperty("sellerName")]
            [AllowNull]
            public string SellerName { get; set; }

            /// <summary>
            /// 卖方单位代码/身份证号码（开票方类型为1、2时，与销方税号一致）
            /// <code> 示例: 330100199001010000 </code>
            /// </summary>
            [JsonPropertyName("sellerTaxnum")]
            [JsonProperty("sellerTaxnum")]
            [AllowNull]
            public string SellerTaxnum { get; set; }

            /// <summary>
            /// 卖方单位/个人地址（开票方类型为1、2时，与销方地址一致）
            /// <code> 示例: 杭州文一路888号 </code>
            /// </summary>
            [JsonPropertyName("sellerAddress")]
            [JsonProperty("sellerAddress")]
            [AllowNull]
            public string SellerAddress { get; set; }

            /// <summary>
            /// 卖方单位/个人电话（开票方类型为1、2时，与销方电话一致）
            /// <code> 示例: 13888888888 </code>
            /// </summary>
            [JsonPropertyName("sellerPhone")]
            [JsonProperty("sellerPhone")]
            [AllowNull]
            public string SellerPhone { get; set; }

            /// <summary>
            /// 附加模版名称（数电票特有字段）
            /// <code> 示例: 测试模版 </code>
            /// </summary>
            [JsonPropertyName("additionalElementName")]
            [JsonProperty("additionalElementName")]
            [AllowNull]
            public string AdditionalElementName { get; set; }
        }
        /// <summary>
        /// 数电建筑服务特定要素类型的发票时才有值返回（specificFactor为3时）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceBuildingInfo")]
        [JsonProperty("invoiceBuildingInfo")]
        [AllowNull]
        public InvoiceBuildingInfoDto InvoiceBuildingInfo { get; set; }

        public class InvoiceBuildingInfoDto
        {
            /// <summary>
            /// 建筑服务发生地
            /// <code> 示例: 浙江省杭州市西湖区 </code>
            /// </summary>
            [JsonPropertyName("buildingAddress")]
            [JsonProperty("buildingAddress")]
            [AllowNull]
            public string BuildingAddress { get; set; }

            /// <summary>
            /// 详细地址
            /// <code> 示例: XXX路一号 </code>
            /// </summary>
            [JsonPropertyName("detailedAddress")]
            [JsonProperty("detailedAddress")]
            [AllowNull]
            public string DetailedAddress { get; set; }

            /// <summary>
            /// 土地增值税项目编号
            /// <code> 示例: WA1231232133 </code>
            /// </summary>
            [JsonPropertyName("landVatItemNo")]
            [JsonProperty("landVatItemNo")]
            [AllowNull]
            public string LandVatItemNo { get; set; }

            /// <summary>
            /// 建筑项目名称
            /// <code> 示例: 宇宙城 </code>
            /// </summary>
            [JsonPropertyName("itemName")]
            [JsonProperty("itemName")]
            [AllowNull]
            public string ItemName { get; set; }

            /// <summary>
            /// 跨地（市）标志（0-否 1-是）
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("crossCityFlag")]
            [JsonProperty("crossCityFlag")]
            [AllowNull]
            public string CrossCityFlag { get; set; }
        }
        /// <summary>
        /// 数电不动产经营租赁服务特定要素类型的发票时才有值返回（specificFactor 为 6时）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("realPropertyRentInfo")]
        [JsonProperty("realPropertyRentInfo")]
        [AllowNull]
        public RealPropertyRentInfoDto RealPropertyRentInfo { get; set; }

        public class RealPropertyRentInfoDto
        {
            /// <summary>
            /// 不动产地址
            /// <code> 示例: 浙江省杭州市西湖区 </code>
            /// </summary>
            [JsonPropertyName("realPropertyAddress")]
            [JsonProperty("realPropertyAddress")]
            [AllowNull]
            public string RealPropertyAddress { get; set; }

            /// <summary>
            /// 详细地址
            /// <code> 示例: XXX路一号 </code>
            /// </summary>
            [JsonPropertyName("detailAddress")]
            [JsonProperty("detailAddress")]
            [AllowNull]
            public string DetailAddress { get; set; }

            /// <summary>
            /// 租赁开始日期
            /// <code> 示例: 2023-01-01 </code>
            /// </summary>
            [JsonPropertyName("rentStartDate")]
            [JsonProperty("rentStartDate")]
            [AllowNull]
            public string RentStartDate { get; set; }

            /// <summary>
            /// 租赁结束日期
            /// <code> 示例: 2023-01-30 </code>
            /// </summary>
            [JsonPropertyName("rentEndDate")]
            [JsonProperty("rentEndDate")]
            [AllowNull]
            public string RentEndDate { get; set; }

            /// <summary>
            /// 跨地（市）标志（0-否 1-是）
            /// <code> 示例: 0 </code>
            /// </summary>
            [JsonPropertyName("crossCityFlag")]
            [JsonProperty("crossCityFlag")]
            [AllowNull]
            public string CrossCityFlag { get; set; }

            /// <summary>
            /// 产权证书/不动产权证号
            /// <code> 示例: 无 </code>
            /// </summary>
            [JsonPropertyName("realPropertyCertificate")]
            [JsonProperty("realPropertyCertificate")]
            [AllowNull]
            public string RealPropertyCertificate { get; set; }

            /// <summary>
            /// 面积单位
            /// <code> 示例: 平方米 </code>
            /// </summary>
            [JsonPropertyName("unit")]
            [JsonProperty("unit")]
            [AllowNull]
            public string Unit { get; set; }
        }
        /// <summary>
        /// 实际变量名：invoiceTravellerTransportInfoList 数电旅客运输服务特定要素类型的发票时才有值返回（specificFactor 为 9时）
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
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("traveller")]
            [JsonProperty("traveller")]
            [AllowNull]
            public string Traveller { get; set; }

            /// <summary>
            /// 出行日期（年-月-日）
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travelDate")]
            [JsonProperty("travelDate")]
            [AllowNull]
            public string TravelDate { get; set; }

            /// <summary>
            /// 出行人证件类型（枚举值同经办人身份证件类型）
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travellerCardType")]
            [JsonProperty("travellerCardType")]
            [AllowNull]
            public string TravellerCardType { get; set; }

            /// <summary>
            /// 出行人证件号码
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travellerCardNo")]
            [JsonProperty("travellerCardNo")]
            [AllowNull]
            public string TravellerCardNo { get; set; }

            /// <summary>
            /// 出行地
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("travelPlace")]
            [JsonProperty("travelPlace")]
            [AllowNull]
            public string TravelPlace { get; set; }

            /// <summary>
            /// 到达地
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("arrivePlace")]
            [JsonProperty("arrivePlace")]
            [AllowNull]
            public string ArrivePlace { get; set; }

            /// <summary>
            /// 交通工具类型（1-飞机 2-火车 3-长途汽车 4-公共交通 5-出租车 6-汽车 7-船舶 9-其他）
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("vehicleType")]
            [JsonProperty("vehicleType")]
            [AllowNull]
            public string VehicleType { get; set; }

            /// <summary>
            /// 交通工具等级
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("vehicleLevel")]
            [JsonProperty("vehicleLevel")]
            [AllowNull]
            public string VehicleLevel { get; set; }
        }
        /// <summary>
        /// 货物运输服务特定要素的数电票时才返回（specificFactor = 4时）最多2000行，至少1行
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
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("transportTool")]
            [JsonProperty("transportTool")]
            [AllowNull]
            public string TransportTool { get; set; }

            /// <summary>
            /// 运输工具牌号
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("transportToolNum")]
            [JsonProperty("transportToolNum")]
            [AllowNull]
            public string TransportToolNum { get; set; }

            /// <summary>
            /// 起运地
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("origin")]
            [JsonProperty("origin")]
            [AllowNull]
            public string Origin { get; set; }

            /// <summary>
            /// 到达地
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("destination")]
            [JsonProperty("destination")]
            [AllowNull]
            public string Destination { get; set; }

            /// <summary>
            /// 货物运输名称
            /// <code> 示例:  </code>
            /// </summary>
            [JsonPropertyName("goodsName")]
            [JsonProperty("goodsName")]
            [AllowNull]
            public string GoodsName { get; set; }
        }
        /// <summary>
        /// 附加要素信息列表（数电票特有字段，附加要素信息可以有多个）
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("additionalElement")]
        [JsonProperty("additionalElement")]
        [AllowNull]
        public IList<AdditionalElementDto> AdditionalElement { get; set; }

        public class AdditionalElementDto
        {
            /// <summary>
            /// 信息名称（数电票特有字段）
            /// <code> 示例: 信息名称 </code>
            /// </summary>
            [JsonPropertyName("elementName")]
            [JsonProperty("elementName")]
            [AllowNull]
            public string ElementName { get; set; }

            /// <summary>
            /// 信息类型（数电票特有字段）
            /// <code> 示例: 信息类型 </code>
            /// </summary>
            [JsonPropertyName("elementType")]
            [JsonProperty("elementType")]
            [AllowNull]
            public string ElementType { get; set; }

            /// <summary>
            /// 信息值（数电票特有字段）
            /// <code> 示例: 信息值 </code>
            /// </summary>
            [JsonPropertyName("elementValue")]
            [JsonProperty("elementValue")]
            [AllowNull]
            public string ElementValue { get; set; }
        }
    }
}
