using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Mitre.ViewModel
{
    public class SsMitreViewModel : SsViewModel
    {
        public SsCommand SsShowMitreCommand { get; set; }
        public SsCommand SsOpenMitreCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowMitreCommand = new SsCommand(SsShowMitre);
            SsOpenMitreCommand = new SsCommand(SsOpenMitre);
        }

        private void SsShowMitre(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenMitre(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "MITRE";
            Uri = _uriAddress = "https://mitre.org/";
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