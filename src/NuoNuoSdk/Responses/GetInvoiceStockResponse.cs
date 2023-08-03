namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas企业发票余量查询接口
/// <para>企业发票库存查询接口： 都传入的时候，各参数优先级：分机号>机器编号>分机号+机器编号的联合查询>部门ID</para>
/// </summary>
public class GetInvoiceStockResponse : NuoNuoResponse<IList<GetInvoiceStockResponse.GetInvoiceStockDto>>
{
    public class GetInvoiceStockDto
    {
        /// <summary>
        /// 分机号
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public long ExtensionNumber { get; set; }

        /// <summary>
        /// 机器编号
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("machineCode")]
        [JsonProperty("machineCode")]
        [AllowNull]
        public string MachineCode { get; set; }

        /// <summary>
        /// 终端号
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("terminalNumber")]
        [JsonProperty("terminalNumber")]
        [AllowNull]
        public string TerminalNumber { get; set; }

        /// <summary>
        /// 发票种类：p:电子增值税普通发票；c:增值税普通发票(纸票)；s:增值税专用发票；e:收购发票(电子)；f:收购发票(纸质)；r:增值税普通发票(卷式)；b:增值税电子专用发票；j:机动车销售统一发票；u:二手车销售统一发票
        /// <code> 示例: p </code>
        /// </summary>
        [JsonPropertyName("invoiceLine")]
        [JsonProperty("invoiceLine")]
        [AllowNull]
        public string InvoiceLine { get; set; }

        /// <summary>
        /// 200
        /// <code> 示例: 200 </code>
        /// </summary>
        [JsonPropertyName("remainNum")]
        [JsonProperty("remainNum")]
        [AllowNull]
        public long RemainNum { get; set; }

        /// <summary>
        /// 发票代码
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("typeCode")]
        [JsonProperty("typeCode")]
        [AllowNull]
        public string TypeCode { get; set; }

        /// <summary>
        /// 起始发票号码
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceNumStart")]
        [JsonProperty("invoiceNumStart")]
        [AllowNull]
        public string InvoiceNumStart { get; set; }

        /// <summary>
        /// 终止发票号码
        /// <code> 示例:  </code>
        /// </summary>
        [JsonPropertyName("invoiceNumEnd")]
        [JsonProperty("invoiceNumEnd")]
        [AllowNull]
        public string InvoiceNumEnd { get; set; }

        /// <summary>
        /// 更新时间
        /// <code> 示例: 2019-08-16 15:39:28 </code>
        /// </summary>
        [JsonPropertyName("updateTime")]
        [JsonProperty("updateTime")]
        [AllowNull]
        public string UpdateTime { get; set; }
    }
}
