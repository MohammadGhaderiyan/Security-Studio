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
            Uri = _uriAddress;
        }

        private void SsOpenCensys(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private void SsSearch(object parameter)
        {
            Uri = _censysTool.GetUri(Query);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Censys";
            Uri = _uriAddress = "https://search.censys.io/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged();
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