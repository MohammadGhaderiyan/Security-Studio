using System.Threading.Tasks;
using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Linux.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Linux.Ssh
{
    public class SshLinuxTool : LinuxTool
    {
        private readonly Rebex.Net.Ssh _ssh;

        public SshLinuxTool(LinuxOperatingSystem linuxOperatingSystem)
            : base("ssh", linuxOperatingSystem)
        {
            _ssh = new Rebex.Net.Ssh();
        }

        public async Task<SsResult<string>> RunCommand(string command)
        {
            try
            {
                if (_ssh.IsConnected == false)
                    await _ssh.ConnectAsync(LinuxOperatingSystem.Ip, 22);

                if (_ssh.IsAuthenticated)
                    await _ssh.LoginAsync(LinuxOperatingSystem.SshUserName, LinuxOperatingSystem.SshPassword);

                var shell = await _ssh.StartCommandAsync(command);

                return new SsResult<string>(shell.ReadAll());
            }
            catch (System.Exception exception)
            {
                return new SsResult<string>(exception);
            }
        }
    }
}