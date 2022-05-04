using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.AndroidOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.AndroidOperatingSystem.View
{
    public partial class SsAndroidOperatingSystemListView : SsView
    {
        public SsAndroidOperatingSystemListView(
            SsAndroidOperatingSystemListViewModel ssAndroidOperatingSystemListViewModel)
            : base(ssAndroidOperatingSystemListViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditSearch.Focus();
        }
    }
}