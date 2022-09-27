using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Windows.Arp;
using SecurityStudio.Service.Base.Session;

namespace SecurityStudio.Module.Windows.Arp.ViewModel
{
    public class SsArpViewModel : SsViewModel
    {
        private readonly ISessionService _sessionService;

        public SsArpViewModel(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public SsCommand SsGetArpEntriesCommand { get; set; }
        public SsCommand SsHelpCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsGetArpEntriesCommand = new SsCommand(SsGetArpEntries);
            SsHelpCommand = new SsCommand(SsHelp);
        }

        private async void SsGetArpEntries(object parameter)
        {
            SsResult = await _arpWindowsCommandTool.GetArpEntries();
        }

        private async void SsHelp(object parameter)
        {
            SsResult = await _arpWindowsCommandTool.GetHelp();
        }

        private ArpWindowsCommandTool _arpWindowsCommandTool;

        protected override void PrepareVariables()
        {
            Title = "Arp";
            _arpWindowsCommandTool = new ArpWindowsCommandTool(_sessionService.WindowsOperatingSystem);
        }

        protected override void FillData()
        {
        }

        private SsResult _ssResult;
        public SsResult SsResult
        {
            get => _ssResult;
            set
            {
                _ssResult = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}