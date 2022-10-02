using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.SecLists.ViewModel
{
    public class SsSecListsViewModel : SsViewModel
    {
        public SsCommand SsShowSecListsCommand { get; set; }
        public SsCommand SsOpenSecListsCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSecListsCommand = new SsCommand(SsShowSecLists);
            SsOpenSecListsCommand = new SsCommand(SsOpenSecLists);
        }

        private void SsShowSecLists(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSecLists(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Sec Lists";
            Uri = _uriAddress = "https://github.com/danielmiessler/SecLists/";
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