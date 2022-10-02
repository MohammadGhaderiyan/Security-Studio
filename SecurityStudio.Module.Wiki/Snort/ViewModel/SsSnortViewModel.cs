using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Snort.ViewModel
{
    public class SsSnortViewModel : SsViewModel
    {
        public SsCommand SsShowSnortCommand { get; set; }
        public SsCommand SsOpenSnortCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSnortCommand = new SsCommand(SsShowSnort);
            SsOpenSnortCommand = new SsCommand(SsOpenSnort);
        }

        private void SsShowSnort(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSnort(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Snort";
            Uri = _uriAddress = "https://www.snort.org/";
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