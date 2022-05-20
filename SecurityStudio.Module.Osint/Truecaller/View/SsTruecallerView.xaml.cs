using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint.Truecaller.ViewModel;

namespace SecurityStudio.Module.Osint.Truecaller.View
{
    public partial class SsTruecallerView : SsView
    {
        public SsTruecallerView(SsTruecallerViewModel ssTruecallerViewModel)
            : base(ssTruecallerViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}