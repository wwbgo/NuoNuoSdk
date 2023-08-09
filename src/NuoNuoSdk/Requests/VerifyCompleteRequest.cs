namespace NuoNuoSdk.Requests;

/// <summary>
/// 诺税通saas-全电平台扫码登录确认接口
/// <para>使用步骤： 1、先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 获取二维码给用户后 2、用户通过微信/税务app扫码（根据获取的二维码类型），在手机端上完成认证 3、调用该接口执行全电扫码登录的确认动作 4、短信验证码登录时，先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 发送短信验证码，然后通过该接口传入对应的短信验证码 注：用户扫码操作的全电账号 和 执行该登录确认的全电账号（分机号）必须是同一个</para>
/// </summary>
public class VerifyCompleteRequest : NuoNuoRequest
{
    public override string Method => "nuonuo.OpeMplatform.verifyComplete";

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
    /// 登录操作类型： 0-扫码登录验证完成操作（默认） 1-查询扫码登录结果 2-短信登录提交登录（此时verifyCode 必传） 3-查询短信登录结果
    /// <code> 必填: N </code>
    /// <code> 长度: 2 </code>
    /// <code> 示例: <![CDATA[2]]> </code>
    /// </summary>
    [JsonPropertyName("queryType")]
    [JsonProperty("queryType")]
    [AllowNull]
    public string QueryType { get; set; }

    /// <summary>
    /// 短信验证码（当全电发票开具进行短信验证码登录时才需要传）
    /// <code> 必填: N </code>
    /// <code> 长度: 10 </code>
    /// <code> 示例: <![CDATA[123456]]> </code>
    /// </summary>
    [JsonPropertyName("verifyCode")]
    [JsonProperty("verifyCode")]
    [AllowNull]
    public long VerifyCode { get; set; }
}
