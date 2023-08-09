namespace NuoNuoSdk.Responses;

/// <summary>
/// 诺税通saas查询/刷新扫码登录及风控后扫码认证的二维码接口
/// <para>用于开票时扫码登录 或 需要实名认证的时候，进行查询或刷新扫码登录或开票实人认证的二维码 1、当开票返回错误需要扫码登录时： 1.1、先进行 3-查询获取诺诺已获取登录认证二维码 1.2、若1.1 中没有返回对应二维码字符，则进行2-刷新获取登录认证二维码 操作，再进行 1.1 的操作（二维码有效期为5分钟） 2、当开票返回错误需要开票实人认证时： 2.1、先进行 1-查询获取诺诺已获取的开票实人认证二维码 2.2、若2.1 中没有返回对应二维码字符，则进行 0-刷新获取税局当前开票实人认证二维码 操作，再进行 2.1 的操作（二维码有效期为5分钟） 3、查询的时候 返回 result中的结构化信息 4、频率控制：每个税号下的每个账号 每天最多20次，每60秒最多1次 （刷新获取税局当前开票实人认证二维码/刷新获取登录认证二维码 操作类型 时）</para>
/// </summary>
public class GetQrCodeResponse : NuoNuoResponse<GetQrCodeResponse.GetQrCodeDto>
{
    public class GetQrCodeDto
    {
        /// <summary>
        /// 0-获取二维码中/短信发送中；1-成功；2-失败
        /// <code> 示例: <![CDATA[1]]> </code>
        /// </summary>
        [JsonPropertyName("status")]
        [JsonProperty("status")]
        [AllowNull]
        public string Status { get; set; }

        /// <summary>
        /// 结果信息（获取二维码中/查询成功/失败原因）
        /// <code> 示例: <![CDATA[查询成功]]> </code>
        /// </summary>
        [JsonPropertyName("message")]
        [JsonProperty("message")]
        [AllowNull]
        public string Message { get; set; }

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
        /// <code> 示例: <![CDATA[100]]> </code>
        /// </summary>
        [JsonPropertyName("extensionNumber")]
        [JsonProperty("extensionNumber")]
        [AllowNull]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// 二维码类型 1:登录扫码认证多源二维码（用微信/支付宝进行扫码 进行登录） 2:登录扫码认证税务APP二维码（用对应地区的税务app扫码 进行登录） 3:登录扫码认证电子营业执照二维码（用对应地区的电子营业执照app或小程序扫码 进行登录） 4:开票实人认证二维码 （用对应地区的税务app扫码 进行实人认证）
        /// <code> 示例: <![CDATA[2]]> </code>
        /// </summary>
        [JsonPropertyName("qrCodeType")]
        [JsonProperty("qrCodeType")]
        [AllowNull]
        public string QrCodeType { get; set; }

        /// <summary>
        /// 登录扫码认证 或 开票实人认证 的二维qrcode；（需要把该字符串转化成二维码提供给对应账号的用户扫码）
        /// <code> 示例: <![CDATA[qrcode_id=oc8G912345y58oeIgkKNNJ0utp6vEi1r4qhaZbPI2ekasdAvmDp7i7Yobk7123NM&areaPrefix=4400&interfaceCode=0002]]> </code>
        /// </summary>
        [JsonPropertyName("qrCode")]
        [JsonProperty("qrCode")]
        [AllowNull]
        public string QrCode { get; set; }

        /// <summary>
        /// 用户名/手机号（脱敏处理）
        /// <code> 示例: <![CDATA[138****1234]]> </code>
        /// </summary>
        [JsonPropertyName("account")]
        [JsonProperty("account")]
        [AllowNull]
        public string Account { get; set; }

        /// <summary>
        /// 二维码页面url（预留）
        /// <code> 示例: <![CDATA[]]> </code>
        /// </summary>
        [JsonPropertyName("qrCodeUrl")]
        [JsonProperty("qrCodeUrl")]
        [AllowNull]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 二维码/短信 过期截止时间
        /// <code> 示例: <![CDATA[]]> </code>
        /// </summary>
        [JsonPropertyName("endTime")]
        [JsonProperty("endTime")]
        [AllowNull]
        public string EndTime { get; set; }
    }
}
