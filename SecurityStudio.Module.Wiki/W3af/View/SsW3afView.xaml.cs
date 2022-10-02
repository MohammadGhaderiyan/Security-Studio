using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.W3af.ViewModel;

namespace SecurityStudio.Module.Wiki.W3af.View
{
    public partial class SsW3afView : SsView
    {
        public SsW3afView(SsW3afViewModel ssW3afViewModel)
            : base(ssW3afViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}