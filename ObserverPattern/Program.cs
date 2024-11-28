using ObserverPattern;

var stockMarket = new StockMarket();

// Observers
var investor1 = new Investor("Alice", "AAPL");
var portfolioManager = new PortfolioManager("Global Fund");
var newsAgency = new NewsAgency(3000);

// Attach Observers
stockMarket.Attach(investor1);
stockMarket.Attach(portfolioManager);
stockMarket.Attach(newsAgency);

// Add and update stocks
stockMarket.AddStock("AAPL", 150);
stockMarket.AddStock("MSFT", 250);
stockMarket.AddStock("GOOGL", 2800);

// Simulate real-time updates with a delay
await Task.Delay(2000);
stockMarket.UpdateStockPrice("AAPL", 160);

await Task.Delay(2000);
stockMarket.UpdateStockPrice("MSFT", 220);

await Task.Delay(2000);
stockMarket.UpdateStockPrice("GOOGL", 3100);

// Detach an observer and show updates without them
Console.WriteLine("\nDetaching Alice (Investor for AAPL)...\n");
stockMarket.Detach(investor1);

await Task.Delay(2000);
stockMarket.UpdateStockPrice("AAPL", 170);