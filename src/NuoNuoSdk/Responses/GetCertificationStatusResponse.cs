namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas查询/刷新全电账号登录及开票认证状态的接口
/// <para>1、操作类型：0-刷新开票认证状态（刷新认证状态）1-查询开票认证状态（查询库里的认证状态）2-查询全电登录状态（查询库里的全电登录状态） 1.1 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 1.2 查询的时候 返回 result中的结构化信息 2、频率控制：刷新操作 每个税号下的每个账号 每天最多20次，每30秒最多1次</para>
/// </summary>
public class GetCertificationStatusResponse : NuoNuoResponse<GetCertificationStatusResponse.GetCertificationStatusDto>
{
    public class GetCertificationStatusDto
    {
        /// <summary>
        /// 全电账户
        /// <code> 示例: <![CDATA[]]> </code>
        /// </summary>
        [JsonPropertyName("eleAccount")]
        [JsonProperty("eleAccount")]
        [AllowNull]
        public string EleAccount { get; set; }

        /// <summary>
        /// 开票认证状态：0-未知；1-已认证；2-待认证，3-查询中 （登录状态：0-未登录；1-已登录）
        /// <code> 示例: <![CDATA[1]]> </code>
        /// </summary>
        [JsonPropertyName("certificationStatus")]
        [JsonProperty("certificationStatus")]
        [AllowNull]
        public string CertificationStatus { get; set; }

        /// <summary>
        /// 分机号
        /// <code> 示例: <![CDATA[333]]> </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 登录模式（0-账号密码快捷登录 1-扫码登录 2-短信验证码登录 3-证书登录） 注：只在queryType=2 时返回该字段
        /// <code> 示例: <![CDATA[]]> </code>
        /// </summary>
        [JsonPropertyName("loginType")]
        [JsonProperty("loginType")]
        [AllowNull]
        public string LoginType { get; set; }
    }
}
