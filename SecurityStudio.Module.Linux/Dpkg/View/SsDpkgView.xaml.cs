using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Dpkg.ViewModel;

namespace SecurityStudio.Module.Linux.Dpkg.View
{
    public partial class SsDpkgView : SsView
    {
        public SsDpkgView(SsDpkgViewModel ssDpkgViewModel)
            : base(ssDpkgViewModel)
        {
            InitializeComponent();
        }
    }
}