using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Osint._411.ViewModel;

namespace SecurityStudio.Module.Osint._411.View
{
    public partial class Ss411View : SsView
    {
        public Ss411View(Ss411ViewModel ss411ViewModel)
            : base(ss411ViewModel)
        {
            InitializeComponent();
        }

        public override void SsViewLoaded()
        {
        }
    }
}