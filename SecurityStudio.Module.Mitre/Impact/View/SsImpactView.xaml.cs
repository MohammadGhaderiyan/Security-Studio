using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Impact.ViewModel;

namespace SecurityStudio.Module.Mitre.Impact.View
{
    public partial class SsImpactView : SsView
    {
        public SsImpactView(SsImpactViewModel ssImpactViewModel)
            : base(ssImpactViewModel)
        {
            InitializeComponent();
        }
    }
}