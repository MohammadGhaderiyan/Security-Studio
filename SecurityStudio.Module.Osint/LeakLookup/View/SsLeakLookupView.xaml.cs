using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.LeakLookup.ViewModel;

namespace SecurityStudio.Module.Osint.LeakLookup.View
{
    public partial class SsLeakLookupView : SsView
    {
        public SsLeakLookupView(SsLeakLookupViewModel ssLeakLookupViewModel)
            : base(ssLeakLookupViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}