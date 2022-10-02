using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.MacChanger.ViewModel;

namespace SecurityStudio.Module.Tool.MacChanger.View
{
    public partial class SsMacChangerView : SsView
    {
        public SsMacChangerView(SsMacChangerViewModel ssMacChangerViewModel)
            : base(ssMacChangerViewModel)
        {
            InitializeComponent();
        }
    }
}