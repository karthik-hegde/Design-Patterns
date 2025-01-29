using AdapterPattern;

IPaymentProcessor paymentProcessor = new LegacyPaymentAdapter(new LegacyPaymentService());
bool success = paymentProcessor.ProcessPayment("C123", 499.99m);
Console.WriteLine("Payment success: " + success);