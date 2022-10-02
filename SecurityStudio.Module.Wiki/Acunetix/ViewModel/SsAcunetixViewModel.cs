using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Acunetix.ViewModel
{
    public class SsAcunetixViewModel : SsViewModel
    {
        public SsCommand SsShowAcunetixCommand { get; set; }
        public SsCommand SsOpenAcunetixCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowAcunetixCommand = new SsCommand(SsShowAcunetix);
            SsOpenAcunetixCommand = new SsCommand(SsOpenAcunetix);
        }

        private void SsShowAcunetix(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenAcunetix(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Acunetix";
            Uri = _uriAddress = "https://www.acunetix.com/";
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