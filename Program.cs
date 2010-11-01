using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace MceRemoteMapper
{
    /// <summary>
    /// Application initialization.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Detect administrative rights.
            bool administrator = (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
            if (!administrator)
            {
                MessageBox.Show("This application requires administrative rights in order to update the registry.", "Administrative rights required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProcessStartInfo proccessStartInfo = new ProcessStartInfo();
                proccessStartInfo.UseShellExecute = true;
                proccessStartInfo.WorkingDirectory = Environment.CurrentDirectory;
                proccessStartInfo.FileName = Application.ExecutablePath;
                proccessStartInfo.Verb = "runas";
                Process.Start(proccessStartInfo);
                return;
            }

            // Detect remote receiver.
            if (!Remote.Detect())
            {
                MessageBox.Show("No compatible RC6 based MCE remote receiver could be found.", "Receiver could not be detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
