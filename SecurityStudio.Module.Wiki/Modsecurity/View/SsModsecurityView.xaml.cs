using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Modsecurity.ViewModel;

namespace SecurityStudio.Module.Wiki.Modsecurity.View
{
    public partial class SsModsecurityView : SsView
    {
        public SsModsecurityView(SsModsecurityViewModel ssModsecurityViewModel)
            : base(ssModsecurityViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}