using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Module.Linux.Terminal.ViewModel
{
    public class SsTerminalViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;

        public SsTerminalViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Terminal";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}