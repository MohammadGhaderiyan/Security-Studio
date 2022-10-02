using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.SecurityTrails.ViewModel
{
    public class SsSecurityTrailsViewModel : SsViewModel
    {
        public SsCommand SsShowSecurityTrailsCommand { get; set; }
        public SsCommand SsOpenSecurityTrailsCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSecurityTrailsCommand = new SsCommand(SsShowSecurityTrails);
            SsOpenSecurityTrailsCommand = new SsCommand(SsOpenSecurityTrails);
        }

        private void SsShowSecurityTrails(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSecurityTrails(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Security Trails";
            Uri = _uriAddress = "https://securitytrails.com/";
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