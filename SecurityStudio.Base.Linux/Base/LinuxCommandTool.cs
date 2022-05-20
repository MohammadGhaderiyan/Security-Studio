using System.Threading.Tasks;
using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Base.Linux.Ssh;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Linux.Base
{
    public abstract class LinuxCommandTool : CommandTool
    {
        public LinuxOperatingSystem LinuxOperatingSystem { get; set; }
        private readonly SshLinuxTool _sshLinuxTool;

        public LinuxCommandTool(string name, string commandName,
            LinuxOperatingSystem linuxOperatingSystem) : base(name, commandName)
        {
            LinuxOperatingSystem = linuxOperatingSystem;
            _sshLinuxTool = new SshLinuxTool(linuxOperatingSystem);
        }

        public async Task<Result<string>> RunCommand(string arguments)
        {
            return await _sshLinuxTool.RunCommand($"{CommandName} {arguments}");
        }
    }
}