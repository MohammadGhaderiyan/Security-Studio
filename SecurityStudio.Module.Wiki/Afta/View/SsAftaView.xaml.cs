using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Afta.ViewModel;

namespace SecurityStudio.Module.Wiki.Afta.View
{
    public partial class SsAftaView : SsView
    {
        public SsAftaView(SsAftaViewModel ssAftaViewModel)
            : base(ssAftaViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}