using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.Terminal.ViewModel;

namespace SecurityStudio.Module.Linux.Terminal.View
{
    public partial class SsTerminalView : SsView
    {
        public SsTerminalView(SsTerminalViewModel sTerminalViewModel)
            : base(sTerminalViewModel)
        {
            InitializeComponent();
        }
    }
}