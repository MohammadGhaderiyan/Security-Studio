using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.NbtScan.ViewModel;

namespace SecurityStudio.Module.Tool.NbtScan.View
{
    public partial class SsNbtScanView : SsView
    {
        public SsNbtScanView(SsNbtScanViewModel ssNbtScanViewModel)
            : base(ssNbtScanViewModel)
        {
            InitializeComponent();
        }
    }
}