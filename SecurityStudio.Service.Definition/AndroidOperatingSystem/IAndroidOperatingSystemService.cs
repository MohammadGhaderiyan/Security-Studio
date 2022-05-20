using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Service.Definition.AndroidOperatingSystem
{
    public interface IAndroidOperatingSystemService : IService
    {
        List<Database.Model.Definition.AndroidOperatingSystem> GetAndroidOperatingSystems();
        Database.Model.Definition.AndroidOperatingSystem GetAndroidOperatingSystem(int androidOperatingSystemId);
        Task<Result> Save(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
        void Delete(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
        bool IsValid(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem);
    }
}