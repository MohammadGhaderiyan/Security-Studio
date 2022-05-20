using SecurityStudio.Base.Main.Common;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Windows.Arp;
using SecurityStudio.Service.Main.Session;

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

        private void SsGetArpEntries(object parameter)
        {
            Result = await _arpWindowsCommandTool.GetArpEntries();
        }

        private void SsHelp(object parameter)
        {
            Result = _arpWindowsCommandTool.Help().Result;
        }

        private ArpWindowsCommandTool _arpWindowsCommandTool;

        protected override void PrepareVariables()
        {
            Title = "Arp";
            _arpWindowsTool = new ArpWindowsTool(_sessionService.WindowsOperatingSystem);
        }

        protected override void FillData()
        {
        }

        private Result _Result;
        public Result Result
        {
            get => _Result;
            set
            {
                _Result = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}