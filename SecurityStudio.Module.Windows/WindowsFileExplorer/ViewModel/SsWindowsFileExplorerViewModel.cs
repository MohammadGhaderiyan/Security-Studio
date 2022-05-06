using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Windows.WindowsFileExplorer.ViewModel
{
    public class SsWindowsFileExplorerViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Windows File Explorer";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}