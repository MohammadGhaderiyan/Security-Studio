using SecurityStudio.Base.Main.Ioc;
using SecurityStudio.Database.Model.Infrastructure;
using SecurityStudio.Service.Main.Clipboard;
using SecurityStudio.Service.Main.Container;
using SecurityStudio.Service.Main.DateTime;
using SecurityStudio.Service.Main.Directory;
using SecurityStudio.Service.Main.Dock;
using SecurityStudio.Service.Main.File;
using SecurityStudio.Service.Main.Log;
using SecurityStudio.Service.Main.MessageBox;
using SecurityStudio.Service.Main.Parameter;
using SecurityStudio.Service.Main.Parser;
using SecurityStudio.Service.Main.Repository;
using SecurityStudio.Service.Main.Session;
using SecurityStudio.Service.Main.Text;
using SecurityStudio.Service.Main.Tunnel;
using SecurityStudio.Service.Main.Utility;
using SecurityStudio.Service.Main.Window;

namespace SecurityStudio.Service.Main
{
    public class SsMainServiceModule : SsModule
    {
        public override void Load()
        {
            Bind<IClipboardService>().To<ClipboardService>();
            Bind<IContainerService>().To<ContainerService>();
            Bind<IDateTimeService>().To<DateTimeService>();
            Bind<IDirectoryService>().To<DirectoryService>();
            Bind<IDockService>().To<DockService>();
            Bind<IFileService>().To<FileService>();
            Bind<ILogService>().To<LogService>();
            Bind<IMessageBoxService>().To<MessageBoxService>();
            Bind<IParameterService>().To<ParameterService>().InSingletonScope();
            Bind<IParserService>().To<ParserService>();
            Bind(typeof(IRepositoryService<>)).To(typeof(LiteDbRepositoryService<>));
            Bind<ISessionService>().To<SessionService>().InSingletonScope();
            Bind<ITextService>().To<TextService>();
            Bind<ITunnelService>().To<TunnelService>().InSingletonScope();
            Bind<IUtilityService>().To<UtilityService>();
            Bind<IWindowService>().To<WindowService>();
        }
    }
}