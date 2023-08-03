namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas企业发票余量查询接口
/// <para>企业发票库存查询接口： 都传入的时候，各参数优先级：分机号>机器编号>分机号+机器编号的联合查询>部门ID</para>
/// </summary>
public class GetInvoiceStockRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.getInvoiceStock";

    /// <summary>
    /// 部门id（不传分机号、机器编号时使用）；部门和分机、机器编号等都不传时，返回税号下全部报税信息
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例:  </code>
    /// </summary>
    [JsonPropertyName("departmentId")]
    [JsonProperty("departmentId")]
    [AllowNull]
    public string DepartmentId { get; set; }

    /// <summary>
    /// 分机号列表（只传分机号时使用）
    /// <code> 必填: N </code>
    /// <code> 长度: 100 </code>
    /// <code> 示例: 1 </code>
    /// </summary>
    [JsonPropertyName("extensionNums")]
    [JsonProperty("extensionNums")]
    [AllowNull]
    public IList<string> ExtensionNums { get; set; }

    /// <summary>
    /// 机器编号单个查询（只传机器编号时使用）
    /// <code> 必填: N </code>
    /// <code> 长度: 12 </code>
    /// <code> 示例: 123456789012 </code>
    /// </summary>
    [JsonPropertyName("machineCode")]
    [JsonProperty("machineCode")]
    [AllowNull]
    public string MachineCode { get; set; }

    /// <summary>
    /// 分机号+机器编号联合查询（只能传入一对分机号和机器编号），精确查询某设备时建议使用此种方式
    /// <code> 必填: N </code>
    /// <code> 长度: 1 </code>
    /// <code> 示例:  </code>
    /// </summary>
    [JsonPropertyName("extMachineCodePairs")]
    [JsonProperty("extMachineCodePairs")]
    [AllowNull]
    public IList<ExtMachineCodePairsDto> ExtMachineCodePairs { get; set; }

    public class ExtMachineCodePairsDto
    {
        /// <summary>
        /// 分机号
        /// <code> 必填: N </code>
        /// <code> 长度: 5 </code>
        /// <code> 示例: 1 </code>
        /// </summary>
        [JsonPropertyName("extensionNum")]
        [JsonProperty("extensionNum")]
        [AllowNull]
        public string ExtensionNum { get; set; }

        /// <summary>
        /// 机器编号
        /// <code> 必填: N </code>
        /// <code> 长度: 12 </code>
        /// <code> 示例: 123456789012 </code>
        /// </summary>
        [JsonPropertyName("machineCode")]
        [JsonProperty("machineCode")]
        [AllowNull]
        public string MachineCode { get; set; }
    }
}
