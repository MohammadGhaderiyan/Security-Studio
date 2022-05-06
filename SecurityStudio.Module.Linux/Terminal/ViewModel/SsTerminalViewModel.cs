using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Linux.Terminal.ViewModel
{
    public class SsTerminalViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Terminal";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}