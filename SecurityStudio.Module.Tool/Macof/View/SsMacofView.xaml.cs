using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Macof.ViewModel;

namespace SecurityStudio.Module.Tool.Macof.View
{
    public partial class SsMacofView : SsView
    {
        public SsMacofView(SsMacofViewModel ssMacofViewModel)
            : base(ssMacofViewModel)
        {
            InitializeComponent();
        }
    }
}