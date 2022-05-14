using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Discovery.ViewModel;

namespace SecurityStudio.Module.Mitre.Discovery.View
{
    public partial class SsDiscoveryView : SsView
    {
        public SsDiscoveryView(SsDiscoveryViewModel ssDiscoveryViewModel)
            : base(ssDiscoveryViewModel)
        {
            InitializeComponent();
        }
    }
}