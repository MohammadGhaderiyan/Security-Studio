using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Nessus.ViewModel;

namespace SecurityStudio.Module.Wiki.Nessus.View
{
    public partial class SsNessusView : SsView
    {
        public SsNessusView(SsNessusViewModel ssNessusViewModel)
            : base(ssNessusViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}