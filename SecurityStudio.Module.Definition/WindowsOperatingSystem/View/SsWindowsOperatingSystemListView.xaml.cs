using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.WindowsOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.WindowsOperatingSystem.View
{
    public partial class SsWindowsOperatingSystemListView : SsView
    {
        public SsWindowsOperatingSystemListView(
            SsWindowsOperatingSystemListViewModel ssWindowsOperatingSystemListViewModel)
            : base(ssWindowsOperatingSystemListViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditSearch.Focus();
        }
    }
}