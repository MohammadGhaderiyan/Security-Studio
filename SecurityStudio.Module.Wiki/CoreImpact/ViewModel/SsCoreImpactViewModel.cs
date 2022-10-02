using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.CoreImpact.ViewModel
{
    public class SsCoreImpactViewModel : SsViewModel
    {
        public SsCommand SsShowCoreImpactCommand { get; set; }
        public SsCommand SsOpenCoreImpactCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCoreImpactCommand = new SsCommand(SsShowCoreImpact);
            SsOpenCoreImpactCommand = new SsCommand(SsOpenCoreImpact);
        }

        private void SsShowCoreImpact(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenCoreImpact(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Core Impact";
            Uri = _uriAddress = "https://www.coresecurity.com/products/core-impact/";
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