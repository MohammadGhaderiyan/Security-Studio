using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.OneMillionTweetMap.ViewModel
{
    public class SsOneMillionTweetMapViewModel : SsViewModel
    {
        public SsCommand SsShowOneMillionTweetMapCommand { get; set; }
        public SsCommand SsOpenOneMillionTweetMapCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOneMillionTweetMapCommand = new SsCommand(SsShowOneMillionTweetMap);
            SsOpenOneMillionTweetMapCommand = new SsCommand(SsOpenOneMillionTweetMap);
        }

        private void SsShowOneMillionTweetMap(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOneMillionTweetMap(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "One Million Tweet Map";
            Uri = _uriAddress = "https://onemilliontweetmap.com/";
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

        public override void Dispose()
        {
        }
    }
}