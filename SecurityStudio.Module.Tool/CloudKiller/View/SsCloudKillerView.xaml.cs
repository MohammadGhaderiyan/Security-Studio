using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.CloudKiller.ViewModel;

namespace SecurityStudio.Module.Tool.CloudKiller.View
{
    public partial class SsCloudKillerView : SsView
    {
        public SsCloudKillerView(SsCloudKillerViewModel ssCloudKillerViewModel)
            : base(ssCloudKillerViewModel)
        {
            InitializeComponent();
        }
    }
}