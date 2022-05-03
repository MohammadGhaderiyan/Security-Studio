using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Main.Login.ViewModel;

namespace SecurityStudio.Module.Main.Login.View
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