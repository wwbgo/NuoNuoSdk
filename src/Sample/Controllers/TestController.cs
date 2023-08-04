using Microsoft.AspNetCore.Mvc;
using NuoNuoSdk;
using NuoNuoSdk.Requests;

namespace Sample.Controllers;

/// <summary>
/// Test
/// </summary>
[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;
    private readonly INuoNuoSdk _nuoNuoSdk;

    public TestController(ILogger<TestController> logger, INuoNuoSdk nuoNuoSdk)
    {
        _logger = logger;
        _nuoNuoSdk = nuoNuoSdk;
    }

    [HttpGet("nuonuo")]
    public async Task<string> Nuonuo()
    {
        //查询余票
        var stockRes = await _nuoNuoSdk.GetInvoiceStockAsync(new GetInvoiceStockRequest
        {
            ExtensionNums = new[] { "0", "8889" },
        });
        _logger.LogInformation("查询余票:{body}", stockRes.Body);

        //开票
        var billingRes = await _nuoNuoSdk.RequestBillingAsync(new RequestBillingRequest
        {
            Order = new RequestBillingRequest.OrderDto
            {
                BuyerName = "上海繁易信息科技股份有限公司",
                BuyerTaxNum = "111111111111111111",
                BuyerPhone = "13818989495",
                BuyerAddress = "上海市杨浦区国安路386号9楼",
                BuyerAccount = "",
                BuyerTel = "",
                Email = "",
                SalerAccount = "6222023803013297860",
                SalerTel = "021-68683993",
                SalerAddress = "上海市杨浦区黄兴路2005 弄2 号（B 楼）706-3 室",
                SalerTaxNum = "339901999999142",
                Clerk = "刘艳宁",
                Payee = "李冰冰",
                Checker = "张欢",
                OrderNo = DateTime.Now.Ticks.ToString(),
                InvoiceType = "1",
                InvoiceLine = "pc",
                PushMode = "1",
                InvoiceDate = DateTime.Now.ToInvoiceDatString(),
                InvoiceDetail = new[]{ new RequestBillingRequest.OrderDto.InvoiceDetailDto
                {
                    GoodsName = "技术服务费",
                    Num = "1",
                    Price = "5",
                    WithTaxFlag = "1",
                    TaxRate = "0.06",
                    SpecType = "流量卡充值",
                    Unit = "次",
                    GoodsCode = "3040203",
                } },
            }
        });
        _logger.LogInformation("开票:{body}", billingRes.Body);

        //查询
        var invoiceRes = await _nuoNuoSdk.QueryInvoiceResultAsync(new QueryInvoiceResultRequest
        {
            SerialNos = new List<string> { billingRes.Result.InvoiceSerialNum }
        });
        _logger.LogInformation("查询发票:{body}", invoiceRes.Body);

        var r = invoiceRes.Result.First();
        //重发
        var deliveryInvoiceRes = await _nuoNuoSdk.DeliveryInvoiceAsync(new DeliveryInvoiceRequest
        {
            InvoiceCode = r.InvoiceCode,
            InvoiceNum = r.InvoiceNo,
            Taxnum = r.SalerTaxNum,
            Mail = "wwbgo@qq.com",
            Phone = ""
        });
        _logger.LogInformation("重发发票:{body}", deliveryInvoiceRes.Body);

        //作废
        var cancellationRes = await _nuoNuoSdk.InvoiceCancellationAsync(new InvoiceCancellationRequest
        {
            InvoiceId = billingRes.Result.InvoiceSerialNum,
            InvoiceCode = r.InvoiceCode,
            InvoiceNo = r.InvoiceNo
        });
        _logger.LogInformation("发票作废:{body}", cancellationRes.Body);

        return "测试完成";
    }

}