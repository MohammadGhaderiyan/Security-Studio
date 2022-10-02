using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Binwalk.ViewModel;

namespace SecurityStudio.Module.Tool.Binwalk.View
{
    public partial class SsBinwalkView : SsView
    {
        public SsBinwalkView(SsBinwalkViewModel ssBinwalkViewModel)
            : base(ssBinwalkViewModel)
        {
            InitializeComponent();
        }
    }
}