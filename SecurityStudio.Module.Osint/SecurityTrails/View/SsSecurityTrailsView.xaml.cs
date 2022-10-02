using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.SecurityTrails.ViewModel;

namespace SecurityStudio.Module.Osint.SecurityTrails.View
{
    public partial class SsSecurityTrailsView : SsView
    {
        public SsSecurityTrailsView(SsSecurityTrailsViewModel ssSecurityTrailsViewModel)
            : base(ssSecurityTrailsViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}