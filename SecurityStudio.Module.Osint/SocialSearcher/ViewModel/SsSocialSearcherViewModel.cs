using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.SocialSearcher.ViewModel
{
    public class SsSocialSearcherViewModel : SsViewModel
    {
        public SsCommand SsShowSocialSearcherCommand { get; set; }
        public SsCommand SsOpenSocialSearcherCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSocialSearcherCommand = new SsCommand(SsShowSocialSearcher);
            SsOpenSocialSearcherCommand = new SsCommand(SsOpenSocialSearcher);
        }

        private void SsShowSocialSearcher(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSocialSearcher(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Social Searcher";
            Uri = _uriAddress = "https://www.social-searcher.com/";
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