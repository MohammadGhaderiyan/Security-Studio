using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint._411.ViewModel
{
    public class Ss411ViewModel : SsViewModel
    {
        public SsCommand SsShow411Command { get; set; }
        public SsCommand SsOpen411Command { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShow411Command = new SsCommand(SsShow411);
            SsOpen411Command = new SsCommand(SsOpen411);
        }

        private void SsShow411(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpen411(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "411";
            Uri = _uriAddress = "https://411.com/";
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