using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.Arp.ViewModel;

namespace SecurityStudio.Module.Windows.Arp.View
{
    public partial class SsArpView : SsView
    {
        public SsArpView(SsArpViewModel ssArpViewModel)
            : base(ssArpViewModel)
        {
            InitializeComponent();
        }
    }
}