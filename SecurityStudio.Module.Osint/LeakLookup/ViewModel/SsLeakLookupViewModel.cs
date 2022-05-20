using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.LeakLookup.ViewModel
{
    public class SsLeakLookupViewModel : SsViewModel
    {
        public SsCommand SsShowLeakLookupCommand { get; set; }
        public SsCommand SsOpenLeakLookupCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowLeakLookupCommand = new SsCommand(SsShowLeakLookup);
            SsOpenLeakLookupCommand = new SsCommand(SsOpenLeakLookup);
        }

        private void SsShowLeakLookup(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenLeakLookup(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Leak-Lookup";
            _url = "https://leak-lookup.com/";
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
                SsShowLeakLookup(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}