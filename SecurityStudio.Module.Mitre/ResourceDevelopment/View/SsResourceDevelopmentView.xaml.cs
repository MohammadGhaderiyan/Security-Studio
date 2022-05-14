using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.ResourceDevelopment.ViewModel;

namespace SecurityStudio.Module.Mitre.ResourceDevelopment.View
{
    public partial class SsResourceDevelopmentView : SsView
    {
        public SsResourceDevelopmentView(SsResourceDevelopmentViewModel ssResourceDevelopmentViewModel)
            : base(ssResourceDevelopmentViewModel)
        {
            InitializeComponent();
        }
    }
}