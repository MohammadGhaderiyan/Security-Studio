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
            Result = _arpWindowsTool.GetArpEntries().Result;
        }

        private void SsHelp(object parameter)
        {
            Result = _arpWindowsTool.Help().Result;
        }

        private ArpWindowsTool _arpWindowsTool;

        protected override void PrepareVariables()
        {
            Title = "Arp";
            _arpWindowsTool = new ArpWindowsTool(_sessionService.WindowsOperatingSystem);
        }

        protected override void FillData()
        {
        }

        private string _Result;
        public string Result
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