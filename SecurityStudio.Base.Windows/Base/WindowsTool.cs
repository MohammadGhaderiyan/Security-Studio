using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.Base
{
    public abstract class WindowsTool : Tool
    {
        public WindowsOperatingSystem WindowsOperatingSystem { get; set; }

        public WindowsTool(string name, 
            WindowsOperatingSystem windowsOperatingSystem) : base(name)
        {
            WindowsOperatingSystem = windowsOperatingSystem;
        }
    }
}