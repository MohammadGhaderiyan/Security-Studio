using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Application.Login.ViewModel;

namespace SecurityStudio.Module.Application.Login.View
{
    public partial class SsLoginView : SsView
    {
        public SsLoginView(SsLoginViewModel ssLoginViewModel)
            : base(ssLoginViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
            SsTextEditUserName.Focus();
        }
    }
}