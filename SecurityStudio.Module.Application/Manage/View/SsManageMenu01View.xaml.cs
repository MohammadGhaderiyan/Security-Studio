using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Application.Manage.ViewModel;

namespace SecurityStudio.Module.Application.Manage.View
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