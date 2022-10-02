using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Suricata.ViewModel
{
    public class SsSuricataViewModel : SsViewModel
    {
        public SsCommand SsShowSuricataCommand { get; set; }
        public SsCommand SsOpenSuricataCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSuricataCommand = new SsCommand(SsShowSuricata);
            SsOpenSuricataCommand = new SsCommand(SsOpenSuricata);
        }

        private void SsShowSuricata(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSuricata(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Suricata";
            Uri = _uriAddress = "https://suricata.io/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}