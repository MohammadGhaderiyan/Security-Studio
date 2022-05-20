using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.WellKnownPorts.ViewModel;

namespace SecurityStudio.Module.Wiki.WellKnownPorts.View
{
    public partial class SsWellKnownPortsView : SsView
    {
        public SsWellKnownPortsView(SsWellKnownPortsViewModel ssWellKnownPortsViewModel)
            : base(ssWellKnownPortsViewModel)
        {
            InitializeComponent();
        }
    }
}