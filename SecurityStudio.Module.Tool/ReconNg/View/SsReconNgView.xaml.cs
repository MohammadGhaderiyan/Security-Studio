using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.ReconNg.ViewModel;

namespace SecurityStudio.Module.Tool.ReconNg.View
{
    public partial class SsReconNgView : SsView
    {
        public SsReconNgView(SsReconNgViewModel ssReconNgViewModel)
            : base(ssReconNgViewModel)
        {
            InitializeComponent();
        }
    }
}