using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Dashboard.View;
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


        #endregion


        #region Linux


        #endregion


        #region Windows


        #endregion


        #region Code Editor


        #endregion


        #region Database


        #endregion


        #region Web Pen Test


        #endregion


        #region Mobile Pen Test


        #endregion


        #region Network Pen Test


        #endregion


        #region Definition


        #endregion


        protected override void PrepareSsCommands()
        {

            #region Mitre


            #endregion


            #region Tools


            #endregion


            #region Linux


            #endregion


            #region Windows


            #endregion


            #region Code Editor


            #endregion


            #region Database


            #endregion


            #region Web Pen Test


            #endregion


            #region Mobile Pen Test


            #endregion


            #region Network Pen Test


            #endregion


            #region Definition


            #endregion

        }


        #region Mitre


        #endregion


        #region Tools


        #endregion


        #region Linux


        #endregion


        #region Windows


        #endregion


        #region Code Editor


        #endregion


        #region Database


        #endregion


        #region Web Pen Test


        #endregion


        #region Mobile Pen Test


        #endregion


        #region Network Pen Test


        #endregion


        #region Definition


        #endregion


        protected override void PrepareVariables()
        {
            Title = "Security Studio";
        }

        protected override void FillData()
        {
            //FillThemes();
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
        }

        //private ObservableCollection<string> _themes;
        //public ObservableCollection<string> Themes
        //{
        //    get => _themes;
        //    set
        //    {
        //        _themes = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private string _currentTheme;
        //public string CurrentTheme
        //{
        //    get => _currentTheme;
        //    set
        //    {
        //        _currentTheme = value;
        //        OnPropertyChanged();
        //        ApplicationThemeHelper.ApplicationThemeName = CurrentTheme;
        //    }
        //}

        public override void Dispose()
        {
            _dockService.Dispose();
            _parameterService.Dispose();
        }
    }
}