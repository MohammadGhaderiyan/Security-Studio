using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.Truecaller.ViewModel
{
    public class SsTruecallerViewModel : SsViewModel
    {
        public SsCommand SsShowTruecallerCommand { get; set; }
        public SsCommand SsOpenTruecallerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowTruecallerCommand = new SsCommand(SsShowTruecaller);
            SsOpenTruecallerCommand = new SsCommand(SsOpenTruecaller);
        }

        private void SsShowTruecaller(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenTruecaller(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Truecaller";
            Uri = _uriAddress = "https://www.truecaller.com/";
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