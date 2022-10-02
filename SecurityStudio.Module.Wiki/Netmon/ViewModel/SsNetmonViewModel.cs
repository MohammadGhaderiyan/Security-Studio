using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Netmon.ViewModel
{
    public class SsNetmonViewModel : SsViewModel
    {
        public SsCommand SsShowNetmonCommand { get; set; }
        public SsCommand SsOpenNetmonCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowNetmonCommand = new SsCommand(SsShowNetmon);
            SsOpenNetmonCommand = new SsCommand(SsOpenNetmon);
        }

        private void SsShowNetmon(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenNetmon(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Netmon";
            Uri = _uriAddress = "https://www.microsoft.com/en-us/download/4865/";
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