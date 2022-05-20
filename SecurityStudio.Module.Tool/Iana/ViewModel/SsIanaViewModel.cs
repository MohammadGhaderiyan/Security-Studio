using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Iana.ViewModel
{
    public class SsIanaViewModel : SsViewModel
    {
        public SsCommand SsShowRipeCommand { get; set; }
        public SsCommand SsShowArinCommand { get; set; }
        public SsCommand SsShowAfrinicCommand { get; set; }
        public SsCommand SsShowApnicCommand { get; set; }
        public SsCommand SsShowLacnicCommand { get; set; }
        public SsCommand SsOpenRipeCommand { get; set; }
        public SsCommand SsOpenArinCommand { get; set; }
        public SsCommand SsOpenAfrinicCommand { get; set; }
        public SsCommand SsOpenApnicCommand { get; set; }
        public SsCommand SsOpenLacnicCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowRipeCommand = new SsCommand(SsShowRipe);
            SsShowArinCommand = new SsCommand(SsShowArin);
            SsShowAfrinicCommand = new SsCommand(SsShowAfrinic);
            SsShowApnicCommand = new SsCommand(SsShowApnic);
            SsShowLacnicCommand = new SsCommand(SsShowLacnic);
            SsOpenRipeCommand = new SsCommand(SsOpenRipe);
            SsOpenArinCommand = new SsCommand(SsOpenArin);
            SsOpenAfrinicCommand = new SsCommand(SsOpenAfrinic);
            SsOpenApnicCommand = new SsCommand(SsOpenApnic);
            SsOpenLacnicCommand = new SsCommand(SsOpenLacnic);
        }

        private void SsShowRipe(object parameter)
        {
            WebBrowser.Navigate(_ripeUrl);
        }

        private void SsShowArin(object parameter)
        {
            WebBrowser.Navigate(_arinUrl);
        }

        private void SsShowAfrinic(object parameter)
        {
            WebBrowser.Navigate(_afrinicUrl);
        }

        private void SsShowApnic(object parameter)
        {
            WebBrowser.Navigate(_apnicUrl);
        }

        private void SsShowLacnic(object parameter)
        {
            WebBrowser.Navigate(_lacnicUrl);
        }

        private void SsOpenRipe(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_ripeUrl);
        }

        private void SsOpenArin(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_arinUrl);
        }

        private void SsOpenAfrinic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_afrinicUrl);
        }

        private void SsOpenApnic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_apnicUrl);
        }

        private void SsOpenLacnic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_lacnicUrl);
        }

        private string _ripeUrl;
        private string _arinUrl;
        private string _afrinicUrl;
        private string _apnicUrl;
        private string _lacnicUrl;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "IANA";
            _ripeUrl = "https://www.ripe.net/";
            _arinUrl = "https://www.arin.net/";
            _afrinicUrl = "https://afrinic.net/";
            _apnicUrl = "https://www.apnic.net/";
            _lacnicUrl = "https://www.lacnic.net/";
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
                SsShowRipe(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}