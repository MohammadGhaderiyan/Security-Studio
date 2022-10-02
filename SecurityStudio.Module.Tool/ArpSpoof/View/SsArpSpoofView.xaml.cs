using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.ArpSpoof.ViewModel;

namespace SecurityStudio.Module.Tool.ArpSpoof.View
{
    public partial class SsArpSpoofView : SsView
    {
        public SsArpSpoofView(SsArpSpoofViewModel ssArpSpoofViewModel)
            : base(ssArpSpoofViewModel)
        {
            InitializeComponent();
        }
    }
}