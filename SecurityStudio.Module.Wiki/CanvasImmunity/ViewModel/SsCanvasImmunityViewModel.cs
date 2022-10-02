using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.CanvasImmunity.ViewModel
{
    public class SsCanvasImmunityViewModel : SsViewModel
    {
        public SsCommand SsShowCanvasImmunityCommand { get; set; }
        public SsCommand SsOpenCanvasImmunityCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCanvasImmunityCommand = new SsCommand(SsShowCanvasImmunity);
            SsOpenCanvasImmunityCommand = new SsCommand(SsOpenCanvasImmunity);
        }

        private void SsShowCanvasImmunity(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenCanvasImmunity(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Canvas Immunity";
            Uri = _uriAddress = "https://immunityinc.com/products/canvas/";
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