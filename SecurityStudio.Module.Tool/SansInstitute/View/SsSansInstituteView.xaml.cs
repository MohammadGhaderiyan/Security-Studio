using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SansInstitute.ViewModel;

namespace SecurityStudio.Module.Tool.SansInstitute.View
{
    public partial class SsSansInstituteView : SsView
    {
        public SsSansInstituteView(SsSansInstituteViewModel ssSansInstituteViewModel)
            : base(ssSansInstituteViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}