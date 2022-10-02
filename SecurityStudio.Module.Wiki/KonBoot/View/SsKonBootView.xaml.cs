using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.KonBoot.ViewModel;

namespace SecurityStudio.Module.Wiki.KonBoot.View
{
    public partial class SsKonBootView : SsView
    {
        public SsKonBootView(SsKonBootViewModel ssKonBootViewModel)
            : base(ssKonBootViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}