using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Netcraft.ViewModel;

namespace SecurityStudio.Module.Tool.Netcraft.View
{
    public partial class SsNetcraftView : SsView
    {
        public SsNetcraftView(SsNetcraftViewModel ssNetcraftViewModel)
            : base(ssNetcraftViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}