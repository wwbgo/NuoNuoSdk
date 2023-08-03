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
                switch (parts.Length)
                {
                    case 2:
                        if (parts[0] != name)
                        {
                            csText.WriteLine(txt);
                        }
                        break;
                    case 3:
                        if (parts[0] != name)
                        {
                            GenField(csText, parts, GetSubClassName(txts, i), tab);
                            EndLine(txts, csText, i);
                        }
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
            csText.WriteLine($"{Tab(tab)}/// <code> 示例: {sample} </code>");
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
