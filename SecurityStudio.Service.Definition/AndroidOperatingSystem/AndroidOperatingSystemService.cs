using SecurityStudio.Service.Base.Repository;

namespace SecurityStudio.Service.Definition.AndroidOperatingSystem
{
    public class AndroidOperatingSystemService : LiteDbRepositoryService<Database.Model.Definition.AndroidOperatingSystem>,
        IAndroidOperatingSystemService
    {
        private readonly IRepositoryService<Database.Model.Definition.AndroidOperatingSystem> _androidOperatingSystemRepositoryService;

        public AndroidOperatingSystemService(
            IRepositoryService<Database.Model.Definition.AndroidOperatingSystem> androidOperatingSystemDatabaseService)
        {
            _androidOperatingSystemRepositoryService = androidOperatingSystemDatabaseService;
        }

        public bool IsValid(Database.Model.Definition.AndroidOperatingSystem androidOperatingSystem)
        {
            return true;
        }
    }
}