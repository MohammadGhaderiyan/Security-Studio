using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.OpenSsl.ViewModel;

namespace SecurityStudio.Module.Tool.OpenSsl.View
{
    public partial class SsOpenSslView : SsView
    {
        public SsOpenSslView(SsOpenSslViewModel ssOpenSslViewModel)
            : base(ssOpenSslViewModel)
        {
            InitializeComponent();
        }
    }
}