using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.HpWebInsPect.ViewModel;

namespace SecurityStudio.Module.Wiki.HpWebInsPect.View
{
    public partial class SsHpWebInsPectView : SsView
    {
        public SsHpWebInsPectView(SsHpWebInsPectViewModel ssHpWebInsPectViewModel)
            : base(ssHpWebInsPectViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}