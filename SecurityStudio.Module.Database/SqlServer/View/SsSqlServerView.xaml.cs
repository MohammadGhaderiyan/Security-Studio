using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Database.SqlServer.ViewModel;

namespace SecurityStudio.Module.Database.SqlServer.View
{
    public partial class SsSqlServerView : SsView
    {
        public SsSqlServerView(SsSqlServerViewModel ssSqlServerViewModel)
            : base(ssSqlServerViewModel)
        {
            InitializeComponent();
        }
    }
}