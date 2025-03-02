using BridgePattern;

class Program
{
    static void Main()
    {

        // Creating different buttons
        IButton windowsButton = new WindowsButton();
        IButton linuxButton = new LinuxButton();
        IButton macButton = new MacOSButton();

        // Using different buttons with the AlertDialog
        Dialog alertWindows = new AlertDialog(windowsButton);
        Dialog alertLinux = new AlertDialog(linuxButton);
        Dialog alertMac = new AlertDialog(macButton);

        // Using different buttons with the ConfirmationDialog
        Dialog confirmWindows = new ConfirmationDialog(windowsButton);
        Dialog confirmLinux = new ConfirmationDialog(linuxButton);
        Dialog confirmMac = new ConfirmationDialog(macButton);

        // Testing
        alertWindows.Render();
        alertLinux.Render();
        alertMac.Render();

        confirmWindows.Render();
        confirmLinux.Render();
        confirmMac.Render();
    }
}

