using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Scapy.ViewModel;

namespace SecurityStudio.Module.Tool.Scapy.View
{
    public partial class SsScapyView : SsView
    {
        public SsScapyView(SsScapyViewModel ssScapyViewModel)
            : base(ssScapyViewModel)
        {
            InitializeComponent();
        }
    }
}