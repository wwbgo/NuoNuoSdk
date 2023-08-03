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
        //��ȡtoken,����token��Ч������ά������
        var token = await _nuoNuoSdk.GetMerchantTokenAsync();
        _logger.LogInformation("��ȡtoken:{token}", token);
        //var token = new MerchantTokenResponse
        //{
        //    AccessToken = "none"
        //};

        //��ѯ��Ʊ
        var stockRes = await _nuoNuoSdk.GetInvoiceStockAsync(new GetInvoiceStockRequest
        {
            AccessToken = token.AccessToken,
            MachineCode = "111111111111",
        });
        _logger.LogInformation("��ѯ��Ʊ:{body}", stockRes.Body);

        //��Ʊ
        var billingRes = await _nuoNuoSdk.RequestBillingAsync(new RequestBillingRequest
        {
            AccessToken = token.AccessToken,
            Order = new RequestBillingRequest.OrderDto
            {
                BuyerTaxNum = "6876413SAFDG"
            }
        });
        _logger.LogInformation("��Ʊ:{body}", billingRes.Body);

        //��ѯ
        var invoiceRes = await _nuoNuoSdk.QueryInvoiceResultAsync(new QueryInvoiceResultRequest
        {
            AccessToken = token.AccessToken,
            SerialNos = new List<string> { billingRes.Result.InvoiceSerialNum }
        });
        _logger.LogInformation("��ѯ��Ʊ:{body}", invoiceRes.Body);

        var r = invoiceRes.Result.First();
        //�ط�
        var deliveryInvoiceRes = await _nuoNuoSdk.DeliveryInvoiceAsync(new DeliveryInvoiceRequest
        {
            AccessToken = token.AccessToken,
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
            AccessToken = token.AccessToken,
            InvoiceId = billingRes.Result.InvoiceSerialNum,
            InvoiceCode = r.InvoiceCode,
            InvoiceNo = r.InvoiceNo
        });
        _logger.LogInformation("��Ʊ����:{body}", cancellationRes.Body);

        return "�������";
    }

}