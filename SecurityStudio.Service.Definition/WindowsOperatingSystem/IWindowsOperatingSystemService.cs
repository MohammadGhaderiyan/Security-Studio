using SecurityStudio.Base.Main.Service;

namespace SecurityStudio.Service.Definition.WindowsOperatingSystem
{
    public interface IWindowsOperatingSystemService : IService
    {
        List<Database.Model.Definition.WindowsOperatingSystem> GetWindowsOperatingSystems();
        Database.Model.Definition.WindowsOperatingSystem GetWindowsOperatingSystem(int windowsOperatingSystemId);
        void Save(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem);
        void Delete(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem);
        bool IsValid(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem);
    }
}