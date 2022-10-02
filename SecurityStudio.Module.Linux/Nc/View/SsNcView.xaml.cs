using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Nc.ViewModel;

namespace SecurityStudio.Module.Linux.Nc.View
{
    public partial class SsNcView : SsView
    {
        public SsNcView(SsNcViewModel ssNcViewModel)
            : base(ssNcViewModel)
        {
            InitializeComponent();
        }
    }
}