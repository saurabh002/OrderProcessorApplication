using OrderProcessingAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace OrderProcecssingAPI.Business
{
    public class BookProcessorProcessor : IOrderPaymentProcessor
    {
        public async Task<string> ProcessPayment()
        {
            return null;
        }
    }
}
