using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.OpenVas.ViewModel
{
    public class SsOpenVASViewModel : SsViewModel
    {
        public SsCommand SsShowOpenVASCommand { get; set; }
        public SsCommand SsOpenOpenVASCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOpenVASCommand = new SsCommand(SsShowOpenVAS);
            SsOpenOpenVASCommand = new SsCommand(SsOpenOpenVAS);
        }

        private void SsShowOpenVAS(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOpenVAS(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "OpenVAS";
            Uri = _uriAddress = "https://www.openvas.org/";
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