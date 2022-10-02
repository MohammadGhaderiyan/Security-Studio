using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.VisualRoute.ViewModel
{
    public class SsVisualRouteViewModel : SsViewModel
    {
        public SsCommand SsShowVisualRouteCommand { get; set; }
        public SsCommand SsOpenVisualRouteCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowVisualRouteCommand = new SsCommand(SsShowVisualRoute);
            SsOpenVisualRouteCommand = new SsCommand(SsOpenVisualRoute);
        }

        private void SsShowVisualRoute(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenVisualRoute(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "VisualRoute";
            Uri = _uriAddress = "http://www.visualroute.com/";
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