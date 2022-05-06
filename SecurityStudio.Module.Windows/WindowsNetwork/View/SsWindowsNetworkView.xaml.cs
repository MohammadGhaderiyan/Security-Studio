using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.WindowsNetwork.ViewModel;

namespace SecurityStudio.Module.Windows.WindowsNetwork.View
{
    public partial class SsWindowsNetworkView : SsView
    {
        public SsWindowsNetworkView(SsWindowsNetworkViewModel ssWindowsNetworkViewModel)
            : base(ssWindowsNetworkViewModel)
        {
            InitializeComponent();
        }
    }
}