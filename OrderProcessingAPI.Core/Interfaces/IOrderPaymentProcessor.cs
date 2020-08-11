using System.Threading.Tasks;

namespace OrderProcessingAPI.Core.Interfaces
{
    public interface IOrderPaymentProcessor
    {
        Task<string> ProcessPayment();
    }
}
