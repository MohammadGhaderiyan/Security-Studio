using Ninject;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Service.Main.Session
{
    public class SessionService : ISessionService
    {
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

        public void Dispose()
        {
            //WindsorContainer?.Dispose();
        }
    }
}