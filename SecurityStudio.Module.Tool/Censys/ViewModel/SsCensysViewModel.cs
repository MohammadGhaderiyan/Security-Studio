using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Censys.ViewModel
{
    public class SsCensysViewModel : SsViewModel
    {
        public SsCommand SsShowCensysCommand { get; set; }
        public SsCommand SsOpenCensysCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCensysCommand = new SsCommand(SsShowCensys);
            SsOpenCensysCommand = new SsCommand(SsOpenCensys);
        }

        private void SsShowCensys(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenCensys(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Censys";
            _url = "https://censys.io/";
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
                SsShowCensys(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}