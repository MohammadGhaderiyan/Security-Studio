using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Afta.ViewModel
{
    public class SsAftaViewModel : SsViewModel
    {
        public SsCommand SsShowAftaCommand { get; set; }
        public SsCommand SsOpenAftaCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowAftaCommand = new SsCommand(SsShowAfta);
            SsOpenAftaCommand = new SsCommand(SsOpenAfta);
        }

        private void SsShowAfta(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenAfta(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "AFTA";
            _url = "https://sec.ito.gov.ir/";
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
                SsShowAfta(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}