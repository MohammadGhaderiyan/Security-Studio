using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Ubertooth.ViewModel;

namespace SecurityStudio.Module.Wiki.Ubertooth.View
{
    public partial class SsUbertoothView : SsView
    {
        public SsUbertoothView(SsUbertoothViewModel ssUbertoothViewModel)
            : base(ssUbertoothViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}