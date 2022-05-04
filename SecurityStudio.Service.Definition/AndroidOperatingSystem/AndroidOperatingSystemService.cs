using SecurityStudio.Service.Main.Repository;

namespace SecurityStudio.Service.Definition.AndroidOperatingSystem
{
    public class AndroidOperatingSystemService : IAndroidOperatingSystemService
    {
        private readonly IRepositoryService<Database.Model.Definition.AndroidOperatingSystem> _androidOperatingSystemRepositoryService;

        public AndroidOperatingSystemService(
            IRepositoryService<Database.Model.Definition.AndroidOperatingSystem> androidOperatingSystemDatabaseService)
        {
            _androidOperatingSystemRepositoryService = androidOperatingSystemDatabaseService;
        }

        public List<Database.Model.Definition.AndroidOperatingSystem> GetAndroidOperatingSystems()
        {
            return _androidOperatingSystemRepositoryService.GetAll().ToList();
        }

        public Database.Model.Definition.AndroidOperatingSystem GetAndroidOperatingSystem(int androidOperatingSystemId)
        {
            return _androidOperatingSystemRepositoryService.Find(androidOperatingSystemId);
        }

        public void Save(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem)
        {
            if (androidOperatingSystem.Id == 0)
                _androidOperatingSystemRepositoryService.Add(androidOperatingSystem);

            _androidOperatingSystemRepositoryService.Save();
        }

        public void Delete(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem)
        {
            _androidOperatingSystemRepositoryService.Remove(androidOperatingSystem);
            _androidOperatingSystemRepositoryService.Save();
        }

        public bool IsValid(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem)
        {
            return true;
        }

        public void Dispose()
        {
            _androidOperatingSystemRepositoryService?.Dispose();
        }
    }
}