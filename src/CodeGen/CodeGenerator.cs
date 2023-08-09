namespace CodeGen
{
    public static class CodeGenerator
    {
        public static void Gen()
        {
            var defines = new DefineClass[]
            {
                new DefineClass("RequestBilling", "nuonuo.OpeMplatform.requestBillingNew(诺税通saas请求开具发票接口)",
                    "具备诺税通saas资质的企业用户（集团总公司可拿下面公司的税号来开票，但需要先授权）填写发票销方、购方、明细等信息并发起开票请求。",
                    "requestBillingNew"),
                new DefineClass("GetInvoiceStock", "nuonuo.OpeMplatform.getInvoiceStock(诺税通saas企业发票余量查询接口)",
                    "企业发票库存查询接口： 都传入的时候，各参数优先级：分机号>机器编号>分机号+机器编号的联合查询>部门ID",
                    "getInvoiceStock"),
                new DefineClass("DeliveryInvoice", "nuonuo.OpeMplatform.deliveryInvoice(诺税通saas发票重新交付接口)",
                    "通过该接口重新交付平台开具的发票至消费者短信、邮箱",
                    "deliveryInvoice"),
                new DefineClass("InvoiceCancellation", "nuonuo.OpeMplatform.invoiceCancellation(诺税通saas发票作废接口)",
                    "用户作废已开票成功的发票",
                    "invoiceCancellation"),
                new DefineClass("QueryInvoiceResult", "nuonuo.OpeMplatform.queryInvoiceResult(诺税通saas发票详情查询接口)",
                    "调用该接口获取发票开票结果等有关发票信息，部分字段需要配置才返回",
                    "queryInvoiceResult"),
                new DefineClass("ReInvoice", "nuonuo.OpeMplatform.reInvoice(诺税通saas开票重试接口)",
                    "发票开票失败时，可使用该接口进行重推开票，发票订单号、流水号与原请求一致 1、对于开票成功状态的发票（发票生成、开票完成），调用该接口，提示：发票已生成，无需再重试开票 2、对于开票中状态的发票，调用该接口，提示：开票中（重试中），请耐心等待开票结果",
                    "reInvoice"),
                new DefineClass("GetQrCode", "nuonuo.OpeMplatform.getQrCode(诺税通saas查询/刷新扫码登录及风控后扫码认证的二维码接口)",
                    "用于开票时扫码登录 或 需要实名认证的时候，进行查询或刷新扫码登录或开票实人认证的二维码 1、当开票返回错误需要扫码登录时： 1.1、先进行 3-查询获取诺诺已获取登录认证二维码 1.2、若1.1 中没有返回对应二维码字符，则进行2-刷新获取登录认证二维码 操作，再进行 1.1 的操作（二维码有效期为5分钟） 2、当开票返回错误需要开票实人认证时： 2.1、先进行 1-查询获取诺诺已获取的开票实人认证二维码 2.2、若2.1 中没有返回对应二维码字符，则进行 0-刷新获取税局当前开票实人认证二维码 操作，再进行 2.1 的操作（二维码有效期为5分钟） 3、查询的时候 返回 result中的结构化信息 4、频率控制：每个税号下的每个账号 每天最多20次，每60秒最多1次 （刷新获取税局当前开票实人认证二维码/刷新获取登录认证二维码 操作类型 时）",
                    "getQrCode"),
                new DefineClass("VerifyComplete", "nuonuo.OpeMplatform.verifyComplete(诺税通saas-全电平台扫码登录确认接口)",
                    "使用步骤： 1、先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 获取二维码给用户后 2、用户通过微信/税务app扫码（根据获取的二维码类型），在手机端上完成认证 3、调用该接口执行全电扫码登录的确认动作 4、短信验证码登录时，先通过查询/刷新扫码登录及风控后扫码认证的二维码接口 发送短信验证码，然后通过该接口传入对应的短信验证码 注：用户扫码操作的全电账号 和 执行该登录确认的全电账号（分机号）必须是同一个",
                    "verifyComplete"),
                new DefineClass("GetCreditLine", "nuonuo.OpeMplatform.getCreditLine(诺税通saas查询/刷新企业授信额度的接口)",
                    "1、操作类型：0-刷新（从税局更新库里授信额度）1-查询（查询库里的授信额度） 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 查询的时候 返回 result中的结构化信息 2、使用时可以先使用 刷新操作，等待一段时间后 使用查询操作 3、频率控制：每个税号下的每个账号 每天最多20次，每30秒最多1次 （仅刷新操作）",
                    "getCreditLine"),
                new DefineClass("GetCertificationStatus", "nuonuo.OpeMplatform.getCertificationStatus(诺税通saas查询/刷新全电账号登录及开票认证状态的接口)",
                    "1、操作类型：0-刷新开票认证状态（刷新认证状态）1-查询开票认证状态（查询库里的认证状态）2-查询全电登录状态（查询库里的全电登录状态） 1.1 刷新的时候，返回结果 请求成功/失败，失败给出失败原因； 1.2 查询的时候 返回 result中的结构化信息 2、频率控制：刷新操作 每个税号下的每个账号 每天最多20次，每30秒最多1次",
                    "getCertificationStatus"),
            };
            GenClass(defines);
            GenInterface(defines);
        }
        private static void GenClass(DefineClass[] defines)
        {
            foreach (var define in defines)
            {
                GenClass(define, true);
                GenClass(define, false);
            }
        }
        private static void GenInterface(DefineClass[] defines)
        {
            GenInterface(defines, false);
            GenInterface(defines, true);
        }

        private static void GenInterface(DefineClass[] defines, bool isInterface)
        {
            var tab = 0;
            var csPath = Path.Combine(GetSdkProjPath(), isInterface ? "INuoNuoSdkApi.cs" : "NuoNuoSdkApi.cs");
            var csText = new StreamWriter(csPath);

            csText.WriteLine("namespace NuoNuoSdk;");
            csText.WriteLine();
            csText.WriteLine("/// <summary>");
            csText.WriteLine("/// 诺诺开放平台SDK");
            csText.WriteLine("/// </summary>");
            if (isInterface)
            {
                csText.WriteLine("public partial interface INuoNuoSdk");
            }
            else
            {
                csText.WriteLine("public partial class NuoNuoSdk : INuoNuoSdk");
            }
            csText.WriteLine("{");

            for (var i = 0; i < defines.Length; i++)
            {
                var define = defines[i];

                csText.WriteLine($"{Tab(tab)}/// <summary>");
                csText.WriteLine($"{Tab(tab)}/// {define.Title}");
                csText.WriteLine($"{Tab(tab)}/// <para>{define.Description}</para>");
                csText.WriteLine($"{Tab(tab)}/// </summary>");
                csText.WriteLine($"{Tab(tab)}/// <param name=\"request\"><see cref=\"{define.Name}Request\"/></param>");
                csText.WriteLine($"{Tab(tab)}/// <returns><see cref=\"{define.Name}Response\"/></returns>");
                if (isInterface)
                {
                    csText.WriteLine($"{Tab(tab)}Task<{define.Name}Response> {define.Name}Async({define.Name}Request request);");
                }
                else
                {
                    csText.WriteLine($"{Tab(tab)}public Task<{define.Name}Response> {define.Name}Async({define.Name}Request request)");
                    csText.WriteLine($"{Tab(tab)}{{");
                    csText.WriteLine($"{Tab(tab + 1)}return ExecuteAsync<{define.Name}Request, {define.Name}Response>(request);");
                    csText.WriteLine($"{Tab(tab)}}}");
                }
                if (defines.Length > i + 1)
                {
                    csText.WriteLine();
                }
            }

            csText.WriteLine("}");

            csText.Flush();
        }

        private static void GenClass(DefineClass define, bool request)
        {
            var name = define.Name;
            var titles = define.Title.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var method = titles[0];
            var title = titles[1];
            var description = define.Description;
            var file = $"{define.FileNamePrefix}.{(request ? "request" : "response")}";
            var nameSpace = request ? "Request" : "Response";

            var tab = 0;
            var txts = File.ReadAllLines($"txt/{file}.txt");
            var csPath = Path.Combine(GetSdkProjPath(), $"{nameSpace}s", $"{name}{nameSpace}.cs");
            var csText = new StreamWriter(csPath);
            csText.WriteLine($"namespace NuoNuoSdk.{nameSpace}s;");
            csText.WriteLine();
            csText.WriteLine("/// <summary>");
            csText.WriteLine($"/// {title}");
            csText.WriteLine($"/// <para>{description}</para>");
            csText.WriteLine("/// </summary>");
            if (request)
            {
                csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}");
            }
            else
            {
                var parts = txts[0].Split('\t', StringSplitOptions.TrimEntries);
                var type = parts[1];
                if (txts.Length == 1)
                {
                    switch (type)
                    {
                        case "Array":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<IList<string>>");
                            break;
                        case "Object":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}");
                            break;
                        case "String":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<string>");
                            break;
                        case "Number":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<long>");
                            break;
                        default:
                            throw new NotSupportedException(type);
                    }
                }
                else
                {
                    switch (type)
                    {
                        case "Array":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<IList<{name}{nameSpace}.{name}Dto>>");
                            break;
                        case "Object":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<{name}{nameSpace}.{name}Dto>");
                            break;
                        case "String":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<string>");
                            break;
                        case "Number":
                            csText.WriteLine($"public class {name}{nameSpace} : NuoNuo{nameSpace}<long>");
                            break;
                        default:
                            throw new NotSupportedException(type);
                    }
                }
            }
            csText.WriteLine("{");
            if (request)
            {
                csText.WriteLine($"{Tab(tab)}public override string Method => \"{method}\";");
                csText.WriteLine();
            }
            else
            {
                txts[0] = txts[0].Replace("result", name);
            }

            for (var i = 0; i < txts.Length; i++)
            {
                var txt = txts[i];
                var parts = txt.Split('\t', StringSplitOptions.TrimEntries);
                if (!request && i == 0 && parts[0] == name)
                {
                    continue;
                }
                switch (parts.Length)
                {
                    case 2:
                        csText.WriteLine(txt);
                        break;
                    case 3:
                        GenField(csText, parts, GetSubClassName(txts, i), tab);
                        EndLine(txts, csText, i);
                        break;
                    case 4:
                        GenField(csText, parts, GetSubClassName(txts, i), tab);
                        EndLine(txts, csText, i);
                        break;
                    case 6:
                        GenField(csText, parts, GetSubClassName(txts, i), tab);
                        EndLine(txts, csText, i);
                        break;
                    case 1:
                        switch (parts[0])
                        {
                            case "[":
                                {
                                    var prevTxt = txts[i - 1];
                                    var prevParts = prevTxt.Split('\t', StringSplitOptions.TrimEntries);
                                    var field = ToTitleCase(TrimEnd(prevParts[0], "list"));
                                    csText.WriteLine($"{Tab(tab)}public class {field}Dto");
                                    csText.WriteLine($"{Tab(tab)}{{");
                                    tab += 1;
                                    break;
                                }

                            case "]":
                                tab -= 1;
                                csText.WriteLine($"{Tab(tab)}}}");
                                break;
                        }

                        break;

                    default:
                        csText.WriteLine(txt);
                        break;
                }
            }

            csText.WriteLine("}");

            csText.Flush();
        }

        private static void EndLine(string[] txts, StreamWriter csText, int i)
        {
            if (i + 1 != txts.Length && txts[i + 1] != "]")
            {
                csText.WriteLine();
            }
        }

        private static string GetSubClassName(IList<string> txts, int i)
        {
            if (txts.Count < i + 1)
            {
                return null;
            }
            if (txts.Count == i + 1)
            {
                return "string";
            }
            if (txts[i + 1] == "[")
            {
                return null;
            }
            return "string";
        }
        private static void GenField(StreamWriter csText, string[] parts, string arrayType, int tab)
        {
            var field = TrimEnd(parts[0], "list");
            var type = parts[1];
            string? required = null;
            string? sample = null;
            string? length = null;
            string? description = null;
            var request = parts.Length == 6;
            if (parts.Length == 3)
            {
                description = parts[2];
            }
            else if (parts.Length == 4)
            {
                description = parts[2];
                sample = parts[3];
            }
            else if (parts.Length == 6)
            {
                required = parts[2];
                sample = parts[3];
                length = parts[4];
                description = parts[5];
            }

            var csType = type switch
            {
                "String" => "string",
                "Number" => "long",
                "Object" => $"{ToTitleCase(field)}Dto",
                "Array" => arrayType == null ? $"IList<{ToTitleCase(field)}Dto>" : $"IList<{arrayType}>",
                _ => throw new NotSupportedException(type),
            };

            csText.WriteLine($"{Tab(tab)}/// <summary>");
            csText.WriteLine($"{Tab(tab)}/// {description}");
            if (request)
            {
                csText.WriteLine($"{Tab(tab)}/// <code> 必填: {required} </code>");
                csText.WriteLine($"{Tab(tab)}/// <code> 长度: {length} </code>");
            }
            csText.WriteLine($"{Tab(tab)}/// <code> 示例: <![CDATA[{sample}]]> </code>");
            csText.WriteLine($"{Tab(tab)}/// </summary>");
            csText.WriteLine($"{Tab(tab)}[JsonPropertyName(\"{field}\")]");
            if (required == "Y")
            {
                csText.WriteLine($"{Tab(tab)}[JsonProperty(\"{field}\", Required = Required.Always)]");
                csText.WriteLine($"{Tab(tab)}[NotNull, DisallowNull]");
            }
            else
            {
                csText.WriteLine($"{Tab(tab)}[JsonProperty(\"{field}\")]");
                csText.WriteLine($"{Tab(tab)}[AllowNull]");
            }
            csText.WriteLine($"{Tab(tab)}public {csType} {ToTitleCase(field)} {{ get; set; }}");
        }

        private static string GetSdkProjPath()
        {
            var dir = new DirectoryInfo(Environment.CurrentDirectory);
            while (dir.Name != "src")
            {
                dir = dir.Parent;
            }
            return Path.Combine(dir.FullName, "NuoNuoSdk");
        }
        private static string Tab(int n) => string.Join("", Enumerable.Repeat("    ", n + 1));
        private static string TrimEnd(string field, string suffix) => field.EndsWith(suffix, StringComparison.CurrentCultureIgnoreCase)
                ? field.Remove(field.LastIndexOf(suffix, StringComparison.CurrentCultureIgnoreCase))
                : field;
        private static string ToTitleCase(string field) => char.ToUpper(field[0]) + field[1..];
    }
}
