using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAPI.Core.Interfaces
{
    public interface IOrderPaymentProcessorService
    {
        Task<string> ProcessPayment(string paymentProcessor);
    }
}
