namespace ObserverPattern
{
    public class Investor : IObserver
    {
        private readonly string _name;
        private readonly string _interestedStock;

        public Investor(string name, string interestedStock)
        {
            _name = name;
            _interestedStock = interestedStock;
        }
        public void Update(string stock, double price)
        {
            if (stock == _interestedStock)
            {
                Console.WriteLine($"{_name} recieved stock update on {stock}: {price}");
            }
        }
    }
}