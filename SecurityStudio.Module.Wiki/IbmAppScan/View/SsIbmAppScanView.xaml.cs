using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.IbmAppScan.ViewModel;

namespace SecurityStudio.Module.Wiki.IbmAppScan.View
{
    public partial class SsIbmAppScanView : SsView
    {
        public SsIbmAppScanView(SsIbmAppScanViewModel ssIbmAppScanViewModel)
            : base(ssIbmAppScanViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}