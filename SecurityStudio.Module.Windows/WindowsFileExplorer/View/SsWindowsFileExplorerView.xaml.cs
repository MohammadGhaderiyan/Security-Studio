using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Windows.WindowsFileExplorer.ViewModel;

namespace SecurityStudio.Module.Windows.WindowsFileExplorer.View
{
    public partial class SsWindowsFileExplorerView : SsView
    {
        public SsWindowsFileExplorerView(SsWindowsFileExplorerViewModel ssWindowsFileExplorerViewModel)
            : base(ssWindowsFileExplorerViewModel)
        {
            InitializeComponent();
        }
    }
}