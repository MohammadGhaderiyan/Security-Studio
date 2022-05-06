using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.LinuxNetwork.ViewModel;

namespace SecurityStudio.Module.Linux.LinuxNetwork.View
{
    public partial class SsLinuxNetworkView : SsView
    {
        public SsLinuxNetworkView(SsLinuxNetworkViewModel ssLinuxNetworkViewModel)
            : base(ssLinuxNetworkViewModel)
        {
            InitializeComponent();
        }
    }
}