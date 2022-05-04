using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Nmap.ViewModel;

namespace SecurityStudio.Module.Tool.Nmap.View
{
    public partial class SsNmapView : SsView
    {
        public SsNmapView(SsNmapViewModel ssNmapViewModel)
            : base(ssNmapViewModel)
        {
            InitializeComponent();
        }
    }
}