using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Douran.ViewModel
{
    public class SsDouranViewModel : SsViewModel
    {
        public SsCommand SsShowDouranCommand { get; set; }
        public SsCommand SsOpenDouranCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowDouranCommand = new SsCommand(SsShowDouran);
            SsOpenDouranCommand = new SsCommand(SsOpenDouran);
        }

        private void SsShowDouran(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenDouran(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Douran";
            _url = "https://douran.com/";
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
                SsShowDouran(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}