using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Ubertooth.ViewModel
{
    public class SsUbertoothViewModel : SsViewModel
    {
        public SsCommand SsShowUbertoothCommand { get; set; }
        public SsCommand SsOpenUbertoothCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowUbertoothCommand = new SsCommand(SsShowUbertooth);
            SsOpenUbertoothCommand = new SsCommand(SsOpenUbertooth);
        }

        private void SsShowUbertooth(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenUbertooth(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Ubertooth";
            Uri = _uriAddress = "https://greatscottgadgets.com/ubertoothone/";
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