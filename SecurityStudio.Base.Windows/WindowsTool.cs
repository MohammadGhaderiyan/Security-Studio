using System.Threading.Tasks;
using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Base.Windows.Kernel;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows
{
    public class WindowsTool : Tool
    {
        public WindowsOperatingSystem WindowsOperatingSystem { get; set; }
        public KernelWindowsTool KernelWindowsTool { get; set; }

        public WindowsTool(WindowsOperatingSystem windowsOperatingSystem) : base(true, false)
        {
            WindowsOperatingSystem = windowsOperatingSystem;
            KernelWindowsTool = new KernelWindowsTool(windowsOperatingSystem);
        }

        public override Task<string> RunCommand(string arguments = null)
        {
            return KernelWindowsTool.RunCliCommand(CommandName, arguments);
        }
    }
}