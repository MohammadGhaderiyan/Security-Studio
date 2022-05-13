using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.Iana.ViewModel
{
    public class SsIanaViewModel : SsViewModel
    {
        public SsCommand SsShowXXXXXCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowXXXXXCommand = new SsCommand(SsShowXXXXX);
        }

        private void SsShowXXXXX(object parameter)
        {
            WebBrowser.Navigate("XXXXX");
        }

        protected override void PrepareVariables()
        {
            Title = "IANA";
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
                SsShowXXXXX(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}