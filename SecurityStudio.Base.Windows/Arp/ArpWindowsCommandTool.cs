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

        public Task<Result<string>> GetArpEntries()
        {
            return RunCommand("-a");
        }

        public override Task<Result<string>> GetHelp()
        {
            return RunCommand("/?");
        }

        public override Task<Result<string>> GetVersion()
        {
            return Task.FromResult(new Result<string>(new NotSupportedException()));
        }
    }
}