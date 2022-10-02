using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Nexpose.ViewModel
{
    public class SsNexposeViewModel : SsViewModel
    {
        public SsCommand SsShowNexposeCommand { get; set; }
        public SsCommand SsOpenNexposeCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowNexposeCommand = new SsCommand(SsShowNexpose);
            SsOpenNexposeCommand = new SsCommand(SsOpenNexpose);
        }

        private void SsShowNexpose(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenNexpose(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Nexpose";
            Uri = _uriAddress = "https://www.rapid7.com/products/nexpose/";
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