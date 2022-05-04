using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.FileExplorer.ViewModel;

namespace SecurityStudio.Module.Windows.FileExplorer.View
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