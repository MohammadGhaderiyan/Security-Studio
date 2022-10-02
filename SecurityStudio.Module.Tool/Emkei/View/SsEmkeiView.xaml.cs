using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Emkei.ViewModel;

namespace SecurityStudio.Module.Tool.Emkei.View
{
    public partial class SsEmkeiView : SsView
    {
        public SsEmkeiView(SsEmkeiViewModel ssEmkeiViewModel)
            : base(ssEmkeiViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}