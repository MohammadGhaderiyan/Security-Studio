using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.VirusTotal.ViewModel
{
    public class SsVirusTotalViewModel : SsViewModel
    {
        public SsCommand SsShowVirusTotalCommand { get; set; }
        public SsCommand SsOpenVirusTotalCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowVirusTotalCommand = new SsCommand(SsShowVirusTotal);
            SsOpenVirusTotalCommand = new SsCommand(SsOpenVirusTotal);
        }

        private void SsShowVirusTotal(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenVirusTotal(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Virus Total";
            Uri = _uriAddress = "https://www.virustotal.com/";
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