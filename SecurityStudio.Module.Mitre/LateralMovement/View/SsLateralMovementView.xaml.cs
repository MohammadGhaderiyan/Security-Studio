using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.LateralMovement.ViewModel;

namespace SecurityStudio.Module.Mitre.LateralMovement.View
{
    public partial class SsLateralMovementView : SsView
    {
        public SsLateralMovementView(SsLateralMovementViewModel ssLateralMovementViewModel)
            : base(ssLateralMovementViewModel)
        {
            InitializeComponent();
        }
    }
}