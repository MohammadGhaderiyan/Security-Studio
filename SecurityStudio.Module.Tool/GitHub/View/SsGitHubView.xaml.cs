using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.GitHub.ViewModel;

namespace SecurityStudio.Module.Tool.GitHub.View
{
    public partial class SsGitHubView : SsView
    {
        public SsGitHubView(SsGitHubViewModel ssGitHubViewModel)
            : base(ssGitHubViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}