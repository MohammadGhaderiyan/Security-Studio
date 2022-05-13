using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Osint.Truecaller.ViewModel
{
    public class SsTruecallerViewModel : SsViewModel
    {
        public SsCommand SsShowTruecallerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowTruecallerCommand = new SsCommand(SsShowTruecaller);
        }

        private void SsShowTruecaller(object parameter)
        {
            WebBrowser.Navigate("https://www.truecaller.com/");
        }

        protected override void PrepareVariables()
        {
            Title = "Truecaller";
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