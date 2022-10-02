using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Acunetix.ViewModel;

namespace SecurityStudio.Module.Wiki.Acunetix.View
{
    public partial class SsAcunetixView : SsView
    {
        public SsAcunetixView(SsAcunetixViewModel ssAcunetixViewModel)
            : base(ssAcunetixViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}