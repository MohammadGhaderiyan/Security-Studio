using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.I2P.ViewModel
{
    public class SsI2PViewModel : SsViewModel
    {
        public SsCommand SsShowI2PCommand { get; set; }
        public SsCommand SsOpenI2PCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowI2PCommand = new SsCommand(SsShowI2P);
            SsOpenI2PCommand = new SsCommand(SsOpenI2P);
        }

        private void SsShowI2P(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenI2P(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "I2P";
            Uri = _uriAddress = "https://getI2p.net/";
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