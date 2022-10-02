using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.TheHarvester.ViewModel;

namespace SecurityStudio.Module.Tool.TheHarvester.View
{
    public partial class SsTheHarvesterView : SsView
    {
        public SsTheHarvesterView(SsTheHarvesterViewModel ssTheHarvesterViewModel)
            : base(ssTheHarvesterViewModel)
        {
            InitializeComponent();
        }
    }
}