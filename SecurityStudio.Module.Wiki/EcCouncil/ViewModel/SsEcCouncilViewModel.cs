using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.EcCouncil.ViewModel
{
    public class SsEcCouncilViewModel : SsViewModel
    {
        public SsCommand SsShowEcCouncilCommand { get; set; }
        public SsCommand SsOpenEcCouncilCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowEcCouncilCommand = new SsCommand(SsShowEcCouncil);
            SsOpenEcCouncilCommand = new SsCommand(SsOpenEcCouncil);
        }

        private void SsShowEcCouncil(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenEcCouncil(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "EC-Council";
            Uri = _uriAddress = "https://www.eccouncil.org/";
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