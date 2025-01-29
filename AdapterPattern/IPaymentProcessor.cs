public interface IPaymentProcessor
{
    bool ProcessPayment(string customerId, decimal amount);
}