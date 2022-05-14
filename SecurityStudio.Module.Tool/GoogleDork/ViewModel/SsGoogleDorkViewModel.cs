using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.GoogleDork;
using SecurityStudio.Base.Tool.Utility;

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
        public SsCommand SsOpenGoogleDorkCommand { get; set; }
        public SsCommand SsSearchCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowGoogleDorkCommand = new SsCommand(SsShowGoogleDork);
            SsOpenGoogleDorkCommand = new SsCommand(SsOpenGoogleDork);
            SsSearchCommand = new SsCommand(SsSearch);
        }

        private void SsShowGoogleDork(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenGoogleDork(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private void SsSearch(object parameter)
        {
            WebBrowser.Navigate(_googleDorkTool.GetUri(
                Keyword, Site, FileType, InUrl, InTitle, Link, Cache));
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Google Dork";
            _url = "https://www.google.com/";
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
                SsShowGoogleDork(null);
            }
        }

        private string _keyword;
        public string Keyword
        {
            get => _keyword;
            set
            {
                _keyword = value;
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

        private string _link;
        public string Link
        {
            get => _link;
            set
            {
                _link = value;
                SsShowGoogleDork(null);
            }
        }

        private string _cache;
        public string Cache
        {
            get => _cache;
            set
            {
                _cache = value;
                SsShowGoogleDork(null);
            }
        }

        public override void Dispose()
        {
        }
    }
}