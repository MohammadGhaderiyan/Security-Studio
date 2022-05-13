using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Censys.ViewModel
{
    public class SsCensysViewModel : SsViewModel
    {
        public SsCommand SsShowCensysCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCensysCommand = new SsCommand(SsShowCensys);
        }

        private void SsShowCensys(object parameter)
        {
            WebBrowser.Navigate("https://censys.io/");
        }

        protected override void PrepareVariables()
        {
            Title = "Censys";
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
                SsShowCensys(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}