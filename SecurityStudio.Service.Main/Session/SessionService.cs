using Ninject;
using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Service.Main.Repository;

namespace SecurityStudio.Service.Main.Session
{
    public class SessionService : ISessionService
    {
        private readonly IRepositoryService<AndroidOperatingSystem> _androidOperatingSystemRepositoryService;
        private readonly IRepositoryService<LinuxOperatingSystem> _linuxOperatingSystemRepositoryService;
        private readonly IRepositoryService<WindowsOperatingSystem> _windowsOperatingSystemRepositoryService;

        public SessionService(IRepositoryService<AndroidOperatingSystem> androidOperatingSystemRepositoryService,
            IRepositoryService<LinuxOperatingSystem> linuxOperatingSystemRepositoryService,
            IRepositoryService<WindowsOperatingSystem> windowsOperatingSystemRepositoryService)
        {
            _androidOperatingSystemRepositoryService = androidOperatingSystemRepositoryService;
            _linuxOperatingSystemRepositoryService = linuxOperatingSystemRepositoryService;
            _windowsOperatingSystemRepositoryService = windowsOperatingSystemRepositoryService;
        }

        public User User { get; private set; }
        public WindowsOperatingSystem WindowsOperatingSystem { get; private set; }
        public LinuxOperatingSystem LinuxOperatingSystem { get; private set; }
        public AndroidOperatingSystem AndroidOperatingSystem { get; private set; }
        public IKernel Kernel { get; private set; }

        public void SetUser(User user)
        {
            User = user;
        }

        public void SetWindowsOperatingSystem(WindowsOperatingSystem windowsOperatingSystem)
        {
            WindowsOperatingSystem = windowsOperatingSystem;
        }

        public void SetLinuxOperatingSystem(LinuxOperatingSystem linuxOperatingSystem)
        {
            LinuxOperatingSystem = linuxOperatingSystem;
        }

        public void SetAndroidOperatingSystem(AndroidOperatingSystem androidOperatingSystem)
        {
            AndroidOperatingSystem = androidOperatingSystem;
        }

        public void SetKernel(IKernel kernel)
        {
            Kernel = kernel;
        }

        public void ExitFromApplication()
        {
            System.Windows.Application.Current.Shutdown();
        }

        public List<AndroidOperatingSystem> GetAndroidOperatingSystems()
        {
            return _androidOperatingSystemRepositoryService.GetAll().OrderBy(item => item.Name).ToList();
        }

        public List<LinuxOperatingSystem> GetLinuxOperatingSystems()
        {
            return _linuxOperatingSystemRepositoryService.GetAll().OrderBy(item => item.Name).ToList();
        }

        public List<WindowsOperatingSystem> GetWindowsOperatingSystems()
        {
            return _windowsOperatingSystemRepositoryService.GetAll().OrderBy(item => item.Name).ToList();
        }

        public void Dispose()
        {
            //Kernel?.Dispose();
            _androidOperatingSystemRepositoryService?.Dispose();
            _linuxOperatingSystemRepositoryService?.Dispose();
            _windowsOperatingSystemRepositoryService?.Dispose();
        }
    }
}