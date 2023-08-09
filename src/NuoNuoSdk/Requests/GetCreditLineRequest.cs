namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas查询/刷新企业授信额度的接口
/// <para>1、操作类型：0-刷新（从税局更新库里授信额度）1-查询（查询库里的授信额度） 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 查询的时候 返回 result中的结构化信息 2、使用时可以先使用 刷新操作，等待一段时间后 使用查询操作 3、频率控制：每个税号下的每个账号 每天最多20次，每30秒最多1次 （仅刷新操作）</para>
/// </summary>
public class GetCreditLineRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.getCreditLine";

    /// <summary>
    /// 分机号
    /// <code> 必填: N </code>
    /// <code> 长度: 5 </code>
    /// <code> 示例: <![CDATA[8888]]> </code>
    /// </summary>
    [JsonPropertyName("extensionNumber")]
    [JsonProperty("extensionNumber")]
    [AllowNull]
    public string ExtensionNumber { get; set; }

    /// <summary>
    /// 诺诺系统中的部门id
    /// <code> 必填: N </code>
    /// <code> 长度: 32 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("deptId")]
    [JsonProperty("deptId")]
    [AllowNull]
    public string DeptId { get; set; }

    /// <summary>
    /// 诺诺系统中的开票员id
    /// <code> 必填: N </code>
    /// <code> 长度: 32 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("clerkId")]
    [JsonProperty("clerkId")]
    [AllowNull]
    public string ClerkId { get; set; }

    /// <summary>
    /// 操作类型：0-刷新（从税局更新库里授信额度） 1-查询（查询库里的授信额度）
    /// <code> 必填: Y </code>
    /// <code> 长度: 1 </code>
    /// <code> 示例: <![CDATA[1]]> </code>
    /// </summary>
    [JsonPropertyName("queryType")]
    [JsonProperty("queryType", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string QueryType { get; set; }
}
