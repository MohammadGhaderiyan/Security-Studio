using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Osint.SocialSearcher.ViewModel
{
    public class SsSocialSearcherViewModel : SsViewModel
    {
        public SsCommand SsShowSocialSearcherCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSocialSearcherCommand = new SsCommand(SsShowSocialSearcher);
        }

        private void SsShowSocialSearcher(object parameter)
        {
            WebBrowser.Navigate("https://www.social-searcher.com/");
        }

        protected override void PrepareVariables()
        {
            Title = "Social Searcher";
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