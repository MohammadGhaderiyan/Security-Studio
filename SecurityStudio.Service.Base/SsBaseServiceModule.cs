using SecurityStudio.Base.Main.Ioc;
using SecurityStudio.Service.Base.Clipboard;
using SecurityStudio.Service.Base.Container;
using SecurityStudio.Service.Base.DateTime;
using SecurityStudio.Service.Base.Directory;
using SecurityStudio.Service.Base.Dock;
using SecurityStudio.Service.Base.File;
using SecurityStudio.Service.Base.Log;
using SecurityStudio.Service.Base.MessageBox;
using SecurityStudio.Service.Base.Parameter;
using SecurityStudio.Service.Base.Parser;
using SecurityStudio.Service.Base.Repository;
using SecurityStudio.Service.Base.Session;
using SecurityStudio.Service.Base.Text;
using SecurityStudio.Service.Base.Tunnel;
using SecurityStudio.Service.Base.Utility;
using SecurityStudio.Service.Base.Window;

namespace SecurityStudio.Service.Base
{
    public class SsBaseServiceModule : SsModule
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