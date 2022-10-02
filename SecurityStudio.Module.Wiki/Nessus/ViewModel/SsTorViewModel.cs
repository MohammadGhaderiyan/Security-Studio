using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Nessus.ViewModel
{
    public class SsNessusViewModel : SsViewModel
    {
        public SsCommand SsShowNessusCommand { get; set; }
        public SsCommand SsOpenNessusCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowNessusCommand = new SsCommand(SsShowNessus);
            SsOpenNessusCommand = new SsCommand(SsOpenNessus);
        }

        private void SsShowNessus(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenNessus(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Nessus";
            Uri = _uriAddress = "https://www.tenable.com/products/nessus/";
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