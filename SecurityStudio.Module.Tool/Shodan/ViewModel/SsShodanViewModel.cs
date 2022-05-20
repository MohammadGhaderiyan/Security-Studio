using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Shodan;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Tool.Shodan.ViewModel
{
    public class SsShodanViewModel : SsViewModel
    {
        private readonly ShodanTool _shodanTool;

        public SsShodanViewModel(ShodanTool shodanTool)
        {
            _shodanTool = shodanTool;
        }

        public SsCommand SsShowShodanCommand { get; set; }
        public SsCommand SsOpenShodanCommand { get; set; }
        public SsCommand SsSearchCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowShodanCommand = new SsCommand(SsShowShodan);
            SsOpenShodanCommand = new SsCommand(SsOpenShodan);
            SsSearchCommand = new SsCommand(SsSearch);
        }

        private void SsShowShodan(object parameter)
        {
            WebBrowser.Navigate(_url);
        }

        private void SsOpenShodan(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_url);
        }

        private void SsSearch(object parameter)
        {
            WebBrowser.Navigate(_shodanTool.GetUri(
                Net, Host, Port, Application, Server, Country, City, Custom));
        }

        private string _url;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Shodan";
            _url = "https://www.shodan.io/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private System.Windows.Controls.WebBrowser _webBrowser;
        public System.Windows.Controls.WebBrowser WebBrowser
        {
            get => _webBrowser;
            set
            {
                _webBrowser = value;
                SsShowShodan(null);
            }
        }

        private string _net;
        public string Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged();
            }
        }

        private string _host;
        public string Host
        {
            get => _host;
            set
            {
                _host = value;
                OnPropertyChanged();
            }
        }

        private string _port;
        public string Port
        {
            get => _port;
            set
            {
                _port = value;
                OnPropertyChanged();
            }
        }

        private string _application;
        public string Application
        {
            get => _application;
            set
            {
                _application = value;
                OnPropertyChanged();
            }
        }

        private string _server;
        public string Server
        {
            get => _server;
            set
            {
                _server = value;
                OnPropertyChanged();
            }
        }

        private string _country;
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged();
            }
        }

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }

        private string _custom;
        public string Custom
        {
            get => _custom;
            set
            {
                _custom = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}