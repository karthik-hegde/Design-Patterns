using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class SmartLight : Device
    {
        private string _name;
        public SmartLight(string name)
        {
            _name = name;
        }

        public void turnOn()
        {
            Console.WriteLine("Turning light on");
            _mediator.Notify("LightOn");
        }


        public void turnOff()
        {
            Console.WriteLine("Turning light off");
            _mediator.Notify("LightOff");
        }


    }
}