using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.IdaPro.ViewModel
{
    public class SsIdaProViewModel : SsViewModel
    {
        public SsCommand SsShowIdaProCommand { get; set; }
        public SsCommand SsOpenIdaProCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowIdaProCommand = new SsCommand(SsShowIdaPro);
            SsOpenIdaProCommand = new SsCommand(SsOpenIdaPro);
        }

        private void SsShowIdaPro(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenIdaPro(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "IDA Pro";
            Uri = _uriAddress = "https://hex-rays.com /";
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