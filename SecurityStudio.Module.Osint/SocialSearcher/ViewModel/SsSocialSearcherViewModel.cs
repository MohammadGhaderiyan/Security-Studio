using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.SocialSearcher.ViewModel
{
    public class SsSocialSearcherViewModel : SsViewModel
    {
        public SsCommand SsShowSocialSearcherCommand { get; set; }
        public SsCommand SsOpenSocialSearcherCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSocialSearcherCommand = new SsCommand(SsShowSocialSearcher);
            SsOpenSocialSearcherCommand = new SsCommand(SsOpenSocialSearcher);
        }

        private void SsShowSocialSearcher(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenSocialSearcher(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Social Searcher";
            _url = "https://www.social-searcher.com/";
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
                SsShowSocialSearcher(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}