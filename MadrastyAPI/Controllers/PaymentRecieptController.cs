using  BusinessLogic.Abstractions;
using  BusinessLogic.ViewModels;
using  Microsoft.AspNetCore.Mvc;

namespace MadrastyAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentRecieptController : Controller
    {
        private readonly IPaymentRecieptServices _paymentRecieptServices;

        public PaymentRecieptController(IPaymentRecieptServices paymentRecieptServices)
        {
            _paymentRecieptServices = paymentRecieptServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentReciept()
        {
            return Ok(await _paymentRecieptServices.GetPaymentReciept());
        }
        
        [HttpGet("id")]
        public async Task<IActionResult> GetPaymentRecieptById(int id)
        {
            return Ok(await _paymentRecieptServices.GetPaymentRecieptById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SavePaymentReciept(payment_reciept reciept)
        {
            return Ok(await _paymentRecieptServices.SavePaymentReciept(reciept));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePaymentReciept(payment_reciept reciept)
        {
            return Ok(await _paymentRecieptServices.UpdatePaymentReciept(reciept));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentReciept(int id)
        {
            return Ok(await _paymentRecieptServices.DeletePaymentReciept(id));
        }
    }
}
