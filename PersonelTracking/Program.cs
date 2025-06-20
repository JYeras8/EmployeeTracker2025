using PersonelTracking.Helpers;
using static PersonelTracking.Program.MouseClickMessageFilter;

namespace PersonelTracking;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.AddMessageFilter(new MouseClickMessageFilter()); //global mouse message listener
        Application.AddMessageFilter(new KeyDownMessageFilter()); //global Key message listener

        Application.Run(new FrmLogin());

    }

    public class MouseClickMessageFilter : IMessageFilter
    {
        private const int WM_LBUTTONDOWN = 0x0201; // Left mouse button down

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN)
            {
                General.PlayRandomMouseClickSound();
            }
            return false; // Don't block other processing
        }

    }

    public class KeyDownMessageFilter : IMessageFilter
    {
        private const int WM_KEYDOWN = 0x0100;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                General.PlayRandomKeyDownSounds();
            }
            return false;
        }
    }
        
}