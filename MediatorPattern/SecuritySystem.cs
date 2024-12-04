using System.Timers;
using Timer = System.Threading.Timer;

namespace MediatorPattern
{
    public class SecuritySystem : Device
    {
        private string _name;
        public SecuritySystem(string name)
        {
            _name = name;
        }

        public async void autoCloseDoor()
        {
            await Task.Delay(5000);
            _mediator.Notify("AutoClose");
        }
    }
}