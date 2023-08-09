namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas查询/刷新全电账号登录及开票认证状态的接口
/// <para>1、操作类型：0-刷新开票认证状态（刷新认证状态）1-查询开票认证状态（查询库里的认证状态）2-查询全电登录状态（查询库里的全电登录状态） 1.1 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 1.2 查询的时候 返回 result中的结构化信息 2、频率控制：刷新操作 每个税号下的每个账号 每天最多20次，每30秒最多1次</para>
/// </summary>
public class GetCertificationStatusRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.getCertificationStatus";

    /// <summary>
    /// 分机号
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("extensionNumber")]
    [JsonProperty("extensionNumber")]
    [AllowNull]
    public string ExtensionNumber { get; set; }

    /// <summary>
    /// 部门id
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("deptId")]
    [JsonProperty("deptId")]
    [AllowNull]
    public string DeptId { get; set; }

    /// <summary>
    /// 开票员id
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("clerkId")]
    [JsonProperty("clerkId")]
    [AllowNull]
    public string ClerkId { get; set; }

    /// <summary>
    /// 操作类型：0-刷新开票认证状态（刷新认证状态）1-查询开票认证状态（查询库里的认证状态）2-查询全电登录状态（查询库里的全电登录状态）
    /// <code> 必填: Y </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[2]]> </code>
    /// </summary>
    [JsonPropertyName("queryType")]
    [JsonProperty("queryType", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string QueryType { get; set; }

    /// <summary>
    /// 全电账号
    /// <code> 必填: N </code>
    /// <code> 长度:  </code>
    /// <code> 示例: <![CDATA[13888888888]]> </code>
    /// </summary>
    [JsonPropertyName("eleAccount")]
    [JsonProperty("eleAccount")]
    [AllowNull]
    public string EleAccount { get; set; }
}
