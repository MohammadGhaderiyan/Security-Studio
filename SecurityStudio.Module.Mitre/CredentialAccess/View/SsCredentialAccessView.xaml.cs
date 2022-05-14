using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.CredentialAccess.ViewModel;

namespace SecurityStudio.Module.Mitre.CredentialAccess.View
{
    public partial class SsCredentialAccessView : SsView
    {
        public SsCredentialAccessView(SsCredentialAccessViewModel ssCredentialAccessViewModel)
            : base(ssCredentialAccessViewModel)
        {
            InitializeComponent();
        }
    }
}