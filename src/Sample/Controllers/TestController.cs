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
                BuyerTaxNum = "6876413SAFDG"
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