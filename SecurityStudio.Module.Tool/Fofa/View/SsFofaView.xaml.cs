using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Fofa.ViewModel;

namespace SecurityStudio.Module.Tool.Fofa.View
{
    public partial class SsFofaView : SsView
    {
        public SsFofaView(SsFofaViewModel ssFofaViewModel)
            : base(ssFofaViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}