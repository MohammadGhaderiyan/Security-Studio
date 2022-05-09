using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Kernel
{
    public class KernelWindowsTool : WindowsTool
    {
        public KernelWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
            : base(windowsOperatingSystem)
        {
        }

        public async Task<string> RunCliCommand(string filePath, string arguments = null)
        {
            var command = Cli.Wrap(filePath)
                .WithArguments(arguments ?? "");

            return (await command.ExecuteBufferedAsync()).StandardOutput;
        }
    }
}