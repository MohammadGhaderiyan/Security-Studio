using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.IntelX.ViewModel
{
    public class SsIntelXViewModel : SsViewModel
    {
        public SsCommand SsShowIntelXCommand { get; set; }
        public SsCommand SsOpenIntelXCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowIntelXCommand = new SsCommand(SsShowIntelX);
            SsOpenIntelXCommand = new SsCommand(SsOpenIntelX);
        }

        private void SsShowIntelX(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenIntelX(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "IntelX";
            Uri = _uriAddress = "https://intelx.io/";
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