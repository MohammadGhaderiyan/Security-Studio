using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Afta.ViewModel
{
    public class SsAftaViewModel : SsViewModel
    {
        public SsCommand SsShowExploitDbCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowExploitDbCommand = new SsCommand(SsShowExploitDb);
        }

        private void SsShowExploitDb(object parameter)
        {
            WebBrowser.Navigate("https://sec.ito.gov.ir/");
        }

        protected override void PrepareVariables()
        {
            Title = "AFTA";
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
                SsShowExploitDb(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}