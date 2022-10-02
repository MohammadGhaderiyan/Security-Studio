using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.IdaPro.ViewModel;

namespace SecurityStudio.Module.Wiki.IdaPro.View
{
    public partial class SsIdaProView : SsView
    {
        public SsIdaProView(SsIdaProViewModel ssIdaProViewModel)
            : base(ssIdaProViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}