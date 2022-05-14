using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Mitre.Reconnaissance.ViewModel;

namespace SecurityStudio.Module.Mitre.Reconnaissance.View
{
    public partial class SsReconnaissanceView : SsView
    {
        public SsReconnaissanceView(SsReconnaissanceViewModel ssReconnaissanceViewModel)
            : base(ssReconnaissanceViewModel)
        {
            InitializeComponent();
        }
    }
}