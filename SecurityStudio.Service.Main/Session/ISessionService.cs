using Ninject;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Database.Model.Definition;

namespace SecurityStudio.Service.Main.Session
{
    public interface ISessionService : IService
    {
        User User { get; }
        WindowsOperatingSystem WindowsOperatingSystem { get; }
        LinuxOperatingSystem LinuxOperatingSystem { get; }
        AndroidOperatingSystem AndroidOperatingSystem { get; }
        IKernel Kernel { get; }
        void SetUser(User user);
        void SetWindowsOperatingSystem(WindowsOperatingSystem windowsOperatingSystem);
        void SetLinuxOperatingSystem(LinuxOperatingSystem linuxOperatingSystem);
        void SetAndroidOperatingSystem(AndroidOperatingSystem androidOperatingSystem);
        void SetKernel(IKernel kernel);
        void ExitFromApplication();
        List<AndroidOperatingSystem> GetAndroidOperatingSystems();
        List<LinuxOperatingSystem> GetLinuxOperatingSystems();
        List<WindowsOperatingSystem> GetWindowsOperatingSystems();
    }
}