using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.FtpManager.ViewModel;

namespace SecurityStudio.Module.Tool.FtpManager.View
{
    public partial class SsFtpManagerView : SsView
    {
        public SsFtpManagerView(SsFtpManagerViewModel ssFtpManagerViewModel)
            : base(ssFtpManagerViewModel)
        {
            InitializeComponent();
        }
    }
}