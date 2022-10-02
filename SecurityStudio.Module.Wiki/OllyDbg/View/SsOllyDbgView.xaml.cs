using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.OllyDbg.ViewModel;

namespace SecurityStudio.Module.Wiki.OllyDbg.View
{
    public partial class SsOllyDbgView : SsView
    {
        public SsOllyDbgView(SsOllyDbgViewModel ssOllyDbgViewModel)
            : base(ssOllyDbgViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}