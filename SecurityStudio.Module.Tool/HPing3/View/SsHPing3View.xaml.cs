using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.HPing3.ViewModel;

namespace SecurityStudio.Module.Tool.HPing3.View
{
    public partial class SsHPing3View : SsView
    {
        public SsHPing3View(SsHPing3ViewModel ssHPing3ViewModel)
            : base(ssHPing3ViewModel)
        {
            InitializeComponent();
        }
    }
}