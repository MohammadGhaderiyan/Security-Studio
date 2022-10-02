using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.KonBoot.ViewModel
{
    public class SsKonBootViewModel : SsViewModel
    {
        public SsCommand SsShowKonBootCommand { get; set; }
        public SsCommand SsOpenKonBootCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowKonBootCommand = new SsCommand(SsShowKonBoot);
            SsOpenKonBootCommand = new SsCommand(SsOpenKonBoot);
        }

        private void SsShowKonBoot(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenKonBoot(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Kon-Boot";
            Uri = _uriAddress = "https://kon-boot.com/";
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