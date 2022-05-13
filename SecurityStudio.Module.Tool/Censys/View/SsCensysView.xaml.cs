using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Censys.ViewModel;

namespace SecurityStudio.Module.Tool.Censys.View
{
    public partial class SsCensysView : SsView
    {
        public SsCensysView(SsCensysViewModel ssCensysViewModel)
            : base(ssCensysViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsCensysViewModel)SsViewModel).WebBrowser = WebBrowserMain;
        }
    }
}