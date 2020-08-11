using OrderProcessingAPI.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace OrderProcessingAPI.Service
{
    public class OrderPaymentService: IOrderPaymentProcessorService
    {
        IOrderPaymentProcessorFactory _paymentFactory;
        public OrderPaymentService(IOrderPaymentProcessorFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        public async Task<string> ProcessPayment(string processor)
        {
            var paymentProcessor = _paymentFactory.GetPaymentProcessor(processor);
            return await paymentProcessor.ProcessPayment();
        }
    }
}
