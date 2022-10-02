using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Douran.ViewModel;

namespace SecurityStudio.Module.Wiki.Douran.View
{
    public partial class SsDouranView : SsView
    {
        public SsDouranView(SsDouranViewModel ssDouranViewModel)
            : base(ssDouranViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}