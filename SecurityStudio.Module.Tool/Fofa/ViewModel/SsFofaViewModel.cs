using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Fofa.ViewModel
{
    public class SsFofaViewModel : SsViewModel
    {
        public SsCommand SsShowFofaCommand { get; set; }
        public SsCommand SsOpenFofaCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowFofaCommand = new SsCommand(SsShowFofa);
            SsOpenFofaCommand = new SsCommand(SsOpenFofa);
        }

        private void SsShowFofa(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenFofa(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "FOFA";
            Uri = _uriAddress = "https://fofa.info/";
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