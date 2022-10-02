using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Dnsenum.ViewModel;

namespace SecurityStudio.Module.Tool.Dnsenum.View
{
    public partial class SsDnsenumView : SsView
    {
        public SsDnsenumView(SsDnsenumViewModel ssDnsenumViewModel)
            : base(ssDnsenumViewModel)
        {
            InitializeComponent();
        }
    }
}