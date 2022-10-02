using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.DnsDumpster.ViewModel
{
    public class SsDnsDumpsterViewModel : SsViewModel
    {
        public SsCommand SsShowDnsDumpsterCommand { get; set; }
        public SsCommand SsOpenDnsDumpsterCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowDnsDumpsterCommand = new SsCommand(SsShowDnsDumpster);
            SsOpenDnsDumpsterCommand = new SsCommand(SsOpenDnsDumpster);
        }

        private void SsShowDnsDumpster(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenDnsDumpster(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "DNS Dumpster";
            Uri = _uriAddress = "https://DnsDumpster.com/";
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