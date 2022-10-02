using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Bettercap.ViewModel;

namespace SecurityStudio.Module.Wiki.Bettercap.View
{
    public partial class SsBettercapView : SsView
    {
        public SsBettercapView(SsBettercapViewModel ssBettercapViewModel)
            : base(ssBettercapViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}