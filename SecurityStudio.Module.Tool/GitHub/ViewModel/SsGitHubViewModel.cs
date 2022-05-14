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
            WebBrowser.Navigate(_url);
        }

        private void SsOpenGitHub(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "GitHub";
            _url = "https://github.com/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private System.Windows.Controls.WebBrowser _webBrowser;
        public System.Windows.Controls.WebBrowser WebBrowser
        {
            get => _webBrowser;
            set
            {
                _webBrowser = value;
                SsShowGitHub(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}