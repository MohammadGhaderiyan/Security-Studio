using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Test.ViewModel;

namespace SecurityStudio.Module.Main.Test.View
{
    public partial class SsTestView : SsView
    {
        public SsTestView(SsTestViewModel ssTestViewModel)
            : base(ssTestViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}