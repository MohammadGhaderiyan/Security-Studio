using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Mitre.ViewModel;

namespace SecurityStudio.Module.Wiki.Mitre.View
{
    public partial class SsMitreView : SsView
    {
        public SsMitreView(SsMitreViewModel ssMitreViewModel)
            : base(ssMitreViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}