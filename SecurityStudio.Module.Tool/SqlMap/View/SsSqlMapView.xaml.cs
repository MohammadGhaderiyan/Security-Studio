using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SqlMap.ViewModel;

namespace SecurityStudio.Module.Tool.SqlMap.View
{
    public partial class SsSqlMapView : SsView
    {
        public SsSqlMapView(SsSqlMapViewModel ssSqlMapViewModel)
            : base(ssSqlMapViewModel)
        {
            InitializeComponent();
        }
    }
}