using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Linux.FileExplorer.ViewModel;

namespace SecurityStudio.Module.Linux.FileExplorer.View
{
    public partial class SsFileExplorerView : SsView
    {
        public SsFileExplorerView(SsFileExplorerViewModel ssFileExplorerViewModel)
            : base(ssFileExplorerViewModel)
        {
            InitializeComponent();
        }
    }
}