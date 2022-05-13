using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.SocialSearcher.ViewModel;

namespace SecurityStudio.Module.Osint.SocialSearcher.View
{
    public partial class SsSocialSearcherView : SsView
    {
        public SsSocialSearcherView(SsSocialSearcherViewModel ssSocialSearcherViewModel)
            : base(ssSocialSearcherViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            ((SsSocialSearcherViewModel)SsViewModel).WebBrowser = WebBrowserMain;
        }
    }
}