using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Wappalyzer.ViewModel
{
    public class SsWappalyzerViewModel : SsViewModel
    {
        public SsCommand SsShowWappalyzerCommand { get; set; }
        public SsCommand SsOpenWappalyzerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowWappalyzerCommand = new SsCommand(SsShowWappalyzer);
            SsOpenWappalyzerCommand = new SsCommand(SsOpenWappalyzer);
        }

        private void SsShowWappalyzer(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenWappalyzer(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Wappalyzer";
            Uri = _uriAddress = "https://www.wappalyzer.com/";
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