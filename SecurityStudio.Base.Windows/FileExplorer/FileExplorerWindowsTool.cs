using SecurityStudio.Base.Windows.Base;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Base.Windows.FileExplorer
{
    public class FileExplorerWindowsTool : WindowsTool
    {
        public FileExplorerWindowsTool(WindowsOperatingSystem windowsOperatingSystem)
            : base("File Explorer", windowsOperatingSystem)
        {
        }
    }
}