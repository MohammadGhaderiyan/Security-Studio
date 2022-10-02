using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Wireshark.ViewModel
{
    public class SsWiresharkViewModel : SsViewModel
    {
        public SsCommand SsShowWiresharkCommand { get; set; }
        public SsCommand SsOpenWiresharkCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowWiresharkCommand = new SsCommand(SsShowWireshark);
            SsOpenWiresharkCommand = new SsCommand(SsOpenWireshark);
        }

        private void SsShowWireshark(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenWireshark(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Wireshark";
            Uri = _uriAddress = "https://www.wireshark.org/";
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