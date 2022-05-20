using System.Diagnostics;
using SecurityStudio.Base.Windows.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Utility
{
    public class UtilityWindowsTool : WindowsTool
    {
        public UtilityWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
            : base("Utility", windowsOperatingSystem)
        {
        }

        public void OpenCommandPrompt()
        {
            var processStartInfo = new ProcessStartInfo
            {
                WorkingDirectory = "C:\\",
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            Process.Start(processStartInfo);
        }
    }
}