using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.ImmunityDebugger.ViewModel;

namespace SecurityStudio.Module.Wiki.ImmunityDebugger.View
{
    public partial class SsImmunityDebuggerView : SsView
    {
        public SsImmunityDebuggerView(SsImmunityDebuggerViewModel ssImmunityDebuggerViewModel)
            : base(ssImmunityDebuggerViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}