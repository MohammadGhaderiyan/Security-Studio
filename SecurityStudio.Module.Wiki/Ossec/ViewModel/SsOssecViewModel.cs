using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Ossec.ViewModel
{
    public class SsOssecViewModel : SsViewModel
    {
        public SsCommand SsShowOssecCommand { get; set; }
        public SsCommand SsOpenOssecCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOssecCommand = new SsCommand(SsShowOssec);
            SsOpenOssecCommand = new SsCommand(SsOpenOssec);
        }

        private void SsShowOssec(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOssec(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Ossec";
            Uri = _uriAddress = "https://www.ossec.net/";
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