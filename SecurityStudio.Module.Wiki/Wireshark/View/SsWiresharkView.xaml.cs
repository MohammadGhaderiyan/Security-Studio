using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Wireshark.ViewModel;

namespace SecurityStudio.Module.Wiki.Wireshark.View
{
    public partial class SsWiresharkView : SsView
    {
        public SsWiresharkView(SsWiresharkViewModel ssWiresharkViewModel)
            : base(ssWiresharkViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}