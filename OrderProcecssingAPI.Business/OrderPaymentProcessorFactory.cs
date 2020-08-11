using OrderProcecssingAPI.Business;
using OrderProcecssingAPI.Business.RuleEngine;
using OrderProcessingAPI.Core.Interfaces;

namespace OrderProcecssingAPI.Processor
{
    public class OrderPaymentProcessorFactory : IOrderPaymentProcessorFactory
    {
        public IOrderPaymentProcessor GetPaymentProcessor(string paymentProcessor)
        {
            switch (paymentProcessor?.ToLower())
            {
                case nameof(Rule.book):
                    return new BookPaymentsProcessor();

                case nameof(Rule.product):
                    return new ProductPaymentProcessor();

                case nameof(Rule.membership):
                    return new MembershipPaymentProcessor();

                case nameof(Rule.upgrade):
                    return new UpgradeMembershipProcessor();               

                case nameof(Rule.video):
                    return new VideoPaymentProcessor();

                default:
                    return null;
            }
        }
    }
}
