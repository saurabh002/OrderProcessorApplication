using OrderProcecssingAPI.Processor;
using OrderProcessingAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace OrderProcecssingAPI.Business.RuleEngine
{
    public class MembershipPaymentProcessor : IOrderPaymentProcessor
    {
        public async Task<string> ProcessPayment()
        {
            //Do Operation

            return $"{Helper.MembershipHelper} - {Helper.EmailNotificationSender}";
        }
        //public async Task<string> SendNotification(INotification notification)
        //{
        //    return await notification.SendNotification("Email sent");
        //}
    }
}
