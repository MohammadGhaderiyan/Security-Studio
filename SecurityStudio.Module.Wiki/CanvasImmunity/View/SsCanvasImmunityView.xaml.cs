using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.CanvasImmunity.ViewModel;

namespace SecurityStudio.Module.Wiki.CanvasImmunity.View
{
    public partial class SsCanvasImmunityView : SsView
    {
        public SsCanvasImmunityView(SsCanvasImmunityViewModel ssCanvasImmunityViewModel)
            : base(ssCanvasImmunityViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}