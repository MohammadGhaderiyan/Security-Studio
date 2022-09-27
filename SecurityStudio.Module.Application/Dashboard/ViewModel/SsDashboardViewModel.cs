using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Service.Base.Session;

namespace SecurityStudio.Module.Application.Dashboard.ViewModel
{
    public class SsDashboardViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;

        public SsDashboardViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Dashboard";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}