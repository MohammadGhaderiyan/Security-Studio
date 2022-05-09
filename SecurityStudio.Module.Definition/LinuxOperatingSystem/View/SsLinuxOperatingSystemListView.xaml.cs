using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.LinuxOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.LinuxOperatingSystem.View
{
    public partial class SsLinuxOperatingSystemListView : SsView
    {
        public SsLinuxOperatingSystemListView(
            SsLinuxOperatingSystemListViewModel ssLinuxOperatingSystemListViewModel)
            : base(ssLinuxOperatingSystemListViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditSearch.Focus();
        }
    }
}