using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SkipFish.ViewModel;

namespace SecurityStudio.Module.Tool.SkipFish.View
{
    public partial class SsSkipFishView : SsView
    {
        public SsSkipFishView(SsSkipFishViewModel ssSkipFishViewModel)
            : base(ssSkipFishViewModel)
        {
            InitializeComponent();
        }
    }
}