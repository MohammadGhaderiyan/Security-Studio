using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Mimikatz.ViewModel;

namespace SecurityStudio.Module.Tool.Mimikatz.View
{
    public partial class SsMimikatzView : SsView
    {
        public SsMimikatzView(SsMimikatzViewModel ssMimikatzViewModel)
            : base(ssMimikatzViewModel)
        {
            InitializeComponent();
        }
    }
}