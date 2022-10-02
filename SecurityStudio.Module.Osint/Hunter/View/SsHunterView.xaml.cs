using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.Hunter.ViewModel;

namespace SecurityStudio.Module.Osint.Hunter.View
{
    public partial class SsHunterView : SsView
    {
        public SsHunterView(SsHunterViewModel ssHunterViewModel)
            : base(ssHunterViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}