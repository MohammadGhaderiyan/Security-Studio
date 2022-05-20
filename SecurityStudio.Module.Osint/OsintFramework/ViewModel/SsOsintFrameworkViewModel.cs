using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Osint.OsintFramework.ViewModel
{
    public class SsOsintFrameworkViewModel : SsViewModel
    {
        public SsCommand SsShowOsintFrameworkCommand { get; set; }
        public SsCommand SsOpenOsintFrameworkCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowOsintFrameworkCommand = new SsCommand(SsShowOsintFramework);
            SsOpenOsintFrameworkCommand = new SsCommand(SsOpenOsintFramework);
        }

        private void SsShowOsintFramework(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenOsintFramework(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = " OSINT Framework";
            Uri = _uriAddress = "https://osintframework.com/";
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