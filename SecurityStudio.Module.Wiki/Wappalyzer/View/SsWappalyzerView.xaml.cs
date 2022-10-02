using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Wappalyzer.ViewModel;

namespace SecurityStudio.Module.Wiki.Wappalyzer.View
{
    public partial class SsWappalyzerView : SsView
    {
        public SsWappalyzerView(SsWappalyzerViewModel ssWappalyzerViewModel)
            : base(ssWappalyzerViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}