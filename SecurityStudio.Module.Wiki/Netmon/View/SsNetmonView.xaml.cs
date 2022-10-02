using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Netmon.ViewModel;

namespace SecurityStudio.Module.Wiki.Netmon.View
{
    public partial class SsNetmonView : SsView
    {
        public SsNetmonView(SsNetmonViewModel ssNetmonViewModel)
            : base(ssNetmonViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}