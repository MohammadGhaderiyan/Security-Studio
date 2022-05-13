using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.LinuxNslookup.ViewModel;

namespace SecurityStudio.Module.Linux.LinuxNslookup.View
{
    public partial class SsLinuxNslookupView : SsView
    {
        public SsLinuxNslookupView(SsLinuxNslookupViewModel ssLinuxNslookupViewModel)
            : base(ssLinuxNslookupViewModel)
        {
            InitializeComponent();
        }
    }
}