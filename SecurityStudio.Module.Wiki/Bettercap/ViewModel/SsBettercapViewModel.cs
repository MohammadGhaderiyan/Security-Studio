using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Bettercap.ViewModel
{
    public class SsBettercapViewModel : SsViewModel
    {
        public SsCommand SsShowBettercapCommand { get; set; }
        public SsCommand SsOpenBettercapCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowBettercapCommand = new SsCommand(SsShowBettercap);
            SsOpenBettercapCommand = new SsCommand(SsOpenBettercap);
        }

        private void SsShowBettercap(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenBettercap(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "bettercap";
            Uri = _uriAddress = "https://www.bettercap.org/";
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