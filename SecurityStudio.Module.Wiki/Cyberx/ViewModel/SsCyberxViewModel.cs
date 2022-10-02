using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Cyberx.ViewModel
{
    public class SsCyberxViewModel : SsViewModel
    {
        public SsCommand SsShowCyberxCommand { get; set; }
        public SsCommand SsOpenCyberxCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCyberxCommand = new SsCommand(SsShowCyberx);
            SsOpenCyberxCommand = new SsCommand(SsOpenCyberx);
        }

        private void SsShowCyberx(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenCyberx(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Cyberx";
            Uri = _uriAddress = "https://cyberx-labs.com/";
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