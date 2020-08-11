using Microsoft.AspNetCore.Mvc;
using OrderProcessingAPI.Core.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderProcessingAPI
{
    [ApiController]
    [Route("[controller]")]
    public class OrderPaymentController : ControllerBase
    {
        IOrderPaymentProcessorService _orderPaymentProcessorService;
        public OrderPaymentController(IOrderPaymentProcessorService orderPaymentProcessorService)
        {
            _orderPaymentProcessorService = orderPaymentProcessorService;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment(string processor)
        {
            try
            {
                var response = await _orderPaymentProcessorService.ProcessPayment(processor);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }

}
