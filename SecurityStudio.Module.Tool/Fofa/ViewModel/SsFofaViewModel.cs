using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Fofa.ViewModel
{
    public class SsFofaViewModel : SsViewModel
    {
        public SsCommand SsShowFofaCommand { get; set; }
        public SsCommand SsOpenFofaCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowFofaCommand = new SsCommand(SsShowFofa);
            SsOpenFofaCommand = new SsCommand(SsOpenFofa);
        }

        private void SsShowFofa(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenFofa(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "FOFA";
            _url = "https://fofa.info/";
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
                SsShowFofa(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}