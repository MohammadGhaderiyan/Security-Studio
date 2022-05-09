using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Definition.AndroidOperatingSystem.ViewModel;

namespace SecurityStudio.Module.Definition.AndroidOperatingSystem.View
{
    public partial class SsAndroidOperatingSystemView : SsView
    {
        public SsAndroidOperatingSystemView(SsAndroidOperatingSystemViewModel ssAndroidOperatingSystemViewModel)
            : base(ssAndroidOperatingSystemViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditName.Focus();
        }
    }
}