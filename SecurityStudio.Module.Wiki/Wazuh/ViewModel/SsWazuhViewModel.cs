using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Wazuh.ViewModel
{
    public class SsWazuhViewModel : SsViewModel
    {
        public SsCommand SsShowWazuhCommand { get; set; }
        public SsCommand SsOpenWazuhCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowWazuhCommand = new SsCommand(SsShowWazuh);
            SsOpenWazuhCommand = new SsCommand(SsOpenWazuh);
        }

        private void SsShowWazuh(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenWazuh(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Wazuh";
            Uri = _uriAddress = "https://wazuh.com/";
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