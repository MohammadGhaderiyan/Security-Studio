using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Wiki.Cyberx.ViewModel;

namespace SecurityStudio.Module.Wiki.Cyberx.View
{
    public partial class SsCyberxView : SsView
    {
        public SsCyberxView(SsCyberxViewModel ssCyberxViewModel)
            : base(ssCyberxViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}