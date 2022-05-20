using SecurityStudio.Base.Linux.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Linux.Utility
{
    public class UtilityLinuxTool : LinuxTool
    {
        public UtilityLinuxTool(LinuxOperatingSystem linuxOperatingSystem)
            : base("Utility", linuxOperatingSystem)
        {
        }
    }
}