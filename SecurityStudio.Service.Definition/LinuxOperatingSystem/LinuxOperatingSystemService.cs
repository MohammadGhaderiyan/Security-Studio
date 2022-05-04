using SecurityStudio.Service.Main.Repository;

namespace SecurityStudio.Service.Definition.LinuxOperatingSystem
{
    public class LinuxOperatingSystemService : ILinuxOperatingSystemService
    {
        private readonly IRepositoryService<Database.Model.Definition.LinuxOperatingSystem> _linuxOperatingSystemRepositoryService;

        public LinuxOperatingSystemService(IRepositoryService<Database.Model.Definition.LinuxOperatingSystem> linuxOperatingSystemRepositoryService)
        {
            _linuxOperatingSystemRepositoryService = linuxOperatingSystemRepositoryService;
        }

        public List<Database.Model.Definition.LinuxOperatingSystem> GetLinuxOperatingSystems()
        {
            return _linuxOperatingSystemRepositoryService.GetAll().ToList();
        }

        public Database.Model.Definition.LinuxOperatingSystem GetLinuxOperatingSystem(int linuxOperatingSystemId)
        {
            return _linuxOperatingSystemRepositoryService.Find(linuxOperatingSystemId);
        }

        public void Save(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem)
        {
            if (linuxOperatingSystem.Id == 0)
                _linuxOperatingSystemRepositoryService.Add(linuxOperatingSystem);

            _linuxOperatingSystemRepositoryService.Save();
        }

        public void Delete(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem)
        {
            _linuxOperatingSystemRepositoryService.Remove(linuxOperatingSystem);
            _linuxOperatingSystemRepositoryService.Save();
        }

        public bool IsValid(Database.Model.Definition.LinuxOperatingSystem linuxOperatingSystem)
        {
            return true;
        }

        public void Dispose()
        {
            _linuxOperatingSystemRepositoryService?.Dispose();
        }
    }
}