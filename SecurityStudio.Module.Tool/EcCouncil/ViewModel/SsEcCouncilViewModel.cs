using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.EcCouncil.ViewModel
{
    public class SsEcCouncilViewModel : SsViewModel
    {
        public SsCommand SsShowEcCouncilCommand { get; set; }
        public SsCommand SsOpenEcCouncilCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowEcCouncilCommand = new SsCommand(SsShowEcCouncil);
            SsOpenEcCouncilCommand = new SsCommand(SsOpenEcCouncil);
        }

        private void SsShowEcCouncil(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenEcCouncil(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "EC-Council";
            _url = "https://www.eccouncil.org/";
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
                SsShowEcCouncil(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}