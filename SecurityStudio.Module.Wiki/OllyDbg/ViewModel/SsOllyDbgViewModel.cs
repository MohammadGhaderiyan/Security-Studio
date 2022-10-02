using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.OllyDbg.ViewModel
{
    public class SsOllyDbgViewModel : SsViewModel
    {
        public SsCommand SsShowOllyDbgCommand { get; set; }
        public SsCommand SsOpenOllyDbgCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOllyDbgCommand = new SsCommand(SsShowOllyDbg);
            SsOpenOllyDbgCommand = new SsCommand(SsOpenOllyDbg);
        }

        private void SsShowOllyDbg(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOllyDbg(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "OllyDbg";
            Uri = _uriAddress = "https://www.ollydbg.de/";
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