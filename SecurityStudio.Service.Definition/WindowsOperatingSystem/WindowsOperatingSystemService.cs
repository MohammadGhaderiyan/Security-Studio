using SecurityStudio.Service.Base.Repository;

namespace SecurityStudio.Service.Definition.WindowsOperatingSystem
{
    public class WindowsOperatingSystemService : IWindowsOperatingSystemService
    {
        private readonly IRepositoryService<Database.Model.Definition.WindowsOperatingSystem> _windowsOperatingSystemRepositoryService;

        public WindowsOperatingSystemService(IRepositoryService<Database.Model.Definition.WindowsOperatingSystem> windowsOperatingSystemRepositoryService)
        {
            _windowsOperatingSystemRepositoryService = windowsOperatingSystemRepositoryService;
        }

        public List<Database.Model.Definition.WindowsOperatingSystem> GetWindowsOperatingSystems()
        {
            return _windowsOperatingSystemRepositoryService.GetAll().ToList();
        }

        public Database.Model.Definition.WindowsOperatingSystem GetWindowsOperatingSystem(int windowsOperatingSystemId)
        {
            return _windowsOperatingSystemRepositoryService.Find(windowsOperatingSystemId);
        }

        public void Save(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem)
        {
            if (windowsOperatingSystem.Id == 0)
                _windowsOperatingSystemRepositoryService.Add(windowsOperatingSystem);

            _windowsOperatingSystemRepositoryService.Save();
        }

        public void Delete(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem)
        {
            _windowsOperatingSystemRepositoryService.Remove(windowsOperatingSystem);
            _windowsOperatingSystemRepositoryService.Save();
        }

        public bool IsValid(Database.Model.Definition.WindowsOperatingSystem windowsOperatingSystem)
        {
            return true;
        }

        public void Dispose()
        {
            _windowsOperatingSystemRepositoryService?.Dispose();
        }
    }
}