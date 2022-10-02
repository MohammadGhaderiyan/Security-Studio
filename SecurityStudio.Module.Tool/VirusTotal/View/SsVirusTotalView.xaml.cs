using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.VirusTotal.ViewModel;

namespace SecurityStudio.Module.Tool.VirusTotal.View
{
    public partial class SsVirusTotalView : SsView
    {
        public SsVirusTotalView(SsVirusTotalViewModel ssVirusTotalViewModel)
            : base(ssVirusTotalViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}