using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Wash.ViewModel;

namespace SecurityStudio.Module.Tool.Wash.View
{
    public partial class SsWashView : SsView
    {
        public SsWashView(SsWashViewModel ssWashViewModel)
            : base(ssWashViewModel)
        {
            InitializeComponent();
        }
    }
}