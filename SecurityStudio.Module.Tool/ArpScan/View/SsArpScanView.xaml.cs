using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.ArpScan.ViewModel;

namespace SecurityStudio.Module.Tool.ArpScan.View
{
    public partial class SsArpScanView : SsView
    {
        public SsArpScanView(SsArpScanViewModel ssArpScanViewModel)
            : base(ssArpScanViewModel)
        {
            InitializeComponent();
        }
    }
}