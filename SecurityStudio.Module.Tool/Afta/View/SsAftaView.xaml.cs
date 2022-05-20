using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Afta.ViewModel;

namespace SecurityStudio.Module.Tool.Afta.View
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