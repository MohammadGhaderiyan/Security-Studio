using System.Threading.Tasks;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Arp
{
    public class ArpWindowsTool : WindowsTool
    {
        public ArpWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
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