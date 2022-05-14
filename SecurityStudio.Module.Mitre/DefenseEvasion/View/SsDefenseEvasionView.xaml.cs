using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.DefenseEvasion.ViewModel;

namespace SecurityStudio.Module.Mitre.DefenseEvasion.View
{
    public partial class SsDefenseEvasionView : SsView
    {
        public SsDefenseEvasionView(SsDefenseEvasionViewModel ssDefenseEvasionViewModel)
            : base(ssDefenseEvasionViewModel)
        {
            InitializeComponent();
        }
    }
}