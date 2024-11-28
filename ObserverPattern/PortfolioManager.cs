using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class PortfolioManager : IObserver
    {
        private readonly string _name;

        public PortfolioManager(string name)
        {
            _name = name;
        }

        public void Update(string stockName, double price)
        {
            Console.WriteLine($"Portfolio Manager {_name} updated: {stockName} is now ${price}");
        }
    }
}   