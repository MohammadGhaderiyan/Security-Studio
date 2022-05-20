using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Douran.ViewModel;

namespace SecurityStudio.Module.Tool.Douran.View
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