using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.SnmpSet.ViewModel;

namespace SecurityStudio.Module.Linux.SnmpSet.View
{
    public partial class SsSnmpSetView : SsView
    {
        public SsSnmpSetView(SsSnmpSetViewModel ssSnmpSetViewModel)
            : base(ssSnmpSetViewModel)
        {
            InitializeComponent();
        }
    }
}