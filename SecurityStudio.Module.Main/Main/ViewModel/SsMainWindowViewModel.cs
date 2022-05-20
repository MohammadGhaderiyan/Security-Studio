using System.Collections.ObjectModel;
using System.Linq;
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
using SecurityStudio.Module.Exploit.ExploitDb.View;
using SecurityStudio.Module.Linux.Dig.View;
using SecurityStudio.Module.Linux.LinuxFileExplorer.View;
using SecurityStudio.Module.Linux.LinuxNetwork.View;
using SecurityStudio.Module.Linux.LinuxNslookup.View;
using SecurityStudio.Module.Linux.LinuxPing.View;
using SecurityStudio.Module.Linux.Terminal.View;
using SecurityStudio.Module.Main.Dashboard.View;
using SecurityStudio.Module.Main.Test.View;
using SecurityStudio.Module.Mitre.Collection.View;
using SecurityStudio.Module.Mitre.CommandAndControl.View;
using SecurityStudio.Module.Mitre.CredentialAccess.View;
using SecurityStudio.Module.Mitre.DefenseEvasion.View;
using SecurityStudio.Module.Mitre.Discovery.View;
using SecurityStudio.Module.Mitre.Execution.View;
using SecurityStudio.Module.Mitre.Exfiltration.View;
using SecurityStudio.Module.Mitre.Impact.View;
using SecurityStudio.Module.Mitre.InitialAccess.View;
using SecurityStudio.Module.Mitre.LateralMovement.View;
using SecurityStudio.Module.Mitre.Persistence.View;
using SecurityStudio.Module.Mitre.PrivilegeEscalation.View;
using SecurityStudio.Module.Mitre.Reconnaissance.View;
using SecurityStudio.Module.Mitre.ResourceDevelopment.View;
using SecurityStudio.Module.Osint.LeakLookup.View;
using SecurityStudio.Module.Osint.OsintFramework.View;
using SecurityStudio.Module.Osint.SocialSearcher.View;
using SecurityStudio.Module.Osint.Truecaller.View;
using SecurityStudio.Module.Tool.Afta.View;
using SecurityStudio.Module.Tool.ApiPlatform.View;
using SecurityStudio.Module.Tool.Censys.View;
using SecurityStudio.Module.Tool.Douran.View;
using SecurityStudio.Module.Tool.EcCouncil.View;
using SecurityStudio.Module.Tool.Encryption.View;
using SecurityStudio.Module.Tool.Fofa.View;
using SecurityStudio.Module.Tool.FtpManager.View;
using SecurityStudio.Module.Tool.GitHub.View;
using SecurityStudio.Module.Tool.GoogleDork.View;
using SecurityStudio.Module.Tool.Hash.View;
using SecurityStudio.Module.Tool.Iana.View;
using SecurityStudio.Module.Tool.Mimikatz.View;
using SecurityStudio.Module.Tool.Nmap.View;
using SecurityStudio.Module.Tool.SansInstitute.View;
using SecurityStudio.Module.Tool.Shodan.View;
using SecurityStudio.Module.Tool.TextEditor.View;
using SecurityStudio.Module.Tool.WebBrowser.View;
using SecurityStudio.Module.Tool.WebServer.View;
using SecurityStudio.Module.Tool.Whois.View;
using SecurityStudio.Module.Wiki.WellKnownPorts.View;
using SecurityStudio.Module.Windows.Arp.View;
using SecurityStudio.Module.Windows.CommandPrompt.View;
using SecurityStudio.Module.Windows.RegistryEditor.View;
using SecurityStudio.Module.Windows.WindowsFileExplorer.View;
using SecurityStudio.Module.Windows.WindowsNetwork.View;
using SecurityStudio.Module.Windows.WindowsNslookup.View;
using SecurityStudio.Module.Windows.WindowsPing.View;
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


        #region Mitre

        public SsCommand ShowSsReconnaissanceViewCommand { get; set; }
        public SsCommand ShowSsResourceDevelopmentViewCommand { get; set; }
        public SsCommand ShowSsInitialAccessViewCommand { get; set; }
        public SsCommand ShowSsExecutionViewCommand { get; set; }
        public SsCommand ShowSsPersistenceViewCommand { get; set; }
        public SsCommand ShowSsPrivilegeEscalationViewCommand { get; set; }
        public SsCommand ShowSsDefenseEvasionViewCommand { get; set; }
        public SsCommand ShowSsCredentialAccessViewCommand { get; set; }
        public SsCommand ShowSsDiscoveryViewCommand { get; set; }
        public SsCommand ShowSsLateralMovementViewCommand { get; set; }
        public SsCommand ShowSsCollectionViewCommand { get; set; }
        public SsCommand ShowSsCommandAndControlViewCommand { get; set; }
        public SsCommand ShowSsExfiltrationViewCommand { get; set; }
        public SsCommand ShowSsImpactViewCommand { get; set; }

        #endregion


        #region Tools

        public SsCommand ShowSsAftaViewCommand { get; set; }
        public SsCommand ShowSsApiPlatformViewCommand { get; set; }
        public SsCommand ShowSsCensysViewCommand { get; set; }
        public SsCommand ShowSsDouranViewCommand { get; set; }
        public SsCommand ShowSsEcCouncilViewCommand { get; set; }
        public SsCommand ShowSsEncryptionViewCommand { get; set; }
        public SsCommand ShowSsFofaViewCommand { get; set; }
        public SsCommand ShowSsFtpManagerViewCommand { get; set; }
        public SsCommand ShowSsGitHubViewCommand { get; set; }
        public SsCommand ShowSsGoogleDorkViewCommand { get; set; }
        public SsCommand ShowSsHashViewCommand { get; set; }
        public SsCommand ShowSsIanaViewCommand { get; set; }
        public SsCommand ShowSsMimikatzViewCommand { get; set; }
        public SsCommand ShowSsNmapViewCommand { get; set; }
        public SsCommand ShowSsSansInstituteViewCommand { get; set; }
        public SsCommand ShowSsShodanViewCommand { get; set; }
        public SsCommand ShowSsTextEditorViewCommand { get; set; }
        public SsCommand ShowSsWebBrowserViewCommand { get; set; }
        public SsCommand ShowSsWebServerViewCommand { get; set; }
        public SsCommand ShowSsWhoisViewCommand { get; set; }

        #endregion


        #region Linux

        public SsCommand ShowSsDigViewCommand { get; set; }
        public SsCommand ShowSsLinuxFileExplorerViewCommand { get; set; }
        public SsCommand ShowSsLinuxNetworkViewCommand { get; set; }
        public SsCommand ShowSsLinuxNslookupViewCommand { get; set; }
        public SsCommand ShowSsLinuxPingViewCommand { get; set; }
        public SsCommand ShowSsTerminalViewCommand { get; set; }

        #endregion


        #region Windows

        public SsCommand ShowSsArpViewCommand { get; set; }
        public SsCommand ShowSsCommandPromptViewCommand { get; set; }
        public SsCommand ShowSsWindowsFileExplorerViewCommand { get; set; }
        public SsCommand ShowSsWindowsNetworkViewCommand { get; set; }
        public SsCommand ShowSsWindowsNslookupViewCommand { get; set; }
        public SsCommand ShowSsRegistryEditorViewCommand { get; set; }
        public SsCommand ShowSsWindowsPingViewCommand { get; set; }

        #endregion


        #region OSINT

        public SsCommand ShowSsLeakLookupViewCommand { get; set; }
        public SsCommand ShowSsOsintFrameworkViewCommand { get; set; }
        public SsCommand ShowSsSocialSearcherViewCommand { get; set; }
        public SsCommand ShowSsTruecallerViewCommand { get; set; }

        #endregion


        #region Exploit

        public SsCommand ShowSsExploitDbViewCommand { get; set; }

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


        #region Wiki

        public SsCommand ShowSsWellKnownPortsViewCommand { get; set; }

        #endregion

        protected override void PrepareSsCommands()
        {
            #region Mitre

            ShowSsReconnaissanceViewCommand = new SsCommand(ShowSsReconnaissanceView);
            ShowSsResourceDevelopmentViewCommand = new SsCommand(ShowSsResourceDevelopmentView);
            ShowSsInitialAccessViewCommand = new SsCommand(ShowSsInitialAccessView);
            ShowSsExecutionViewCommand = new SsCommand(ShowSsExecutionView);
            ShowSsPersistenceViewCommand = new SsCommand(ShowSsPersistenceView);
            ShowSsPrivilegeEscalationViewCommand = new SsCommand(ShowSsPrivilegeEscalationView);
            ShowSsDefenseEvasionViewCommand = new SsCommand(ShowSsDefenseEvasionView);
            ShowSsCredentialAccessViewCommand = new SsCommand(ShowSsCredentialAccessView);
            ShowSsDiscoveryViewCommand = new SsCommand(ShowSsDiscoveryView);
            ShowSsLateralMovementViewCommand = new SsCommand(ShowSsLateralMovementView);
            ShowSsCollectionViewCommand = new SsCommand(ShowSsCollectionView);
            ShowSsCommandAndControlViewCommand = new SsCommand(ShowSsCommandAndControlView);
            ShowSsExfiltrationViewCommand = new SsCommand(ShowSsExfiltrationView);
            ShowSsImpactViewCommand = new SsCommand(ShowSsImpactView);

            #endregion


            #region Tools

            ShowSsAftaViewCommand = new SsCommand(ShowSsAftaView);
            ShowSsApiPlatformViewCommand = new SsCommand(ShowSsApiPlatformView);
            ShowSsCensysViewCommand = new SsCommand(ShowSsCensysView);
            ShowSsDouranViewCommand = new SsCommand(ShowSsDouranView);
            ShowSsEcCouncilViewCommand = new SsCommand(ShowSsEcCouncilView);
            ShowSsEncryptionViewCommand = new SsCommand(ShowSsEncryptionView);
            ShowSsFofaViewCommand = new SsCommand(ShowSsFofaView);
            ShowSsFtpManagerViewCommand = new SsCommand(ShowSsFtpManagerView);
            ShowSsGitHubViewCommand = new SsCommand(ShowSsGitHubView);
            ShowSsGoogleDorkViewCommand = new SsCommand(ShowSsGoogleDorkView);
            ShowSsHashViewCommand = new SsCommand(ShowSsHashView);
            ShowSsIanaViewCommand = new SsCommand(ShowSsIanaView);
            ShowSsMimikatzViewCommand = new SsCommand(ShowSsMimikatzView);
            ShowSsNmapViewCommand = new SsCommand(ShowSsNmapView);
            ShowSsSansInstituteViewCommand = new SsCommand(ShowSsSansInstituteView);
            ShowSsShodanViewCommand = new SsCommand(ShowSsShodanView);
            ShowSsTextEditorViewCommand = new SsCommand(ShowSsTextEditorView);
            ShowSsWebBrowserViewCommand = new SsCommand(ShowSsWebBrowserView);
            ShowSsWebServerViewCommand = new SsCommand(ShowSsWebServerView);
            ShowSsWhoisViewCommand = new SsCommand(ShowSsWhoisView);

            #endregion


            #region Linux

            ShowSsDigViewCommand = new SsCommand(ShowSsDigView);
            ShowSsLinuxFileExplorerViewCommand = new SsCommand(ShowSsLinuxFileExplorerView);
            ShowSsLinuxNetworkViewCommand = new SsCommand(ShowSsLinuxNetworkView);
            ShowSsLinuxNslookupViewCommand = new SsCommand(ShowSsLinuxNslookupView);
            ShowSsLinuxPingViewCommand = new SsCommand(ShowSsLinuxPingView);
            ShowSsTerminalViewCommand = new SsCommand(ShowSsTerminalView);

            #endregion


            #region Windows

            ShowSsArpViewCommand = new SsCommand(ShowSsArpView);
            ShowSsCommandPromptViewCommand = new SsCommand(ShowSsCommandPromptView);
            ShowSsWindowsFileExplorerViewCommand = new SsCommand(ShowSsWindowsFileExplorerView);
            ShowSsWindowsNetworkViewCommand = new SsCommand(ShowSsWindowsNetworkView);
            ShowSsWindowsNslookupViewCommand = new SsCommand(ShowSsWindowsNslookupView);
            ShowSsRegistryEditorViewCommand = new SsCommand(ShowSsRegistryEditorView);
            ShowSsWindowsPingViewCommand = new SsCommand(ShowSsWindowsPingView);

            #endregion


            #region OSINT

            ShowSsLeakLookupViewCommand = new SsCommand(ShowSsLeakLookupView);
            ShowSsOsintFrameworkViewCommand = new SsCommand(ShowSsOsintFrameworkView);
            ShowSsSocialSearcherViewCommand = new SsCommand(ShowSsSocialSearcherView);
            ShowSsTruecallerViewCommand = new SsCommand(ShowSsTruecallerView);

            #endregion


            #region Exploit

            ShowSsExploitDbViewCommand = new SsCommand(ShowSsExploitDbView);

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


            #region Wiki

            ShowSsWellKnownPortsViewCommand = new SsCommand(ShowSsWellKnownPortsView);

            #endregion
        }


        #region Mitre

        private void ShowSsReconnaissanceView(object parameter)
        {
            _dockService.ShowSsView<SsReconnaissanceView>();
        }

        private void ShowSsResourceDevelopmentView(object parameter)
        {
            _dockService.ShowSsView<SsResourceDevelopmentView>();
        }

        private void ShowSsInitialAccessView(object parameter)
        {
            _dockService.ShowSsView<SsInitialAccessView>();
        }

        private void ShowSsExecutionView(object parameter)
        {
            _dockService.ShowSsView<SsExecutionView>();
        }

        private void ShowSsPersistenceView(object parameter)
        {
            _dockService.ShowSsView<SsPersistenceView>();
        }

        private void ShowSsPrivilegeEscalationView(object parameter)
        {
            _dockService.ShowSsView<SsPrivilegeEscalationView>();
        }

        private void ShowSsDefenseEvasionView(object parameter)
        {
            _dockService.ShowSsView<SsDefenseEvasionView>();
        }

        private void ShowSsCredentialAccessView(object parameter)
        {
            _dockService.ShowSsView<SsCredentialAccessView>();
        }

        private void ShowSsDiscoveryView(object parameter)
        {
            _dockService.ShowSsView<SsDiscoveryView>();
        }

        private void ShowSsLateralMovementView(object parameter)
        {
            _dockService.ShowSsView<SsLateralMovementView>();
        }

        private void ShowSsCollectionView(object parameter)
        {
            _dockService.ShowSsView<SsCollectionView>();
        }

        private void ShowSsCommandAndControlView(object parameter)
        {
            _dockService.ShowSsView<SsCommandAndControlView>();
        }

        private void ShowSsExfiltrationView(object parameter)
        {
            _dockService.ShowSsView<SsExfiltrationView>();
        }

        private void ShowSsImpactView(object parameter)
        {
            _dockService.ShowSsView<SsImpactView>();
        }

        #endregion


        #region Tools

        private void ShowSsAftaView(object parameter)
        {
            _dockService.ShowSsView<SsAftaView>();
        }

        private void ShowSsApiPlatformView(object parameter)
        {
            _dockService.ShowSsView<SsApiPlatformView>();
        }

        private void ShowSsCensysView(object parameter)
        {
            _dockService.ShowSsView<SsCensysView>();
        }

        private void ShowSsDouranView(object parameter)
        {
            _dockService.ShowSsView<SsDouranView>();
        }

        private void ShowSsEcCouncilView(object parameter)
        {
            _dockService.ShowSsView<SsEcCouncilView>();
        }

        private void ShowSsEncryptionView(object parameter)
        {
            _dockService.ShowSsView<SsEncryptionView>();
        }

        private void ShowSsFofaView(object parameter)
        {
            _dockService.ShowSsView<SsFofaView>();
        }

        private void ShowSsFtpManagerView(object parameter)
        {
            _dockService.ShowSsView<SsFtpManagerView>();
        }

        private void ShowSsGitHubView(object parameter)
        {
            _dockService.ShowSsView<SsGitHubView>();
        }

        private void ShowSsGoogleDorkView(object parameter)
        {
            _dockService.ShowSsView<SsGoogleDorkView>();
        }

        private void ShowSsHashView(object parameter)
        {
            _dockService.ShowSsView<SsHashView>();
        }

        private void ShowSsIanaView(object parameter)
        {
            _dockService.ShowSsView<SsIanaView>();
        }

        private void ShowSsMimikatzView(object parameter)
        {
            _dockService.ShowSsView<SsMimikatzView>();
        }

        private void ShowSsNmapView(object parameter)
        {
            _dockService.ShowSsView<SsNmapView>();
        }

        private void ShowSsSansInstituteView(object parameter)
        {
            _dockService.ShowSsView<SsSansInstituteView>();
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

        private void ShowSsWhoisView(object parameter)
        {
            _dockService.ShowSsView<SsWhoisView>();
        }

        #endregion


        #region Linux

        private void ShowSsDigView(object parameter)
        {
            _dockService.ShowSsView<SsDigView>();
        }

        private void ShowSsLinuxFileExplorerView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxFileExplorerView>();
        }

        private void ShowSsLinuxNetworkView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxNetworkView>();
        }

        private void ShowSsLinuxNslookupView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxNslookupView>();
        }

        private void ShowSsLinuxPingView(object parameter)
        {
            _dockService.ShowSsView<SsLinuxPingView>();
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

        private void ShowSsWindowsNslookupView(object parameter)
        {
            _dockService.ShowSsView<SsWindowsNslookupView>();
        }

        private void ShowSsRegistryEditorView(object parameter)
        {
            _dockService.ShowSsView<SsRegistryEditorView>();
        }

        private void ShowSsWindowsPingView(object parameter)
        {
            _dockService.ShowSsView<SsWindowsPingView>();
        }

        #endregion


        #region OSINT

        private void ShowSsLeakLookupView(object parameter)
        {
            _dockService.ShowSsView<SsLeakLookupView>();
        }

        private void ShowSsOsintFrameworkView(object parameter)
        {
            _dockService.ShowSsView<SsOsintFrameworkView>();
        }

        private void ShowSsSocialSearcherView(object parameter)
        {
            _dockService.ShowSsView<SsSocialSearcherView>();
        }

        private void ShowSsTruecallerView(object parameter)
        {
            _dockService.ShowSsView<SsTruecallerView>();
        }

        #endregion


        #region Exploit

        private void ShowSsExploitDbView(object parameter)
        {
            _dockService.ShowSsView<SsExploitDbView>();
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


        #region Wiki

        private void ShowSsWellKnownPortsView(object parameter)
        {
            _dockService.ShowSsView<SsWellKnownPortsView>();
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