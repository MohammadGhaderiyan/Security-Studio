using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Emkei.ViewModel
{
    public class SsEmkeiViewModel : SsViewModel
    {
        public SsCommand SsShowEmkeiCommand { get; set; }
        public SsCommand SsOpenEmkeiCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowEmkeiCommand = new SsCommand(SsShowEmkei);
            SsOpenEmkeiCommand = new SsCommand(SsOpenEmkei);
        }

        private void SsShowEmkei(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenEmkei(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Emkei";
            Uri = _uriAddress = "https://emkei.cz/";
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