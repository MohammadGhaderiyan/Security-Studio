using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.BurpSuite.ViewModel
{
    public class SsBurpSuiteViewModel : SsViewModel
    {
        public SsCommand SsShowBurpSuiteCommand { get; set; }
        public SsCommand SsOpenBurpSuiteCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowBurpSuiteCommand = new SsCommand(SsShowBurpSuite);
            SsOpenBurpSuiteCommand = new SsCommand(SsOpenBurpSuite);
        }

        private void SsShowBurpSuite(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenBurpSuite(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Burp Suite";
            Uri = _uriAddress = "https://portswigger.net/burp/";
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