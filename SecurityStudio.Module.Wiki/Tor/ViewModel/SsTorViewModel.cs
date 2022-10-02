using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Tor.ViewModel
{
    public class SsTorViewModel : SsViewModel
    {
        public SsCommand SsShowTorCommand { get; set; }
        public SsCommand SsOpenTorCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowTorCommand = new SsCommand(SsShowTor);
            SsOpenTorCommand = new SsCommand(SsOpenTor);
        }

        private void SsShowTor(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenTor(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Tor";
            Uri = _uriAddress = "https://www.torproject.org/";
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