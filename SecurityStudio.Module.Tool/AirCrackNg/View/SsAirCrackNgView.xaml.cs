using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.AirCrackNg.ViewModel;

namespace SecurityStudio.Module.Tool.AirCrackNg.View
{
    public partial class SsAirCrackNgView : SsView
    {
        public SsAirCrackNgView(SsAirCrackNgViewModel ssAirCrackNgViewModel)
            : base(ssAirCrackNgViewModel)
        {
            InitializeComponent();
        }
    }
}