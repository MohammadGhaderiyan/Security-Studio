using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Zeek.ViewModel
{
    public class SsZeekViewModel : SsViewModel
    {
        public SsCommand SsShowZeekCommand { get; set; }
        public SsCommand SsOpenZeekCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowZeekCommand = new SsCommand(SsShowZeek);
            SsOpenZeekCommand = new SsCommand(SsOpenZeek);
        }

        private void SsShowZeek(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenZeek(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Zeek";
            Uri = _uriAddress = "https://zeek.org/";
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