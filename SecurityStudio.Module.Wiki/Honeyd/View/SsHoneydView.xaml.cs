using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Honeyd.ViewModel;

namespace SecurityStudio.Module.Wiki.Honeyd.View
{
    public partial class SsHoneydView : SsView
    {
        public SsHoneydView(SsHoneydViewModel ssHoneydViewModel)
            : base(ssHoneydViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}