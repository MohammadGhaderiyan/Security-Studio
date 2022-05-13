using System.Threading.Tasks;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.FileExplorer
{
    public class FileExplorerWindowsTool : WindowsTool
    {
        public FileExplorerWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
            : base(windowsOperatingSystem)
        {
            CommandName = "arp";
        }

        public Task<string> GetArpEntries()
        {
            return RunCommand("-a");
        }

        public override Task<string> Help()
        {
            return RunCommand("");
        }
    }
}