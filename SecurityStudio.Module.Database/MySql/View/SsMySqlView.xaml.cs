using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Database.MySql.ViewModel;

namespace SecurityStudio.Module.Database.MySql.View
{
    public partial class SsMySqlView : SsView
    {
        public SsMySqlView(SsMySqlViewModel ssMySqlViewModel)
            : base(ssMySqlViewModel)
        {
            InitializeComponent();
        }
    }
}