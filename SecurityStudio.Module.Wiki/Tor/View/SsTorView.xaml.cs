using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Tor.ViewModel;

namespace SecurityStudio.Module.Wiki.Tor.View
{
    public partial class SsTorView : SsView
    {
        public SsTorView(SsTorViewModel ssTorViewModel)
            : base(ssTorViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}