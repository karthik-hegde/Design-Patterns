public class LegacyPaymentService
{
    public bool MakePayment(string customerId, double amount)
    {
        Console.WriteLine($"Processing payment of {amount} for customer {customerId} using legacy system.");
        return true; // Simulating successful payment
    }
}