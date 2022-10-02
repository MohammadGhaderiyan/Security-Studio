using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SnmpWalk.ViewModel;

namespace SecurityStudio.Module.Tool.SnmpWalk.View
{
    public partial class SsSnmpWalkView : SsView
    {
        public SsSnmpWalkView(SsSnmpWalkViewModel ssSnmpWalkViewModel)
            : base(ssSnmpWalkViewModel)
        {
            InitializeComponent();
        }
    }
}