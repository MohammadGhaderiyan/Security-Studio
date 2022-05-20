using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Censys;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Censys.ViewModel
{
    public class SsCensysViewModel : SsViewModel
    {
        private readonly CensysTool _censysTool;

        public SsCensysViewModel(CensysTool censysTool)
        {
            _censysTool = censysTool;
        }

        public SsCommand SsShowCensysCommand { get; set; }
        public SsCommand SsOpenCensysCommand { get; set; }
        public SsCommand SsSearchCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCensysCommand = new SsCommand(SsShowCensys);
            SsOpenCensysCommand = new SsCommand(SsOpenCensys);
            SsSearchCommand = new SsCommand(SsSearch);
        }

        private void SsShowCensys(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenCensys(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private void SsSearch(object parameter)
        {
            WebBrowser.Navigate(_censysTool.GetUri(Query));
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Censys";
            _url = "https://search.censys.io/";
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
                SsShowCensys(null);
            }
        }

        private string _query;
        public string Query
        {
            get => _query;
            set
            {
                _query = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}