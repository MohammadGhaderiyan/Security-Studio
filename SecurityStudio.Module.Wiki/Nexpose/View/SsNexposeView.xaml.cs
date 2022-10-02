using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Nexpose.ViewModel;

namespace SecurityStudio.Module.Wiki.Nexpose.View
{
    public partial class SsNexposeView : SsView
    {
        public SsNexposeView(SsNexposeViewModel ssNexposeViewModel)
            : base(ssNexposeViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}