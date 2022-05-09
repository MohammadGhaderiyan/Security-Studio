using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Xpf.Core;
using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Module.CodeEditor.BashScript.View;
using SecurityStudio.Module.CodeEditor.BatchScript.View;
using SecurityStudio.Module.CodeEditor.CPlusPlus.View;
using SecurityStudio.Module.CodeEditor.CSharp.View;
using SecurityStudio.Module.CodeEditor.PowerShellScript.View;
using SecurityStudio.Module.CodeEditor.Python.View;
using SecurityStudio.Module.Database.MongoDb.View;
using SecurityStudio.Module.Database.MySql.View;
using SecurityStudio.Module.Database.Oracle.View;
using SecurityStudio.Module.Database.SqlServer.View;
using SecurityStudio.Module.Definition.AndroidOperatingSystem.View;
using SecurityStudio.Module.Definition.LinuxOperatingSystem.View;
using SecurityStudio.Module.Definition.WindowsOperatingSystem.View;
using SecurityStudio.Module.Linux.LinuxFileExplorer.View;
using SecurityStudio.Module.Linux.LinuxNetwork.View;
using SecurityStudio.Module.Linux.Terminal.View;
using SecurityStudio.Module.Main.Dashboard.View;
using SecurityStudio.Module.Main.Test.View;
using SecurityStudio.Module.Tool.ApiPlatform.View;
using SecurityStudio.Module.Tool.ExploitDb.View;
using SecurityStudio.Module.Tool.FtpManager.View;
using SecurityStudio.Module.Tool.GitHub.View;
using SecurityStudio.Module.Tool.Mimikatz.View;
using SecurityStudio.Module.Tool.Nmap.View;
using SecurityStudio.Module.Tool.Shodan.View;
using SecurityStudio.Module.Tool.TextEditor.View;
using SecurityStudio.Module.Tool.WebBrowser.View;
using SecurityStudio.Module.Tool.WebServer.View;
using SecurityStudio.Module.Windows.Arp.View;
using SecurityStudio.Module.Windows.CommandPrompt.View;
using SecurityStudio.Module.Windows.RegistryEditor.View;
using SecurityStudio.Module.Windows.WindowsFileExplorer.View;
using SecurityStudio.Module.Windows.WindowsNetwork.View;
using SecurityStudio.Service.Main.Dock;
using SecurityStudio.Service.Main.Parameter;
using SecurityStudio.Service.Main.Session;

namespace SecurityStudio.Module.Main.Main.ViewModel
{
    public class SsMainWindowViewModel : SsViewModel
    {
        private readonly IDockService _dockService;
        private readonly IParameterService _parameterService;
        private readonly ISessionService _sessionService;

        public SsMainWindowViewModel(IDockService dockService,
            IParameterService parameterService, ISessionService sessionService)
        {
            _dockService = dockService;
            _parameterService = parameterService;
            _sessionService = sessionService;
        }
        public SsCommand SsLogoutCommand { get; set; }


        #region Mitre


        #endregion


        #region Tools

        public SsCommand ShowSsApiPlatformViewCommand { get; set; }
        public SsCommand ShowSsExploitDbViewCommand { get; set; }
        public SsCommand ShowSsFtpManagerViewCommand { get; set; }
        public SsCommand ShowSsGitHubViewCommand { get; set; }
        public SsCommand ShowSsMimikatzViewCommand { get; set; }
        public SsCommand ShowSsNmapViewCommand { get; set; }
        public SsCommand ShowSsShodanViewCommand { get; set; }
        public SsCommand ShowSsTextEditorViewCommand { get; set; }
        public SsCommand ShowSsWebBrowserViewCommand { get; set; }
        public SsCommand ShowSsWebServerViewCommand { get; set; }

        #endregion


        #region Linux

        public SsCommand ShowSsLinuxFileExplorerViewCommand { get; set; }
        public SsCommand ShowSsLinuxNetworkViewCommand { get; set; }
        public SsCommand ShowSsTerminalViewCommand { get; set; }

        #endregion


        #region Windows

        public SsCommand ShowSsArpViewCommand { get; set; }
        public SsCommand ShowSsCommandPromptViewCommand { get; set; }
        public SsCommand ShowSsWindowsFileExplorerViewCommand { get; set; }
        public SsCommand ShowSsWindowsNetworkViewCommand { get; set; }
        public SsCommand ShowSsRegistryEditorViewCommand { get; set; }

        #endregion


        #region Code Editor

        public SsCommand ShowSsBashScriptViewCommand { get; set; }
        public SsCommand ShowSsBatchScriptViewCommand { get; set; }
        public SsCommand ShowSsCPlusPlusViewCommand { get; set; }
        public SsCommand ShowSsCSharpViewCommand { get; set; }
        public SsCommand ShowSsPowerShellScriptViewCommand { get; set; }
        public SsCommand ShowSsPythonViewCommand { get; set; }

        #endregion


        #region Database

        public SsCommand ShowSsMongoDbViewCommand { get; set; }
        public SsCommand ShowSsMySqlViewCommand { get; set; }
        public SsCommand ShowSsOracleViewCommand { get; set; }
        public SsCommand ShowSsSqlServerViewCommand { get; set; }

        #endregion


        #region Web Pen Test


        #endregion


        #region Mobile Pen Test


        #endregion


        #region Network Pen Test


        #endregion


        #region Definition

        public SsCommand ShowSsAndroidOperatingSystemListViewCommand { get; set; }
        public SsCommand ShowSsLinuxOperatingSystemListViewCommand { get; set; }
        public SsCommand ShowSsWindowsOperatingSystemListViewCommand { get; set; }

        #endregion


        protected override void PrepareSsCommands()
        {
            #region Mitre


            #endregion


            #region Tools

            ShowSsApiPlatformViewCommand = new SsCommand(ShowSsApiPlatformView);
            ShowSsExploitDbViewCommand = new SsCommand(ShowSsExploitDbView);
            ShowSsFtpManagerViewCommand = new SsCommand(ShowSsFtpManagerView);
            ShowSsGitHubViewCommand = new SsCommand(ShowSsGitHubView);
            ShowSsMimikatzViewCommand = new SsCommand(ShowSsMimikatzView);
            ShowSsNmapViewCommand = new SsCommand(ShowSsNmapView);
            ShowSsShodanViewCommand = new SsCommand(ShowSsShodanView);
            ShowSsTextEditorViewCommand = new SsCommand(ShowSsTextEditorView);
            ShowSsWebBrowserViewCommand = new SsCommand(ShowSsWebBrowserView);
            ShowSsWebServerViewCommand = new SsCommand(ShowSsWebServerView);

            #endregion


            #region Linux

            ShowSsLinuxFileExplorerViewCommand = new SsCommand(ShowSsLinuxFileExplorerView);
            ShowSsLinuxNetworkViewCommand = new SsCommand(ShowSsLinuxNetworkView);
            ShowSsTerminalViewCommand = new SsCommand(ShowSsTerminalView);

            #endregion


            #region Windows

            ShowSsArpViewCommand = new SsCommand(ShowSsArpView);
            ShowSsCommandPromptViewCommand = new SsCommand(ShowSsCommandPromptView);
            ShowSsWindowsFileExplorerViewCommand = new SsCommand(ShowSsWindowsFileExplorerView);
            ShowSsWindowsNetworkViewCommand = new SsCommand(ShowSsWindowsNetworkView);
            ShowSsRegistryEditorViewCommand = new SsCommand(ShowSsRegistryEditorView);

            #endregion


            #region Code Editor

            ShowSsBashScriptViewCommand = new SsCommand(ShowSsBashScriptView);
            ShowSsBatchScriptViewCommand = new SsCommand(ShowSsBatchScriptView);
            ShowSsCPlusPlusViewCommand = new SsCommand(ShowSsCPlusPlusView);
            ShowSsCSharpViewCommand = new SsCommand(ShowSsCSharpView);
            ShowSsPowerShellScriptViewCommand = new SsCommand(ShowSsPowerShellScriptView);
            ShowSsPythonViewCommand = new SsCommand(ShowSsPythonView);

            #endregion


            #region Database

            ShowSsMongoDbViewCommand = new SsCommand(ShowSsMongoDbView);
            ShowSsMySqlViewCommand = new SsCommand(ShowSsMySqlView);
            ShowSsOracleViewCommand = new SsCommand(ShowSsOracleView);
            ShowSsSqlServerViewCommand = new SsCommand(ShowSsSqlServerView);

            #endregion


            #region Web Pen Test


            #endregion


            #region Mobile Pen Test


            #endregion


            #region Network Pen Test


            #endregion


            #region Definition

            ShowSsAndroidOperatingSystemListViewCommand = new SsCommand(ShowSsAndroidOperatingSystemListView);
            ShowSsLinuxOperatingSystemListViewCommand = new SsCommand(ShowSsLinuxOperatingSystemListView);
            ShowSsWindowsOperatingSystemListViewCommand = new SsCommand(ShowSsWindowsOperatingSystemListView);

            #endregion
        }


        #region Mitre


        #endregion


        #region Tools

        private void ShowSsApiPlatformView(object parameter)
        {
            _dockService.ShowSsView<SsApiPlatformView>();
        }

        private void ShowSsExploitDbView(object parameter)
        {
            _dockService.ShowSsView<SsExploitDbView>();
        }

        private void ShowSsFtpManagerView(object parameter)
        {
            _dockService.ShowSsView<SsFtpManagerView>();
        }

        private void ShowSsGitHubView(object parameter)
        {
            _dockService.ShowSsView<SsGitHubView>();
        }

        private void ShowSsMimikatzView(object parameter)
        {
            _dockService.ShowSsView<SsMimikatzView>();
        }

        private void ShowSsNmapView(object parameter)
        {
            _dockService.ShowSsView<SsNmapView>();
        }

        private void ShowSsShodanView(object parameter)
        {
            _dockService.ShowSsView<SsShodanView>();
        }

        private void ShowSsTextEditorView(object parameter)
        {
            _dockService.ShowSsView<SsTextEditorView>();
        }

        private void ShowSsWebBrowserView(object parameter)
        {
            _dockService.ShowSsView<SsWebBrowserView>();
        }

        private void ShowSsWebServerView(object parameter)
        {
            _dockService.ShowSsView<SsWebServerView>();
        }

        #endregion


        #region Linux

        private void ShowSsLinuxFileExplorerView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxFileExplorerView>();
        }

        private void ShowSsLinuxNetworkView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxNetworkView>();
        }

        private void ShowSsTerminalView(object parameter)
        {
            _dockService.ShowSsView<SsTerminalView>();
        }

        #endregion


        #region Windows

        private void ShowSsArpView(object parameter)
        {
            _dockService.ShowSsView<SsArpView>();
        }

        private void ShowSsCommandPromptView(object parameter)
        {
            _dockService.ShowSsView<SsCommandPromptView>();
        }

        private void ShowSsWindowsFileExplorerView(object parameter)
        {
            _dockService.ShowSsView<SsWindowsFileExplorerView>();
        }

        private void ShowSsWindowsNetworkView(object parameter)
        {
            _dockService.ShowSsView<SsWindowsNetworkView>();
        }

        private void ShowSsRegistryEditorView(object parameter)
        {
            _dockService.ShowSsView<SsRegistryEditorView>();
        }

        #endregion


        #region Code Editor

        private void ShowSsBashScriptView(object parameter)
        {
            _dockService.ShowSsView<SsBashScriptView>();
        }

        private void ShowSsBatchScriptView(object parameter)
        {
            _dockService.ShowSsView<SsBatchScriptView>();
        }

        private void ShowSsCPlusPlusView(object parameter)
        {
            _dockService.ShowSsView<SsCPlusPlusView>();
        }

        private void ShowSsCSharpView(object parameter)
        {
            _dockService.ShowSsView<SsCSharpView>();
        }

        private void ShowSsPowerShellScriptView(object parameter)
        {
            _dockService.ShowSsView<SsPowerShellScriptView>();
        }

        private void ShowSsPythonView(object parameter)
        {
            _dockService.ShowSsView<SsPythonView>();
        }

        #endregion


        #region Database

        private void ShowSsMongoDbView(object parameter)
        {
            _dockService.ShowSsView<SsMongoDbView>();
        }

        private void ShowSsMySqlView(object parameter)
        {
            _dockService.ShowSsView<SsMySqlView>();
        }

        private void ShowSsOracleView(object parameter)
        {
            _dockService.ShowSsView<SsOracleView>();
        }

        private void ShowSsSqlServerView(object parameter)
        {
            _dockService.ShowSsView<SsSqlServerView>();
        }

        #endregion


        #region Web Pen Test


        #endregion


        #region Mobile Pen Test


        #endregion


        #region Network Pen Test


        #endregion


        #region Definition

        private void ShowSsAndroidOperatingSystemListView(object parameter)
        {
            _dockService.ShowSsView<SsAndroidOperatingSystemListView>();
        }

        private void ShowSsLinuxOperatingSystemListView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxOperatingSystemListView>();
        }

        private void ShowSsWindowsOperatingSystemListView(object parameter)
        {
            _dockService.ShowSsView<SsWindowsOperatingSystemListView>();
        }

        #endregion


        protected override void PrepareVariables()
        {
            Title = "Security Studio";
        }

        protected override void FillData()
        {
            FillAndroidOperatingSystems();
            FillLinuxOperatingSystems();
            FillWindowsOperatingSystems();
            //FillThemes();
        }

        private void FillAndroidOperatingSystems()
        {
            AndroidOperatingSystems = new ObservableCollection<AndroidOperatingSystem>(
                _sessionService.GetAndroidOperatingSystems());
            CurrentAndroidOperatingSystem = AndroidOperatingSystems.FirstOrDefault();
        }

        private void FillLinuxOperatingSystems()
        {
            LinuxOperatingSystems = new ObservableCollection<LinuxOperatingSystem>(
                _sessionService.GetLinuxOperatingSystems());
            CurrentLinuxOperatingSystem = LinuxOperatingSystems.FirstOrDefault();
        }

        private void FillWindowsOperatingSystems()
        {
            WindowsOperatingSystems = new ObservableCollection<WindowsOperatingSystem>(
                _sessionService.GetWindowsOperatingSystems());
            CurrentWindowsOperatingSystem = WindowsOperatingSystems.FirstOrDefault();
        }

        //private void FillThemes()
        //{
        //    Themes = new ObservableCollection<string>
        //    {
        //        "DXStyle",
        //        "Office2013DarkGray",
        //        "Office2010Blue",
        //        "Office2010Silver",
        //        "VS2017Light",
        //        "VS2017Blue",
        //        "VS2019Light",
        //        "VS2019Blue",
        //        "Office2013",
        //        "Office2013LightGray",
        //        "Office2016White",
        //        "Office2016Colorful",
        //        "Office2016WhiteSE",
        //        "Office2016ColorfulSE",
        //        "Office2019White",
        //        "Office2019Colorful",
        //        "Win10Light"
        //    };
        //}

        public override void SsViewLoaded()
        {
            _dockService.ShowSsView<SsDashboardView>();
            _dockService.ShowSsView<SsTestView>();
        }

        private ObservableCollection<AndroidOperatingSystem> _androidOperatingSystems;
        public ObservableCollection<AndroidOperatingSystem> AndroidOperatingSystems
        {
            get => _androidOperatingSystems;
            set
            {
                _androidOperatingSystems = value;
                OnPropertyChanged();
            }
        }

        private AndroidOperatingSystem _currentAndroidOperatingSystem;
        public AndroidOperatingSystem CurrentAndroidOperatingSystem
        {
            get => _currentAndroidOperatingSystem;
            set
            {
                _currentAndroidOperatingSystem = value;
                OnPropertyChanged();
                _sessionService.SetAndroidOperatingSystem(CurrentAndroidOperatingSystem);
            }
        }

        private ObservableCollection<LinuxOperatingSystem> _linuxOperatingSystems;
        public ObservableCollection<LinuxOperatingSystem> LinuxOperatingSystems
        {
            get => _linuxOperatingSystems;
            set
            {
                _linuxOperatingSystems = value;
                OnPropertyChanged();
            }
        }

        private LinuxOperatingSystem _currentLinuxOperatingSystem;
        public LinuxOperatingSystem CurrentLinuxOperatingSystem
        {
            get => _currentLinuxOperatingSystem;
            set
            {
                _currentLinuxOperatingSystem = value;
                OnPropertyChanged();
                _sessionService.SetLinuxOperatingSystem(CurrentLinuxOperatingSystem);
            }
        }

        private ObservableCollection<WindowsOperatingSystem> _windowsOperatingSystems;
        public ObservableCollection<WindowsOperatingSystem> WindowsOperatingSystems
        {
            get => _windowsOperatingSystems;
            set
            {
                _windowsOperatingSystems = value;
                OnPropertyChanged();
            }
        }

        private WindowsOperatingSystem _currentWindowsOperatingSystem;
        public WindowsOperatingSystem CurrentWindowsOperatingSystem
        {
            get => _currentWindowsOperatingSystem;
            set
            {
                _currentWindowsOperatingSystem = value;
                OnPropertyChanged();
                _sessionService.SetWindowsOperatingSystem(CurrentWindowsOperatingSystem);
            }
        }

        public override void Dispose()
        {
            _dockService.Dispose();
            _parameterService.Dispose();
        }
    }
}