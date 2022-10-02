using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.EcCouncil.ViewModel;

namespace SecurityStudio.Module.Wiki.EcCouncil.View
{
    public partial class SsEcCouncilView : SsView
    {
        public SsEcCouncilView(SsEcCouncilViewModel ssEcCouncilViewModel)
            : base(ssEcCouncilViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}