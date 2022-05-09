using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.LinuxOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.LinuxOperatingSystem.View
{
    public partial class SsLinuxOperatingSystemView : SsView
    {
        public SsLinuxOperatingSystemView(SsLinuxOperatingSystemViewModel ssLinuxOperatingSystemViewModel)
            : base(ssLinuxOperatingSystemViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditName.Focus();
        }
    }
}