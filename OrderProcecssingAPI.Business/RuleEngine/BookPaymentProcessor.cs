using OrderProcecssingAPI.Processor;
using OrderProcessingAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace OrderProcecssingAPI.Business
{
    public class BookPaymentsProcessor : IOrderPaymentProcessor
    {
        public async Task<string> ProcessPayment()
        {
            //Do Operation

            return $"{Helper.RoyalityDepartmentHelper} - { Helper.ComissionHelper}";
        }
    }
}
