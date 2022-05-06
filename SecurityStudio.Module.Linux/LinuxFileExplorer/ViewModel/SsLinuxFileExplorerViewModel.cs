using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.LinuxFileExplorer.ViewModel
{
    public class SsLinuxFileExplorerViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Linux File Explorer";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}