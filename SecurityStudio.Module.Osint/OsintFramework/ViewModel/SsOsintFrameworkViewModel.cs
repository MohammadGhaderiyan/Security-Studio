using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.OsintFramework.ViewModel
{
    public class SsOsintFrameworkViewModel : SsViewModel
    {
        public SsCommand SsShowOsintFrameworkCommand { get; set; }
        public SsCommand SsOpenOsintFrameworkCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOsintFrameworkCommand = new SsCommand(SsShowOsintFramework);
            SsOpenOsintFrameworkCommand = new SsCommand(SsOpenOsintFramework);
        }

        private void SsShowOsintFramework(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenOsintFramework(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = " OSINT Framework";
            _url = "https://osintframework.com/";
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
                SsShowOsintFramework(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}