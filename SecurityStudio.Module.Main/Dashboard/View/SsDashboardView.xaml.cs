using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Dashboard.ViewModel;

namespace SecurityStudio.Module.Main.Dashboard.View
{
    public partial class SsDashboardView : SsView
    {
        public SsDashboardView(SsDashboardViewModel ssDashboardViewModel)
            : base(ssDashboardViewModel)
        {
            InitializeComponent();
        }
    }
}