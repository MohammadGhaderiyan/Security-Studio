using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.OpenVas.ViewModel;

namespace SecurityStudio.Module.Wiki.OpenVas.View
{
    public partial class SsOpenVASView : SsView
    {
        public SsOpenVASView(SsOpenVASViewModel ssOpenVASViewModel)
            : base(ssOpenVASViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}