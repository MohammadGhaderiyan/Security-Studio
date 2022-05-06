using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.LinuxFileExplorer.ViewModel;

namespace SecurityStudio.Module.Linux.LinuxFileExplorer.View
{
    public partial class SsLinuxFileExplorerView : SsView
    {
        public SsLinuxFileExplorerView(SsLinuxFileExplorerViewModel ssLinuxFileExplorerViewModel)
            : base(ssLinuxFileExplorerViewModel)
        {
            InitializeComponent();
        }
    }
}