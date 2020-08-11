namespace OrderProcessingAPI.Core.Interfaces
{
    public interface IOrderPaymentProcessorFactory
    {
        IOrderPaymentProcessor GetPaymentProcessor(string paymentProcessor);
    }
}
