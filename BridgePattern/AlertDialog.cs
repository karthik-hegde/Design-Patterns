namespace BridgePattern
{
    public class AlertDialog : Dialog
    {
        private IButton _button;
        public AlertDialog(IButton button)
        {
            _button = button;
        }

        public void Render()
        {
            Console.WriteLine("Rendering Alert Dialog");
            _button.click();
        }
    }
}