using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Douran.ViewModel
{
    public class SsDouranViewModel : SsViewModel
    {
        public SsCommand SsShowDouranCommand { get; set; }
        public SsCommand SsOpenDouranCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowDouranCommand = new SsCommand(SsShowDouran);
            SsOpenDouranCommand = new SsCommand(SsOpenDouran);
        }

        private void SsShowDouran(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenDouran(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Douran";
            Uri = _uriAddress = "https://douran.com/";
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