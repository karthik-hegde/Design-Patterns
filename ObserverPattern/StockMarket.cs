namespace ObserverPattern
{
    public class StockMarket : ISubject
    {
        private List<IObserver> _observers;
        private Dictionary<string, double> StockPrices;

        private string lastUpdatedStock = "";
        public StockMarket()
        {
            _observers = new();
            StockPrices = new();
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void AddStock(string name, double price)
        {
            StockPrices.Add(name, price);
        }

        public void UpdateStockPrice(string stock, double price)
        {
            StockPrices[stock] = price;
            lastUpdatedStock = stock;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(lastUpdatedStock, StockPrices[lastUpdatedStock]);
            }
        }
    }
}