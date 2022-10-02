using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.CoreImpact.ViewModel;

namespace SecurityStudio.Module.Wiki.CoreImpact.View
{
    public partial class SsCoreImpactView : SsView
    {
        public SsCoreImpactView(SsCoreImpactViewModel ssCoreImpactViewModel)
            : base(ssCoreImpactViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}