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
        //��ѯ��Ʊ
        var stockRes = await _nuoNuoSdk.GetInvoiceStockAsync(new GetInvoiceStockRequest
        {
            ExtensionNums = new[] { "0", "8889" },
        });
        _logger.LogInformation("��ѯ��Ʊ:{body}", stockRes.Body);

        //��Ʊ
        var billingRes = await _nuoNuoSdk.RequestBillingAsync(new RequestBillingRequest
        {
            Order = new RequestBillingRequest.OrderDto
            {
                BuyerTaxNum = "6876413SAFDG"
            }
        });
        _logger.LogInformation("��Ʊ:{body}", billingRes.Body);

        //��ѯ
        var invoiceRes = await _nuoNuoSdk.QueryInvoiceResultAsync(new QueryInvoiceResultRequest
        {
            SerialNos = new List<string> { billingRes.Result.InvoiceSerialNum }
        });
        _logger.LogInformation("��ѯ��Ʊ:{body}", invoiceRes.Body);

        var r = invoiceRes.Result.First();
        //�ط�
        var deliveryInvoiceRes = await _nuoNuoSdk.DeliveryInvoiceAsync(new DeliveryInvoiceRequest
        {
            InvoiceCode = r.InvoiceCode,
            InvoiceNum = r.InvoiceNo,
            Taxnum = r.SalerTaxNum,
            Mail = "wwbgo@qq.com",
            Phone = ""
        });
        _logger.LogInformation("�ط���Ʊ:{body}", deliveryInvoiceRes.Body);

        //����
        var cancellationRes = await _nuoNuoSdk.InvoiceCancellationAsync(new InvoiceCancellationRequest
        {
            InvoiceId = billingRes.Result.InvoiceSerialNum,
            InvoiceCode = r.InvoiceCode,
            InvoiceNo = r.InvoiceNo
        });
        _logger.LogInformation("��Ʊ����:{body}", cancellationRes.Body);

        return "�������";
    }

}