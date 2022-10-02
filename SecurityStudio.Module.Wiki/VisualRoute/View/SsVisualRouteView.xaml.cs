using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.VisualRoute.ViewModel;

namespace SecurityStudio.Module.Wiki.VisualRoute.View
{
    public partial class SsVisualRouteView : SsView
    {
        public SsVisualRouteView(SsVisualRouteViewModel ssVisualRouteViewModel)
            : base(ssVisualRouteViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}