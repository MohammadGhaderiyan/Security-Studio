using System;
using System.Threading.Tasks;
using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Windows.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Arp
{
    public class ArpWindowsCommandTool : WindowsCommandTool
    {
        public ArpWindowsCommandTool(WindowsOperatingSystem windowsOperatingSystem)
            : base("arp", "arp", windowsOperatingSystem)
        {
        }

        public Task<SsResult<string>> GetArpEntries()
        {
            return RunCommand("-a");
        }

        public override Task<SsResult<string>> GetHelp()
        {
            return RunCommand("/?");
        }

        public override Task<SsResult<string>> GetVersion()
        {
            return Task.FromResult(new SsResult<string>(new NotSupportedException()));
        }
    }
}