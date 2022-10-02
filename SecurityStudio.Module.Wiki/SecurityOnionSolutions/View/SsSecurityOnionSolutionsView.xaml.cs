using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.SecurityOnionSolutions.ViewModel;

namespace SecurityStudio.Module.Wiki.SecurityOnionSolutions.View
{
    public partial class SsSecurityOnionSolutionsView : SsView
    {
        public SsSecurityOnionSolutionsView(
            SsSecurityOnionSolutionsViewModel ssSecurityOnionSolutionsViewModel)
            : base(ssSecurityOnionSolutionsViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}