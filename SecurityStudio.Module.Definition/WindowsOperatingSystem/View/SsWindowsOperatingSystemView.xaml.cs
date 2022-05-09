using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.WindowsOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.WindowsOperatingSystem.View
{
    public partial class SsWindowsOperatingSystemView : SsView
    {
        public SsWindowsOperatingSystemView(SsWindowsOperatingSystemViewModel ssWindowsOperatingSystemViewModel)
            : base(ssWindowsOperatingSystemViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditName.Focus();
        }
    }
}