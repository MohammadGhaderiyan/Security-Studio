using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Iana.ViewModel;

namespace SecurityStudio.Module.Tool.Iana.View
{
    public partial class SsIanaView : SsView
    {
        public SsIanaView(SsIanaViewModel ssIanaViewModel)
            : base(ssIanaViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}