using SecurityStudio.Base.Main.Ioc;
using SecurityStudio.Service.Definition.AndroidOperatingSystem;
using SecurityStudio.Service.Definition.LinuxOperatingSystem;
using SecurityStudio.Service.Definition.User;
using SecurityStudio.Service.Definition.WindowsOperatingSystem;

namespace SecurityStudio.Service.Definition
{
    public class SsDefinitionServiceModule : SsModule
    {
        public override void Load()
        {
            Bind<IAndroidOperatingSystemService>().To<AndroidOperatingSystemService>();
            Bind<ILinuxOperatingSystemService>().To<LinuxOperatingSystemService>();
            Bind<IUserService>().To<UserService>();
            Bind<IWindowsOperatingSystemService>().To<WindowsOperatingSystemService>();
        }
    }
}