using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Module.Tool.PowerShell.ViewModel
{
    public class SsPowerShellViewModel : SsViewModel
    {
        protected override void PrepareSsCommands()
        {
        }

        protected override void PrepareVariables()
        {
            Title = "Power Shell";
        }

        protected override void FillData()
        {
        }

        public override void Dispose()
        {
        }
    }
}