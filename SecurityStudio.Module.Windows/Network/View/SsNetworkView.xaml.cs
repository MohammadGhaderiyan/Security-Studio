using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.Network.ViewModel;

namespace SecurityStudio.Module.Windows.Network.View
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