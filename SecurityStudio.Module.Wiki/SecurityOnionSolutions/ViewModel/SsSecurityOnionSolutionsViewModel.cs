using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.SecurityOnionSolutions.ViewModel
{
    public class SsSecurityOnionSolutionsViewModel : SsViewModel
    {
        public SsCommand SsShowSecurityOnionSolutionsCommand { get; set; }
        public SsCommand SsOpenSecurityOnionSolutionsCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSecurityOnionSolutionsCommand = new SsCommand(SsShowSecurityOnionSolutions);
            SsOpenSecurityOnionSolutionsCommand = new SsCommand(SsOpenSecurityOnionSolutions);
        }

        private void SsShowSecurityOnionSolutions(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSecurityOnionSolutions(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Security Onion Solutions";
            Uri = _uriAddress = "https://securityonionsolutions.com/";
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