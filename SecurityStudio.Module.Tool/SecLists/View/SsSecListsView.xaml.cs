using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SecLists.ViewModel;

namespace SecurityStudio.Module.Tool.SecLists.View
{
    public partial class SsSecListsView : SsView
    {
        public SsSecListsView(SsSecListsViewModel ssSecListsViewModel)
            : base(ssSecListsViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}