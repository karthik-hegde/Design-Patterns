using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IMediator
    {
        void RegisterDevice(Device device);
        void Notify(string requestCode);
    }
}