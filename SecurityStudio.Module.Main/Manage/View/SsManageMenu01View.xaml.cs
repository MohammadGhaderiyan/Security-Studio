using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Manage.ViewModel;

namespace SecurityStudio.Module.Main.Manage.View
{
    public partial class SsManageMenu01View : SsView
    {
        public SsManageMenu01View(SsManageMenu01ViewModel ssManageMenu01ViewModel)
            : base(ssManageMenu01ViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}