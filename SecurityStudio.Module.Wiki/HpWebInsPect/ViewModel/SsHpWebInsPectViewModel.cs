using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.HpWebInsPect.ViewModel
{
    public class SsHpWebInsPectViewModel : SsViewModel
    {
        public SsCommand SsShowHpWebInsPectCommand { get; set; }
        public SsCommand SsOpenHpWebInsPectCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowHpWebInsPectCommand = new SsCommand(SsShowHpWebInsPect);
            SsOpenHpWebInsPectCommand = new SsCommand(SsOpenHpWebInsPect);
        }

        private void SsShowHpWebInsPect(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenHpWebInsPect(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "HP WebInsPect";
            Uri = _uriAddress = "https://www.ndm.net/sast/hp-webinspect/";
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