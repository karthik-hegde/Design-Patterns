using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class NewsAgency : IObserver
    {
        private readonly double _threshold;

        public NewsAgency(double threshold)
        {
            _threshold = threshold;
        }

        public void Update(string stockName, double price)
        {
            if (Math.Abs(price) > _threshold)
            {
                Console.WriteLine($"News Agency Alert: {stockName} price has reached ${price}");
            }
        }
    }
}