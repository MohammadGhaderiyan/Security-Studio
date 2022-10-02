using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.IbmAppScan.ViewModel
{
    public class SsIbmAppScanViewModel : SsViewModel
    {
        public SsCommand SsShowIbmAppScanCommand { get; set; }
        public SsCommand SsOpenIbmAppScanCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowIbmAppScanCommand = new SsCommand(SsShowIbmAppScan);
            SsOpenIbmAppScanCommand = new SsCommand(SsOpenIbmAppScan);
        }

        private void SsShowIbmAppScan(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenIbmAppScan(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "IBM AppScan";
            Uri = _uriAddress = "https://www.ibm.com/docs/en/dsm?topic=guide-appscan-enterprise-scanner-overview/";
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