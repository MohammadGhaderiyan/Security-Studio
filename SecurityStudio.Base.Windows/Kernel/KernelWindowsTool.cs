using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Windows.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Kernel
{
    public class KernelWindowsTool : WindowsTool
    {
        public KernelWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
            : base("Kernel", windowsOperatingSystem)
        {
        }

        public async Task<Result<string>> RunCliCommand(string filePath, string arguments = null)
        {
            try
            {
                var command = Cli.Wrap(filePath)
                    .WithArguments(arguments ?? "");

                var result = (await command.ExecuteBufferedAsync()).StandardOutput;
                return new Result<string>(result);

            }
            catch (System.Exception exception)
            {
                return new Result<string>(exception);
            }
        }
    }
}