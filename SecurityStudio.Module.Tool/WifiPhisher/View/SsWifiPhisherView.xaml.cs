using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.WifiPhisher.ViewModel;

namespace SecurityStudio.Module.Tool.WifiPhisher.View
{
    public partial class SsWifiPhisherView : SsView
    {
        public SsWifiPhisherView(SsWifiPhisherViewModel ssWifiPhisherViewModel)
            : base(ssWifiPhisherViewModel)
        {
            InitializeComponent();
        }
    }
}