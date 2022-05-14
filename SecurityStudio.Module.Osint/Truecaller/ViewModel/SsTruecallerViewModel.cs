using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.Truecaller.ViewModel
{
    public class SsTruecallerViewModel : SsViewModel
    {
        public SsCommand SsShowTruecallerCommand { get; set; }
        public SsCommand SsOpenTruecallerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowTruecallerCommand = new SsCommand(SsShowTruecaller);
            SsOpenTruecallerCommand = new SsCommand(SsOpenTruecaller);
        }

        private void SsShowTruecaller(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenTruecaller(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Truecaller";
            _url = "https://www.truecaller.com/";
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
                SsShowTruecaller(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}