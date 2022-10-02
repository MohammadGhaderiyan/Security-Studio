using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Snort.ViewModel;

namespace SecurityStudio.Module.Wiki.Snort.View
{
    public partial class SsSnortView : SsView
    {
        public SsSnortView(SsSnortViewModel ssSnortViewModel)
            : base(ssSnortViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}