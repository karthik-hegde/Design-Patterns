

namespace AdapterPattern
{
    public class LegacyPaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentService _leagcyService;

        public LegacyPaymentAdapter(LegacyPaymentService legacyPaymentService)
        {
            _leagcyService = legacyPaymentService;
        }
        public bool ProcessPayment(string customerId, decimal amount)
        {
            return _leagcyService.MakePayment(customerId, (double)amount);
        }
    }
}