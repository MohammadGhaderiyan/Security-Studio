using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Application.Dashboard.ViewModel;

namespace SecurityStudio.Module.Application.Dashboard.View
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