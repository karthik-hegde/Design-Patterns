using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class HomeHub : IMediator
    {
        private List<Device> _devices;
        public HomeHub()
        {
            _devices = new();
        }

        public void Notify(string requestCode)
        {
            switch (requestCode)
            {
                case "OpenDoor":
                    handleDoorOpen();
                    break;
                case "CloseDoor":
                    handleDoorClose();
                    break;
                case "AutoClose":
                    handleAutoClose();
                    break;
                default:
                    break;

            }
        }

        public void RegisterDevice(Device device)
        {
            _devices.Add(device);
            device.setMediator(this);
        }


        private void handleDoorOpen()
        {
            foreach (Device device in _devices)
            {
                if (device is Thermostat thermo)
                {
                    thermo.IncreaseTemp();
                }
                if (device is SecuritySystem security)
                {
                    security.autoCloseDoor();
                }
            }
        }

        private void handleDoorClose()
        {
            foreach (Device device in _devices)
            {
                if (device is Thermostat thermo)
                {
                    thermo.DecreaseTemp();
                }
            }
        }

        private void handleAutoClose()
        {
            foreach (Device device in _devices)
            {
                if (device is SmartDoor door)
                {
                    door.Close();
                }
            }
        }
    }
}