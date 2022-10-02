using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.GfiLanGuard.ViewModel;

namespace SecurityStudio.Module.Wiki.GfiLanGuard.View
{
    public partial class SsGfiLanGuardView : SsView
    {
        public SsGfiLanGuardView(SsGfiLanGuardViewModel ssGfiLanGuardViewModel)
            : base(ssGfiLanGuardViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}