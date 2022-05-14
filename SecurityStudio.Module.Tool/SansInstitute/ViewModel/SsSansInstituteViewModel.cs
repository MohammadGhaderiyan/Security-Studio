using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.SansInstitute.ViewModel
{
    public class SsSansInstituteViewModel : SsViewModel
    {
        public SsCommand SsShowSansInstituteCommand { get; set; }
        public SsCommand SsOpenSansInstituteCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSansInstituteCommand = new SsCommand(SsShowSansInstitute);
            SsOpenSansInstituteCommand = new SsCommand(SsOpenSansInstitute);
        }

        private void SsShowSansInstitute(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenSansInstitute(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "SANS Institute";
            _url = "https://www.sans.org/";
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
                SsShowSansInstitute(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}