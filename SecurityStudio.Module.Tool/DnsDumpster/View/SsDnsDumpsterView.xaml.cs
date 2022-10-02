using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.DnsDumpster.ViewModel;

namespace SecurityStudio.Module.Tool.DnsDumpster.View
{
    public partial class SsDnsDumpsterView : SsView
    {
        public SsDnsDumpsterView(SsDnsDumpsterViewModel ssDnsDumpsterViewModel)
            : base(ssDnsDumpsterViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}