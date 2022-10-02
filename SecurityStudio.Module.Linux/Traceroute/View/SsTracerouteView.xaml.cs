using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Traceroute.ViewModel;

namespace SecurityStudio.Module.Linux.Traceroute.View
{
    public partial class SsTracerouteView : SsView
    {
        public SsTracerouteView(SsTracerouteViewModel ssTracerouteViewModel)
            : base(ssTracerouteViewModel)
        {
            InitializeComponent();
        }
    }
}