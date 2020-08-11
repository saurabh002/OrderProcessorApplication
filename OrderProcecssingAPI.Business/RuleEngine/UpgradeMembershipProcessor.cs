using OrderProcecssingAPI.Processor;
using OrderProcessingAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace OrderProcecssingAPI.Business.RuleEngine
{
    public class UpgradeMembershipProcessor : IOrderPaymentProcessor
    {
        public async Task<string> ProcessPayment()
        {
            //Do Operation

            return $"{Helper.UpgradeHelper} - { Helper.EmailNotificationSender}";
        }
    }
}
