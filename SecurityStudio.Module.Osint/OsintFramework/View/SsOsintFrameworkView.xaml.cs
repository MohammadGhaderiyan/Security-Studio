using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.OsintFramework.ViewModel;

namespace SecurityStudio.Module.Osint.OsintFramework.View
{
    public partial class SsOsintFrameworkView : SsView
    {
        public SsOsintFrameworkView(SsOsintFrameworkViewModel ssOsintFrameworkViewModel)
            : base(ssOsintFrameworkViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsOsintFrameworkViewModel)SsViewModel).WebBrowser = WebBrowserMain;
        }
    }
}