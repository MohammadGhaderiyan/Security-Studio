using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.HPing.ViewModel;

namespace SecurityStudio.Module.Tool.HPing.View
{
    public partial class SsHPingView : SsView
    {
        public SsHPingView(SsHPingViewModel ssHPingViewModel)
            : base(ssHPingViewModel)
        {
            InitializeComponent();
        }
    }
}