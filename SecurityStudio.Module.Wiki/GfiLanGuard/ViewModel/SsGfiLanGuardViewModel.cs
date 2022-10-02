using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.GfiLanGuard.ViewModel
{
    public class SsGfiLanGuardViewModel : SsViewModel
    {
        public SsCommand SsShowGfiLanGuardCommand { get; set; }
        public SsCommand SsOpenGfiLanGuardCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowGfiLanGuardCommand = new SsCommand(SsShowGfiLanGuard);
            SsOpenGfiLanGuardCommand = new SsCommand(SsOpenGfiLanGuard);
        }

        private void SsShowGfiLanGuard(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenGfiLanGuard(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "GFI LanGuard";
            Uri = _uriAddress = "https://www.gfi.com/products-and-solutions/network-security-solutions/languard/";
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