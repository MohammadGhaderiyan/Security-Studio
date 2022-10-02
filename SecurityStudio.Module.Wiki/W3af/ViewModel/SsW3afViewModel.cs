using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.W3af.ViewModel
{
    public class SsW3afViewModel : SsViewModel
    {
        public SsCommand SsShowW3afCommand { get; set; }
        public SsCommand SsOpenW3afCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowW3afCommand = new SsCommand(SsShowW3af);
            SsOpenW3afCommand = new SsCommand(SsOpenW3af);
        }

        private void SsShowW3af(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenW3af(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "w3af";
            Uri = _uriAddress = "http://w3af.org/";
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