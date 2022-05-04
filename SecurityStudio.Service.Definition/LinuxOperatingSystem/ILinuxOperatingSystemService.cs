using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Definition.LinuxOperatingSystem
{
    public interface ILinuxOperatingSystemService : IService
    {
        List<Database.Model.Definition.LinuxOperatingSystem> GetLinuxOperatingSystems();
        Database.Model.Definition.LinuxOperatingSystem GetLinuxOperatingSystem(int linuxOperatingSystemId);
        void Save(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem);
        void Delete(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem);
        bool IsValid(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem);
    }
}