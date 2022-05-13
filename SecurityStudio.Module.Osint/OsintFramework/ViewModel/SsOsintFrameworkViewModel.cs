using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Osint.OsintFramework.ViewModel
{
    public class SsOsintFrameworkViewModel : SsViewModel
    {
        public SsCommand SsShowOsintFrameworkCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOsintFrameworkCommand = new SsCommand(SsShowOsintFramework);
        }

        private void SsShowOsintFramework(object parameter)
        {
            WebBrowser.Navigate("https://osintframework.com/");
        }

        protected override void PrepareVariables()
        {
            Title = " OSINT Framework";
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