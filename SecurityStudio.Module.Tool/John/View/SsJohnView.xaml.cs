using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.John.ViewModel;

namespace SecurityStudio.Module.Tool.John.View
{
    public partial class SsJohnView : SsView
    {
        public SsJohnView(SsJohnViewModel ssJohnViewModel)
            : base(ssJohnViewModel)
        {
            InitializeComponent();
        }
    }
}