using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Suricata.ViewModel;

namespace SecurityStudio.Module.Wiki.Suricata.View
{
    public partial class SsSuricataView : SsView
    {
        public SsSuricataView(SsSuricataViewModel ssSuricataViewModel)
            : base(ssSuricataViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}