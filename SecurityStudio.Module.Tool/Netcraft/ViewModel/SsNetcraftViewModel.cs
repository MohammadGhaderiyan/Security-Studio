using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Netcraft.ViewModel
{
    public class SsNetcraftViewModel : SsViewModel
    {
        public SsCommand SsShowNetcraftCommand { get; set; }
        public SsCommand SsOpenNetcraftCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowNetcraftCommand = new SsCommand(SsShowNetcraft);
            SsOpenNetcraftCommand = new SsCommand(SsOpenNetcraft);
        }

        private void SsShowNetcraft(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenNetcraft(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Netcraft";
            Uri = _uriAddress = "https://netcraft.com/";
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