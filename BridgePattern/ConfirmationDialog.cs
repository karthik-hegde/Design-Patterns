using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConfirmationDialog : Dialog
    {
        private IButton _button;
        public ConfirmationDialog(IButton button)
        {
            _button = button;
        }

        public void Render()
        {
            Console.WriteLine("Rendering Confimation Dialog");
            _button.click();
        }
    }
}