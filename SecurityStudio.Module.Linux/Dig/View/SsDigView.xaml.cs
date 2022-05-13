using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Dig.ViewModel;

namespace SecurityStudio.Module.Linux.Dig.View
{
    public partial class SsDigView : SsView
    {
        public SsDigView(SsDigViewModel ssDigViewModel)
            : base(ssDigViewModel)
        {
            InitializeComponent();
        }
    }
}