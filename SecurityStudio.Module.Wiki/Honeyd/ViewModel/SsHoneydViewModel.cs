using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Honeyd.ViewModel
{
    public class SsHoneydViewModel : SsViewModel
    {
        public SsCommand SsShowHoneydCommand { get; set; }
        public SsCommand SsOpenHoneydCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowHoneydCommand = new SsCommand(SsShowHoneyd);
            SsOpenHoneydCommand = new SsCommand(SsOpenHoneyd);
        }

        private void SsShowHoneyd(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenHoneyd(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Honeyd";
            Uri = _uriAddress = "http://www.honeyd.org/";
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