using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.PrivilegeEscalation.ViewModel;

namespace SecurityStudio.Module.Mitre.PrivilegeEscalation.View
{
    public partial class SsPrivilegeEscalationView : SsView
    {
        public SsPrivilegeEscalationView(SsPrivilegeEscalationViewModel ssPrivilegeEscalationViewModel)
            : base(ssPrivilegeEscalationViewModel)
        {
            InitializeComponent();
        }
    }
}