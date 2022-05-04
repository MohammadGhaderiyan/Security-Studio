using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Definition.AndroidOperatingSystem
{
    public interface IAndroidOperatingSystemService : IService
    {
        List<Database.Model.Definition.AndroidOperatingSystem> GetAndroidOperatingSystems();
        Database.Model.Definition.AndroidOperatingSystem GetAndroidOperatingSystem(int androidOperatingSystemId);
        void Save(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
        void Delete(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
        bool IsValid(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
    }
}