using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class SmartDoor : Device
    {
        private string _name;
        public SmartDoor(string name)
        {
            _name = name;
        }

        public void Open()
        {
            Console.WriteLine("Door opened");
            _mediator.Notify("OpenDoor");
        }

        public void Close()
        {
            Console.WriteLine("Door closed");
            _mediator.Notify("CloseDoor");
        }


    }
}