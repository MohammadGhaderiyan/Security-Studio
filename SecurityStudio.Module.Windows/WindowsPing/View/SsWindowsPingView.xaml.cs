using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.WindowsPing.ViewModel;

namespace SecurityStudio.Module.Windows.WindowsPing.View
{
    public partial class SsWindowsPingView : SsView
    {
        public SsWindowsPingView(SsWindowsPingViewModel ssWindowsPingViewModel)
            : base(ssWindowsPingViewModel)
        {
            InitializeComponent();
        }
    }
}