using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class WindowsButton : IButton
    {
        public void click()
        {
            Console.WriteLine("Clicked Windows button");
        }
    }
}