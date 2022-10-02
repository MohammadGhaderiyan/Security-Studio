using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Pathping.ViewModel;

namespace SecurityStudio.Module.Tool.Pathping.View
{
    public partial class SsPathpingView : SsView
    {
        public SsPathpingView(SsPathpingViewModel ssPathpingViewModel)
            : base(ssPathpingViewModel)
        {
            InitializeComponent();
        }
    }
}