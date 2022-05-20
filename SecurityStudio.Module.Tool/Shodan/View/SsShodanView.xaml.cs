using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Shodan.ViewModel;

namespace SecurityStudio.Module.Tool.Shodan.View
{
    public partial class SsShodanView : SsView
    {
        public SsShodanView(SsShodanViewModel ssShodanViewModel)
            : base(ssShodanViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsShodanViewModel)SsViewModel).WebBrowser = WebBrowserMain;
        }
    }
}