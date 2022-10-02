using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.Hunter.ViewModel
{
    public class SsHunterViewModel : SsViewModel
    {
        public SsCommand SsShowHunterCommand { get; set; }
        public SsCommand SsOpenHunterCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowHunterCommand = new SsCommand(SsShowHunter);
            SsOpenHunterCommand = new SsCommand(SsOpenHunter);
        }

        private void SsShowHunter(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenHunter(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Hunter";
            Uri = _uriAddress = "https://hunter.io/";
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