using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows
{
    public class WindowsTool : Tool
    {
        public WindowsOperatingSystem WindowsOperatingSystem { get; set; }

        public WindowsTool(WindowsOperatingSystem windowsOperatingSystem) : base(true, false)
        {
            WindowsOperatingSystem = windowsOperatingSystem;
        }

        public override async Task<string> RunCommand(string arguments = null)
        {
            var command = Cli.Wrap(CommandName)
                .WithArguments(arguments ?? "");

            return (await command.ExecuteBufferedAsync()).StandardOutput;
        }
    }
}