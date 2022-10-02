using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Afta.ViewModel
{
    public class SsAftaViewModel : SsViewModel
    {
        public SsCommand SsShowAftaCommand { get; set; }
        public SsCommand SsOpenAftaCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowAftaCommand = new SsCommand(SsShowAfta);
            SsOpenAftaCommand = new SsCommand(SsOpenAfta);
        }

        private void SsShowAfta(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenAfta(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "AFTA";
            Uri = _uriAddress = "https://sec.ito.gov.ir/";
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