using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.SnmpCheck.ViewModel;

namespace SecurityStudio.Module.Tool.SnmpCheck.View
{
    public partial class SsSnmpCheckView : SsView
    {
        public SsSnmpCheckView(SsSnmpCheckViewModel ssSnmpCheckViewModel)
            : base(ssSnmpCheckViewModel)
        {
            InitializeComponent();
        }
    }
}