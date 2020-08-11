using OrderProcessingAPI.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace OrderProcessingAPI.Service
{
    public class OrderPaymentService
    {
        IOrderPaymentProcessor _orderPaymentProcessor;
        public OrderPaymentService(IOrderPaymentProcessor orderPaymentProcessor)
        {
            _orderPaymentProcessor = orderPaymentProcessor;
        }

        public async Task<string> ProcessPayment()
        {
            return await _orderPaymentProcessor.ProcessPayment();
        }
    }
}
