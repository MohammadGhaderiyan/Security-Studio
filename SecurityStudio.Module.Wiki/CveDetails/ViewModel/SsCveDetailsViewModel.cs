using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.CveDetails.ViewModel
{
    public class SsCveDetailsViewModel : SsViewModel
    {
        public SsCommand SsShowCveDetailsCommand { get; set; }
        public SsCommand SsOpenCveDetailsCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCveDetailsCommand = new SsCommand(SsShowCveDetails);
            SsOpenCveDetailsCommand = new SsCommand(SsOpenCveDetails);
        }

        private void SsShowCveDetails(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenCveDetails(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "CVE Details";
            Uri = _uriAddress = "https://cvedetails.com/";
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