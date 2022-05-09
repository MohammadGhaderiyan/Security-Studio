using System.Threading.Tasks;
using Rebex.Net;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Linux
{
    public class LinuxEngine
    {
        private readonly LinuxOperatingSystem _linuxOperatingSystem;
        private readonly Ssh _ssh;

        public LinuxEngine(LinuxOperatingSystem linuxOperatingSystem)
        {
            _linuxOperatingSystem = linuxOperatingSystem;
            _ssh = new Ssh();
        }

        public async Task<string> GetCommand(string command)
        {
            if (_ssh.IsConnected == false)
                _ssh.Connect(_linuxOperatingSystem.Ip, 22);

            var shell = await _ssh.StartCommandAsync(command);

            return shell.ReadAll();
        }

    }
}