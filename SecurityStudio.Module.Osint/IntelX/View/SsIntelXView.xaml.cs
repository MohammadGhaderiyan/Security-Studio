using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.IntelX.ViewModel;

namespace SecurityStudio.Module.Osint.IntelX.View
{
    public partial class SsIntelXView : SsView
    {
        public SsIntelXView(SsIntelXViewModel ssIntelXViewModel)
            : base(ssIntelXViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}