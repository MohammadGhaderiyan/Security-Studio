using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.KfSensor.ViewModel
{
    public class SsKfSensorViewModel : SsViewModel
    {
        public SsCommand SsShowKfSensorCommand { get; set; }
        public SsCommand SsOpenKfSensorCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowKfSensorCommand = new SsCommand(SsShowKfSensor);
            SsOpenKfSensorCommand = new SsCommand(SsOpenKfSensor);
        }

        private void SsShowKfSensor(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenKfSensor(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "KFSensor";
            Uri = _uriAddress = "http://www.keyfocus.net/kfsensor/";
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