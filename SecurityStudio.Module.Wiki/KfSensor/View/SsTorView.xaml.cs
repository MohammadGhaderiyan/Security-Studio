using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.KfSensor.ViewModel;

namespace SecurityStudio.Module.Wiki.KfSensor.View
{
    public partial class SsKfSensorView : SsView
    {
        public SsKfSensorView(SsKfSensorViewModel ssKfSensorViewModel)
            : base(ssKfSensorViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}