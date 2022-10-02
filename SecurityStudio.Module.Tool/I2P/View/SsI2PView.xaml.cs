using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.I2P.ViewModel;

namespace SecurityStudio.Module.Tool.I2P.View
{
    public partial class SsI2PView : SsView
    {
        public SsI2PView(SsI2PViewModel ssI2PViewModel)
            : base(ssI2PViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}