using SecurityStudio.Base.Main.Tool;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Linux.Base
{
    public abstract class LinuxTool : Tool
    {
        public LinuxOperatingSystem LinuxOperatingSystem { get; set; }

        public LinuxTool(string name,
            LinuxOperatingSystem linuxOperatingSystem) : base(name)
        {
            LinuxOperatingSystem = linuxOperatingSystem;
        }
    }
}