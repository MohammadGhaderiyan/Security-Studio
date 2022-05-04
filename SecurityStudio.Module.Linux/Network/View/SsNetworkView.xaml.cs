using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Network.ViewModel;

namespace SecurityStudio.Module.Linux.Network.View
{
    public partial class SsNetworkView : SsView
    {
        public SsNetworkView(SsNetworkViewModel ssNetworkViewModel)
            : base(ssNetworkViewModel)
        {
            InitializeComponent();
        }
    }
}