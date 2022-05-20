using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.GitHub.ViewModel
{
    public class SsGitHubViewModel : SsViewModel
    {
        public SsCommand SsShowGitHubCommand { get; set; }
        public SsCommand SsOpenGitHubCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowGitHubCommand = new SsCommand(SsShowGitHub);
            SsOpenGitHubCommand = new SsCommand(SsOpenGitHub);
        }

        private void SsShowGitHub(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenGitHub(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "GitHub";
            Uri = _uriAddress = "https://github.com/";
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