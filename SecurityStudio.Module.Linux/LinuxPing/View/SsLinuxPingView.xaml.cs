using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.LinuxPing.ViewModel;

namespace SecurityStudio.Module.Linux.LinuxPing.View
{
    public partial class SsLinuxPingView : SsView
    {
        public SsLinuxPingView(SsLinuxPingViewModel ssLinuxPingViewModel)
            : base(ssLinuxPingViewModel)
        {
            InitializeComponent();
        }
    }
}