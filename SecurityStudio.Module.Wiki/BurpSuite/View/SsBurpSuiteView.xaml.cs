using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.BurpSuite.ViewModel;

namespace SecurityStudio.Module.Wiki.BurpSuite.View
{
    public partial class SsBurpSuiteView : SsView
    {
        public SsBurpSuiteView(SsBurpSuiteViewModel ssBurpSuiteViewModel)
            : base(ssBurpSuiteViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}