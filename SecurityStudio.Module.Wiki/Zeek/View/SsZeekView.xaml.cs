using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Zeek.ViewModel;

namespace SecurityStudio.Module.Wiki.Zeek.View
{
    public partial class SsZeekView : SsView
    {
        public SsZeekView(SsZeekViewModel ssZeekViewModel)
            : base(ssZeekViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}