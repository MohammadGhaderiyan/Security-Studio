using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.InitialAccess.ViewModel;

namespace SecurityStudio.Module.Mitre.InitialAccess.View
{
    public partial class SsInitialAccessView : SsView
    {
        public SsInitialAccessView(SsInitialAccessViewModel ssInitialAccessViewModel)
            : base(ssInitialAccessViewModel)
        {
            InitializeComponent();
        }
    }
}