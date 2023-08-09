namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas查询/刷新扫码登录及风控后扫码认证的二维码接口
/// <para>用于开票时扫码登录 或 需要实名认证的时候，进行查询或刷新扫码登录或开票实人认证的二维码 1、当开票返回错误需要扫码登录时： 1.1、先进行 3-查询获取诺诺已获取登录认证二维码 1.2、若1.1 中没有返回对应二维码字符，则进行2-刷新获取登录认证二维码 操作，再进行 1.1 的操作（二维码有效期为5分钟） 2、当开票返回错误需要开票实人认证时： 2.1、先进行 1-查询获取诺诺已获取的开票实人认证二维码 2.2、若2.1 中没有返回对应二维码字符，则进行 0-刷新获取税局当前开票实人认证二维码 操作，再进行 2.1 的操作（二维码有效期为5分钟） 3、查询的时候 返回 result中的结构化信息 4、频率控制：每个税号下的每个账号 每天最多20次，每60秒最多1次 （刷新获取税局当前开票实人认证二维码/刷新获取登录认证二维码 操作类型 时）</para>
/// </summary>
public class GetQrCodeRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.getQrCode";

    /// <summary>
    /// 分机号
    /// <code> 必填: N </code>
    /// <code> 长度: 5 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("extensionNumber")]
    [JsonProperty("extensionNumber")]
    [AllowNull]
    public string ExtensionNumber { get; set; }

    /// <summary>
    /// 部门id
    /// <code> 必填: N </code>
    /// <code> 长度: 32 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("deptId")]
    [JsonProperty("deptId")]
    [AllowNull]
    public string DeptId { get; set; }

    /// <summary>
    /// 开票员id
    /// <code> 必填: N </code>
    /// <code> 长度: 32 </code>
    /// <code> 示例: <![CDATA[]]> </code>
    /// </summary>
    [JsonPropertyName("clerkId")]
    [JsonProperty("clerkId")]
    [AllowNull]
    public string ClerkId { get; set; }

    /// <summary>
    /// 操作类型：0-刷新获取税局当前开票实人认证二维码 1-查询获取诺诺已获取的开票实人认证二维码； 2-刷新获取登录认证二维码 3-查询获取诺诺已获取登录认证二维码；4-发送短信验证码（短信验证码登录时） 5-查询短信验证发送状态
    /// <code> 必填: Y </code>
    /// <code> 长度: 1 </code>
    /// <code> 示例: <![CDATA[1]]> </code>
    /// </summary>
    [JsonPropertyName("queryType")]
    [JsonProperty("queryType", Required = Required.Always)]
    [NotNull, DisallowNull]
    public string QueryType { get; set; }
}
