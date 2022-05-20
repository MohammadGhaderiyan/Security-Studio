using System.Threading.Tasks;
using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Base.Windows.Kernel;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Base
{
    public abstract class WindowsCommandTool : CommandTool
    {
        public WindowsOperatingSystem WindowsOperatingSystem { get; set; }
        private readonly KernelWindowsTool _kernelWindowsTool;

        public WindowsCommandTool(string name, string commandName,
            WindowsOperatingSystem windowsOperatingSystem) : base(name, commandName)
        {
            WindowsOperatingSystem = windowsOperatingSystem;
            _kernelWindowsTool = new KernelWindowsTool(windowsOperatingSystem);
        }

        public async Task<Result<string>> RunCommand(string arguments)
        {
            return await _kernelWindowsTool.RunCliCommand(CommandName, arguments);
        }
    }
}