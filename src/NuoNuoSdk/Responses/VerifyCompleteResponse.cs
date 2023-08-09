namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas-全电平台扫码登录确认接口
/// <para>使用步骤： 1、先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 获取二维码给用户后 2、用户通过微信/税务app扫码（根据获取的二维码类型），在手机端上完成认证 3、调用该接口执行全电扫码登录的确认动作 4、短信验证码登录时，先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 发送短信验证码，然后通过该接口传入对应的短信验证码 注：用户扫码操作的全电账号 和 执行该登录确认的全电账号（分机号）必须是同一个</para>
/// </summary>
public class VerifyCompleteResponse : NuoNuoResponse<VerifyCompleteResponse.VerifyCompleteDto>
{
    public class VerifyCompleteDto
    {
        /// <summary>
        /// 0-登录执行中；1-成功；2-失败/未登录
        /// <code> 示例: <![CDATA[1]]> </code>
        /// </summary>
        [JsonPropertyName("status")]
        [JsonProperty("status")]
        [AllowNull]
        public string Status { get; set; }

        /// <summary>
        /// 结果信息（登录成功/失败原因）
        /// <code> 示例: <![CDATA[]]> </code>
        /// </summary>
        [JsonPropertyName("message")]
        [JsonProperty("message")]
        [AllowNull]
        public string Message { get; set; }

        /// <summary>
        /// 登录方式：1-扫码登录 2-短信验证码登录
        /// <code> 示例: <![CDATA[2]]> </code>
        /// </summary>
        [JsonPropertyName("loginType")]
        [JsonProperty("loginType")]
        [AllowNull]
        public string LoginType { get; set; }

        /// <summary>
        /// 税号
        /// <code> 示例: <![CDATA[339901999999199]]> </code>
        /// </summary>
        [JsonPropertyName("taxNum")]
        [JsonProperty("taxNum")]
        [AllowNull]
        public string TaxNum { get; set; }

        /// <summary>
        /// 分机号
        /// <code> 示例: <![CDATA[1000]]> </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 用户名/手机号（脱敏处理）
        /// <code> 示例: <![CDATA[138****1234]]> </code>
        /// </summary>
        [JsonPropertyName("account")]
        [JsonProperty("account")]
        [AllowNull]
        public string Account { get; set; }
    }
}
