using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Thermostat : Device
    {
        private string _name;
        public Thermostat(string name)
        {
            _name = name;
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing temp");
            _mediator.Notify("TempInc");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("Descreasing temp");
            _mediator.Notify("TempDesc");
        }
    }
}