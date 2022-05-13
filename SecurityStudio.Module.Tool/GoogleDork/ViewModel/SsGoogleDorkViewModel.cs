using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.GoogleDork;

namespace SecurityStudio.Module.Tool.GoogleDork.ViewModel
{
    public class SsGoogleDorkViewModel : SsViewModel
    {
        private readonly GoogleDorkTool _googleDorkTool;

        public SsGoogleDorkViewModel(GoogleDorkTool googleDorkTool)
        {
            _googleDorkTool = googleDorkTool;
        }

        public SsCommand SsShowGoogleDorkCommand { get; set; }
        public SsCommand SsSearchCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowGoogleDorkCommand = new SsCommand(SsShowGoogleDork);
            SsSearchCommand = new SsCommand(SsSearch);
        }

        private void SsShowGoogleDork(object parameter)
        {
            WebBrowser.Navigate("https://www.google.com/");
        }

        private void SsSearch(object parameter)
        {
            WebBrowser.Navigate(_googleDorkTool.GetUri(Site, FileType, InUrl, InTitle));
        }

        protected override void PrepareVariables()
        {
            Title = "Google Dork";
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
                SsShowGoogleDork(null);
            }
        }

        private string _site;
        public string Site
        {
            get => _site;
            set
            {
                _site = value;
                SsShowGoogleDork(null);
            }
        }

        private string _fileType;
        public string FileType
        {
            get => _fileType;
            set
            {
                _fileType = value;
                SsShowGoogleDork(null);
            }
        }

        private string _inUrl;
        public string InUrl
        {
            get => _inUrl;
            set
            {
                _inUrl = value;
                SsShowGoogleDork(null);
            }
        }

        private string _inTitle;
        public string InTitle
        {
            get => _inTitle;
            set
            {
                _inTitle = value;
                SsShowGoogleDork(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}