using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Iana.ViewModel
{
    public class SsIanaViewModel : SsViewModel
    {
        public SsCommand SsShowRipeCommand { get; set; }
        public SsCommand SsShowArinCommand { get; set; }
        public SsCommand SsShowAfrinicCommand { get; set; }
        public SsCommand SsShowApnicCommand { get; set; }
        public SsCommand SsShowLacnicCommand { get; set; }
        public SsCommand SsOpenRipeCommand { get; set; }
        public SsCommand SsOpenArinCommand { get; set; }
        public SsCommand SsOpenAfrinicCommand { get; set; }
        public SsCommand SsOpenApnicCommand { get; set; }
        public SsCommand SsOpenLacnicCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowRipeCommand = new SsCommand(SsShowRipe);
            SsShowArinCommand = new SsCommand(SsShowArin);
            SsShowAfrinicCommand = new SsCommand(SsShowAfrinic);
            SsShowApnicCommand = new SsCommand(SsShowApnic);
            SsShowLacnicCommand = new SsCommand(SsShowLacnic);
            SsOpenRipeCommand = new SsCommand(SsOpenRipe);
            SsOpenArinCommand = new SsCommand(SsOpenArin);
            SsOpenAfrinicCommand = new SsCommand(SsOpenAfrinic);
            SsOpenApnicCommand = new SsCommand(SsOpenApnic);
            SsOpenLacnicCommand = new SsCommand(SsOpenLacnic);
        }

        private void SsShowRipe(object parameter)
        {
            Uri = _ripeUrlAddress;
        }

        private void SsShowArin(object parameter)
        {
            Uri = _arinUrlAddress;
        }

        private void SsShowAfrinic(object parameter)
        {
            Uri = _afrinicUrlAddress;
        }

        private void SsShowApnic(object parameter)
        {
            Uri = _apnicUrlAddress;
        }

        private void SsShowLacnic(object parameter)
        {
            Uri = _lacnicUrlAddress;
        }

        private void SsOpenRipe(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_ripeUrlAddress);
        }

        private void SsOpenArin(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_arinUrlAddress);
        }

        private void SsOpenAfrinic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_afrinicUrlAddress);
        }

        private void SsOpenApnic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_apnicUrlAddress);
        }

        private void SsOpenLacnic(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_lacnicUrlAddress);
        }

        private string _ripeUrlAddress;
        private string _arinUrlAddress;
        private string _afrinicUrlAddress;
        private string _apnicUrlAddress;
        private string _lacnicUrlAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "IANA";
            Uri = _ripeUrlAddress = "https://www.ripe.net/";
            _arinUrlAddress = "https://www.arin.net/";
            _afrinicUrlAddress = "https://afrinic.net/";
            _apnicUrlAddress = "https://www.apnic.net/";
            _lacnicUrlAddress = "https://www.lacnic.net/";
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