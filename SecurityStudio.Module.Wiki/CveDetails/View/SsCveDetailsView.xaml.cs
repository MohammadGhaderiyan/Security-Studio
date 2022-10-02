using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.CveDetails.ViewModel;

namespace SecurityStudio.Module.Wiki.CveDetails.View
{
    public partial class SsCveDetailsView : SsView
    {
        public SsCveDetailsView(SsCveDetailsViewModel ssCveDetailsViewModel)
            : base(ssCveDetailsViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}