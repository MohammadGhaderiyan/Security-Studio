using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.EcCouncil.ViewModel;

namespace SecurityStudio.Module.Tool.EcCouncil.View
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